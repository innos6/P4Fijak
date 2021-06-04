using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace zadanie5
{
    

    public partial class Form1 : Form
    {
        private List<User> users;

        public Form1()
        {
            InitializeComponent();
            this.users = new List<User>();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var logins = users.Where(x=>x.login == RegisterLoginBox.Text).Select(x=>x.login) ;
            if (RegisterLoginBox.Text.Equals(""))
            {
                MessageBox.Show("Proszę podać login!");
            }
            else if (logins.Count() != 0)
            {
                MessageBox.Show("Podany login zajęty!");
            }
            else if(!RegisterPasswordBox.Text.Equals(RegisterPasswordConfirmBox.Text))
            {
                MessageBox.Show("Podane hasła różnią się od siebie!");
            }
            else if (!RegisterCheckBox.Checked)
            {
                MessageBox.Show("Do rejestracji konieczna zgoda RODO!");
            }
            else 
            {
                users.Add(new User(RegisterLoginBox.Text, RegisterPasswordBox.Text, users)) ;
                string message = $"Utworzono konto użytkownika: "+ RegisterLoginBox.Text+" i id: "+ users.Last().id.ToString();
                MessageBox.Show(message);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            var logins = users.Where(x => x.login == LoginLoginBox.Text).Select(x => x.login);
            var pass = users.Where(x => x.login == LoginLoginBox.Text).Select(x => x.password);
            if (logins.Count() == 0)
            {
                MessageBox.Show("Nie znaleziono użytkownika.");
            }
            else if (!(pass.First().Equals(CreateMD5(LoginPasswordBox.Text))))
            {
                MessageBox.Show("Podano złe hasło!");
            }
            else
            {
                MessageBox.Show("Zalogowano pomyślnie!");
            }
            
        }

        private void RegisterLoginBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
