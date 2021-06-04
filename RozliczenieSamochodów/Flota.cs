using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozliczenieSamochodów
{
    public partial class Flota : Form
    {
        public Flota()
        {
            InitializeComponent();
            
        }

        private void Flota_Load(object sender, EventArgs e)
        {
            this.samochodyBindingSource.DataSource = getData.getFlotaItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                addData.addCar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, decimal.Parse(textBox7.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.samochodyBindingSource.DataSource = getData.getFlotaItems();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                removeData.removeCar(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.samochodyBindingSource.DataSource = getData.getFlotaItems();
        }
    }
}
