using System;
using System.Threading;
using System.Windows.Forms;

namespace BruteForce
{
    public partial class PasswordGenerator : Form
    {

        private char[] ar = {'a', 'b','c','d','e','f','g','h','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z',
            '1','2','3','4','5','6','7','8','9','0','=','/','¿','?',',','.',':',';','+','-','*','Ç','ç','!','¡','-','_','%','&','(',')',
            '$','€','@','"','\'','\\','|','º','ª','¬','{','}','<','>'};

        public PasswordGenerator()
        {
            InitializeComponent();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = int.Parse(nMin.Value.ToString()); i <= nMax.Value; i++)
                {
                    char[] pass = new char[i];
                    recursion(ref pass, 0, i);
                }
                
            }
            catch (Exception)
            {

            }
        }

        private void recursion(ref char[] pass, int index, int maxLength)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                pass[index] = ar[i];

                if (index < maxLength-1)
                {
                    recursion(ref pass, index+1, maxLength);
                }
                else
                {
                    //File.AppendAllText("C:\\Users\\Laura\\Desktop\\passwords.txt", String.Concat(pass) + Environment.NewLine);
                    passwords.AppendText(String.Concat(pass) + "\n");
                }
            }
        }
    }
}
