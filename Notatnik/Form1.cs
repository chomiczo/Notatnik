using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notatnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader str = new StreamReader(openFileDialog1.FileName))
                {
                    string wiersz;
                    while ((wiersz = str.ReadLine()) != null)
                    {
                        list.Add(wiersz);
                    }
                }
                textBox1.Lines = list.ToArray(); 
                //textBox1.Text = str.ReadToEnd();
            }
        }
    }
}
