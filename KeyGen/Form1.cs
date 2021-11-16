using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal oldValue;
        char pass;
        int strok;
        int number;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int lens = (int)numericUpDown1.Value; ;
            Random random_symbol = new Random();
            Random random = new Random();
            
            for (int i = 0; i < lens; i++)
            {
                strok = random.Next(0, 5);
                if (strok == 0)
                {
                    number = random.Next(0, 9);
                    richTextBox1.Text += number.ToString();
                }
                else {
                    
                    pass = (char)random_symbol.Next(33, 122);
                    richTextBox1.Text += pass.ToString();
                }
                    
            }

            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savepass = new SaveFileDialog();
            savepass.DefaultExt = ".txt";
            savepass.Filter = "Pass|*.txt";
            if (savepass.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                using (StreamWriter passs = new StreamWriter(savepass.FileName, true))

                {
                    passs.WriteLine(richTextBox1.Text + "\n" + "\n" + "\n" + "\n" + "Сохраните пароль)");
                    passs.Close();
                
                }
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter) {
                button2_Click(button2, null);
            }
        }
    }
}
