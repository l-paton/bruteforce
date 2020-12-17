
namespace BruteForce
{
    partial class Victim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.keyName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.paramName = new System.Windows.Forms.TextBox();
            this.paramValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isJson = new System.Windows.Forms.CheckBox();
            this.url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // keyName
            // 
            this.keyName.Location = new System.Drawing.Point(159, 256);
            this.keyName.Name = "keyName";
            this.keyName.Size = new System.Drawing.Size(267, 22);
            this.keyName.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Key name";
            // 
            // paramName
            // 
            this.paramName.Location = new System.Drawing.Point(159, 127);
            this.paramName.Name = "paramName";
            this.paramName.Size = new System.Drawing.Size(267, 22);
            this.paramName.TabIndex = 32;
            // 
            // paramValue
            // 
            this.paramValue.Location = new System.Drawing.Point(159, 173);
            this.paramValue.Name = "paramValue";
            this.paramValue.Size = new System.Drawing.Size(267, 22);
            this.paramValue.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Param value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Param name";
            // 
            // isJson
            // 
            this.isJson.AutoSize = true;
            this.isJson.Location = new System.Drawing.Point(40, 221);
            this.isJson.Name = "isJson";
            this.isJson.Size = new System.Drawing.Size(92, 21);
            this.isJson.TabIndex = 28;
            this.isJson.Text = "JsonBody";
            this.isJson.UseVisualStyleBackColor = true;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(83, 77);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(343, 22);
            this.url.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Url";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(171, 371);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 38);
            this.btnOk.TabIndex = 35;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Victim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.keyName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paramName);
            this.Controls.Add(this.paramValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isJson);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label1);
            this.Name = "Victim";
            this.Text = "Victim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox paramName;
        private System.Windows.Forms.TextBox paramValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isJson;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
    }
}