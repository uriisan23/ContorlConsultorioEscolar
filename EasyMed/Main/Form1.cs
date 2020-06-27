using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using EasyMed.Section;
using EasyMed.Medical;

namespace EasyMed
{
    public partial class Form1 : Form
    {
        private string nameSession = null;


        private void ActivadedSession()
        {

            this.UserLabel.Text = GlobalComponents.getSesion;
            nameSession = GlobalComponents.getSesion;
            this.UserLabel.Visible = true;
        }

        private void fillAlumno()
        {

            int i = 0;

            EventDataProcessor fillTypes = new EventDataProcessor();
           

            List<string> myList = new List<string>();

            myList = fillTypes.getFillType();

            string[] Types = new string[myList.Count];


            foreach (var item in myList)
            {
                
                Types[i] = item;
                i++;
            }

            this.TypeBox.Items.AddRange(Types);




        }

        public Form1()
        {
            InitializeComponent();
            this.fillAlumno();

           
        }

        //public Form1(string args)
        //{
        //    InitializeComponent();
        //    nameSession = args;
        //    this.UserLabel.Text = nameSession;
        //}



        //private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MainMenu.Width == 235)
            {
                this.MainMenu.Width = 47;
                this.UserLabel.Location = new System.Drawing.Point(95, 29);

            }
            else
            {
                this.MainMenu.Width = 235;
                this.UserLabel.Location = new System.Drawing.Point(286, 29);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ActivadedSession();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if( String.IsNullOrEmpty(nameSession))
            //{

            //}
            //else 
            //{
            //    MessageBox.Show("prueba");
            //}

            if (RegistroPanel.Visible)
            {
                RegistroPanel.Visible = false;
            }
            else
            {
                RegistroPanel.Visible = true;
            }
        }


        
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login LoginView = new Login();
            LoginView.Show();
        }

        private void SendHome_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Justify.Visible == false)
                this.Justify.Visible = true;
            else
                this.Justify.Visible = false;
        }


        private void Insurance_CheckedChanged(object sender, EventArgs e)
        {
            if (this.InsuranceBox.Visible == false)
                this.InsuranceBox.Visible = true;
            else
                this.InsuranceBox.Visible = false;
        }

        

        private void Justify_Click(object sender, EventArgs e)
        {
            if (Justify.Checked == false)
                Justify.Checked = true;
            else 
                Justify.Checked = false;
        }

       
       

        private void subConfigButton_Click(object sender, EventArgs e)
        {
           
        }

       

        private void visitasSetup_Click(object sender, EventArgs e)
        {
            VisitView visit = new VisitView();
            visit.Show();
        }

        private void SetupPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (AdminPanel.Visible == false)
            {
              //  tableLayoutPanel1.Visible = true;
                AdminPanel.Visible = true;
                SetupPanel.Visible = false;
            }
            else
            {
                //tableLayoutPanel1.Visible = false;
                AdminPanel.Visible = false;


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (SetupPanel.Visible == false)
            {
               // tableLayoutPanel1.Visible = true;
                SetupPanel.Visible = true;
                AdminPanel.Visible = false;
            }
            else
            {
              //  tableLayoutPanel1.Visible = false;
                SetupPanel.Visible = false; 
            }
        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sectionSetup_Click(object sender, EventArgs e)
        {
            SectionView section = new SectionView();
            section.Show();
        }

        private void Medicalsetup_Click(object sender, EventArgs e)
        {
            MedicalView medic = new MedicalView();

            medic.Show();
        }
    }

}