using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ADO.NET_Spotify
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = SqlHelper.ExecuteQuery($"SELECT Id FROM Users WHERE Username='{username.Text}' and Password='{SqlHelper.HashPassword(password.Text)}'   ");
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Xoş gəldiniz");
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya parolu yalnışdır.");
            }

        }


    }
}
