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
    public partial class VisitView : Form
    {

                
        private   EventDataProcessor DataProcessor = new EventDataProcessor();
        private   VisitForm visitJobs = new VisitForm();
        

        public VisitView()
        {
            InitializeComponent();
        }

        private void VisitView_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

       

        private void fillGrid()
        {
          
           VisitGrid.DataSource = DataProcessor.getFillVisit().Select
                (x=> new {Tipo = x}).ToList();
        }
           


        private void AddVisit_Click(object sender, EventArgs e)
        {
            visitJobs.addType(VisitName.Text);
            VisitName.Text = null;
            fillGrid();

        }

        private void DelVisit_Click(object sender, EventArgs e)
        {
            if (GlobalComponents.IsEmptyText(VisitName.Text))
            {
                warningText.Text = "El campo no puede estar vacío";
                warningText.Visible = true;
            }
            else
            {
                visitJobs.delType(VisitName.Text);
                VisitName.Text = null;
                fillGrid();
            }
        }

        private void VisitGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisitName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (warningText.Visible == true)
             warningText.Visible = false;
        }
    }
}
