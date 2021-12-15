namespace SendFileServer
{
    partial class Form1
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
            this.btn_Brows = new System.Windows.Forms.Button();
            this.btn_RecFile = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Brows
            // 
            this.btn_Brows.Location = new System.Drawing.Point(556, 137);
            this.btn_Brows.Name = "btn_Brows";
            this.btn_Brows.Size = new System.Drawing.Size(42, 23);
            this.btn_Brows.TabIndex = 15;
            this.btn_Brows.Text = "...";
            this.btn_Brows.UseVisualStyleBackColor = true;
            this.btn_Brows.Click += new System.EventHandler(this.btn_Brows_Click);
            // 
            // btn_RecFile
            // 
            this.btn_RecFile.Enabled = false;
            this.btn_RecFile.Location = new System.Drawing.Point(76, 175);
            this.btn_RecFile.Name = "btn_RecFile";
            this.btn_RecFile.Size = new System.Drawing.Size(112, 23);
            this.btn_RecFile.TabIndex = 14;
            this.btn_RecFile.Text = "Recieve File";
            this.btn_RecFile.UseVisualStyleBackColor = true;
            this.btn_RecFile.Click += new System.EventHandler(this.btn_RecFile_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(76, 139);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(474, 20);
            this.txt_FilePath.TabIndex = 13;
            this.txt_FilePath.TextChanged += new System.EventHandler(this.txt_FilePath_TextChanged);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(76, 81);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(141, 20);
            this.txt_Port.TabIndex = 12;
            this.txt_Port.Text = "5050";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(76, 32);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(141, 20);
            this.txt_IP.TabIndex = 11;
            this.txt_IP.Text = "172.20.3.31";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Path File :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(618, 252);
            this.Controls.Add(this.btn_Brows);
            this.Controls.Add(this.btn_RecFile);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Brows;
        private System.Windows.Forms.Button btn_RecFile;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

