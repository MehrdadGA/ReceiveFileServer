using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------------------------
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace SendFileServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Brows_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                txt_FilePath.Text = fb.SelectedPath;
            }
        }

        public void getFile()
        {
            Socket sGetFile = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(txt_IP.Text), int.Parse(txt_Port.Text));
            sGetFile.Bind(iPEndPoint);
            sGetFile.Listen(1);
            while (true)
            {
                Socket SC = sGetFile.Accept();
                byte[] b = new byte[1024 * 50000];
                int RB = SC.Receive(b);
                int fileNameLen = BitConverter.ToInt32(b, 0);
                string nameFile = Encoding.ASCII.GetString(b, 4, fileNameLen);
                BinaryWriter BWriter = new BinaryWriter(File.Open(txt_FilePath.Text + "/" + nameFile, FileMode.Append));
                BWriter.Write(b, 4 + fileNameLen, RB - 4 - fileNameLen);
                BWriter.Close();
            }
        }

        private void txt_FilePath_TextChanged(object sender, EventArgs e)
        {
            btn_RecFile.Enabled = txt_FilePath.Text.Trim() != "";
        }

        private void btn_RecFile_Click(object sender, EventArgs e)
        {
            Thread tr = new Thread(new ThreadStart(getFile));
            tr.IsBackground = true;
            tr.Start();
            btn_RecFile.Enabled=false;
        }
    }
}
