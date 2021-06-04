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
    public partial class Karta_miesieczna : Form
    {
        public Karta_miesieczna(int month, int year, string reg)
        {
            InitializeComponent();
            this.month.Text = month.ToString();
            this.year.Text = year.ToString();
            this.reg.Text = reg;
        }

        private void przejazdBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Karta_miesieczna_Load(object sender, EventArgs e)
        {
            this.użytkownicyBindingSource.DataSource = getData.getUsersItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cel = "";
            if (radioButton1.Checked && !radioButton2.Checked)
            {
                cel = "prywatny";
            }else if(!radioButton1.Checked && radioButton2.Checked)
            {
                cel = "służbowy";
            }else
            {
                MessageBox.Show("Cel podróży może mieć tylko jedną wartość!");
            }
            try
            {
                addData.addPrzejazd(int.Parse(textBox1.Text)
                                    , cel, textBox2.Text
                                    , int.Parse(textBox3.Text)
                                    , int.Parse(textBox4.Text)
                                    , int.Parse(listBox1.SelectedValue.ToString())
                                    , int.Parse(this.month.Text)
                                    , int.Parse(this.year.Text)
                                    , this.reg.Text  );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            przejazdBindingSource.DataSource = getData.getPrzejazdy(int.Parse(this.month.Text), int.Parse(this.year.Text), this.reg.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in dataGridView1.SelectedRows)
                {
                    var k = int.Parse(item.ToString().Substring(24).Remove(1, 2));
                    removeData.removePrzejazd(int.Parse(dataGridView1.Rows[k].Cells[0].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            przejazdBindingSource.DataSource = getData.getPrzejazdy(int.Parse(this.month.Text), int.Parse(this.year.Text), this.reg.Text);
        }
    }
}
