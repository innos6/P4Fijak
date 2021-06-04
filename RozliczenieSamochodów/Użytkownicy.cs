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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.użytkownicyBindingSource.DataSource = getData.getUsersItem();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                addData.addUser(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), textBox6.Text, textBox7.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.użytkownicyBindingSource.DataSource = getData.getUsersItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                removeData.removeUser(int.Parse(textBox8.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.użytkownicyBindingSource.DataSource = getData.getUsersItem();
        }
    }
}
