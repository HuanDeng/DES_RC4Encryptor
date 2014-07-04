using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Dongle
{
    public partial class Form1 : Form
    {
        private string Key = "pyxis=1$";
        private string Rc4Key = "pyxis2013";
        public Form1()
        {
            InitializeComponent();
        }
        EncryptSystem es = new EncryptSystem();
        private void encrypt_b_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Please select a file";
            //openFileDialog.Filter = "txt(*.txt)|*.txt";
            //openFileDialog.FileName = "Json";
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {

                string fileBytes = File.ReadAllText (openFileDialog.FileName);
                string newfileBytes = es.Encrypt(fileBytes, Key);
                string filePath = Path.GetDirectoryName(openFileDialog.FileName) +"\\"+ Path.GetFileNameWithoutExtension (openFileDialog.FileName)+"Encrypt" + ".db";
                File.WriteAllText(filePath, newfileBytes);
            }
        }
        private void decrypt_b_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Please select a file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               // byte[] fileByte = File.ReadAllBytes(openFileDialog.FileName);
               // //byte[] results=Rc4Crpter
               //// string result = System.Text.Encoding.ASCII.GetString(fileByte);
               // //string binggo = Rc4Crpter.Decrypt(fileByte, "pyxis2013", CryptoBase.EncoderMode.HexEncoder);
               // byte[] binggo = Rc4Crpter1.DecryptEx(fileByte, "pyxis2013");
               // string pp = System.Text.Encoding.Default.GetString(binggo);

                string fileBytes = File.ReadAllText(openFileDialog.FileName);
                string newfileBytes = es.Decrypt(fileBytes, Key);
                string filePath = Path.GetDirectoryName(openFileDialog.FileName) + "\\" + Path.GetFileNameWithoutExtension(openFileDialog.FileName) + "Decrypt" + ".txt";
                File.WriteAllText(filePath, newfileBytes);
                string[] ds = File.ReadAllLines(filePath);
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Key = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Key = textBox1.Text;
        }

    }

}
