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
    public partial class NewCard : Form
    {
        public NewCard()
        {
            InitializeComponent();
        }

        public delegate void addedCardEventHandler(object sender, EventArgs e);
        public event addedCardEventHandler addedCard;

        public virtual void OnAddedCard(EventArgs e)
        {
            addedCard.Invoke(this, new EventArgs { });
        }

        private void NewCard_Load(object sender, EventArgs e)
        {
            this.samochodyBindingSource.DataSource = getData.getFlotaItems();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                addData.addCard(int.Parse(textBox1.Text), int.Parse(textBox2.Text), listBox1.SelectedValue.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            OnAddedCard(EventArgs.Empty);
        }
    }
}
