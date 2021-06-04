using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (Model1 dbContext = new Model1())
            {
                foreach (var item in dbContext.Samochody)
                {
                    textBox1.AppendText($"\n"+item.Marka) ;
                    textBox1.AppendText($"\n" + item.Model);
                    textBox1.AppendText($"\n" + item.Nr_rejestracyjny);

                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("off")){
                button1.Text = "on";
            }
            else
            {
                button1.Text = "off";
            }
        }
    }
}
