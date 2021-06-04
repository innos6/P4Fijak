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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }

        public virtual void OnAddedCard(object sender, EventArgs e)
        {
            this.miesięcznaKartaDrogowaBindingSource.DataSource = getData.getMonthCard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var flotaForm = new Flota();
            flotaForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var usersForm = new Users();
            usersForm.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.miesięcznaKartaDrogowaBindingSource.DataSource = getData.getMonthCard();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newCardDialog = new NewCard();
            newCardDialog.addedCard+=this.OnAddedCard;
            newCardDialog.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in dataGridView1.SelectedRows)
                {
                    var k = int.Parse(item.ToString().Substring(24).Remove(1, 2));
                    removeData.removeCard(int.Parse(dataGridView1.Rows[k].Cells[0].Value.ToString()),
                                          int.Parse(dataGridView1.Rows[k].Cells[1].Value.ToString()),
                                          dataGridView1.Rows[k].Cells[2].Value.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.miesięcznaKartaDrogowaBindingSource.DataSource = getData.getMonthCard();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            try
            {
                foreach (var item in dataGridView1.SelectedRows)
                {
                    var k = int.Parse(item.ToString().Substring(24).Remove(1, 2));
                    var kartaMiesieczna = new Karta_miesieczna(int.Parse(dataGridView1.Rows[k].Cells[0].Value.ToString()),
                                                                                            int.Parse(dataGridView1.Rows[k].Cells[1].Value.ToString()),
                                                                                            dataGridView1.Rows[k].Cells[2].Value.ToString());
                    
                    kartaMiesieczna.przejazdBindingSource.DataSource = getData.getPrzejazdy(int.Parse(dataGridView1.Rows[k].Cells[0].Value.ToString()),
                                                                                            int.Parse(dataGridView1.Rows[k].Cells[1].Value.ToString()),
                                                                                            dataGridView1.Rows[k].Cells[2].Value.ToString());
                    kartaMiesieczna.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //kartaMiesieczna.ShowDialog();
        }
    }
}
