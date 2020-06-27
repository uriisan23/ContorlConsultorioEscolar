using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMed
{
    public partial class Login : Form
    {

        EventDataProcessor getAcctionData =  new EventDataProcessor();
        string ActiveSession;


        public Login()
        {
            InitializeComponent();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            this.ForeColor = System.Drawing.SystemColors.InfoText;
        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {
            this.ForeColor = System.Drawing.SystemColors.InfoText;
        }

     

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string access = getAcctionData.getLogin(User.Text, pwd.Text);


            if (access.Contains("Error"))
            {
                MessageBox.Show(access);
            }
            else
            {
                MessageBox.Show("Bienvenido " + access);

                GlobalComponents.getSesion = access;
                GlobalComponents.getSessionState = true;
                GlobalComponents.getSessionId = this.User.Text;
            
                this.Close();
            }
         
        }
    }
}
