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
    public partial class SectionView : Form
    {
        private EventDataProcessor DataProcessor = new EventDataProcessor();
        private SectionForm sectionJobs = new SectionForm();

        public SectionView()
        {
            InitializeComponent();
        }

       
    private void fillGrid()
        {
        SectionGrid.DataSource = DataProcessor.getFillSection().Select
        (x => new {No= x.Key, Section = x.Value }).ToList();

         }
        

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SectionView_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void AddSection_Click(object sender, EventArgs e)
        {
           if(GlobalComponents.IsEmptyText(SectionName.Text))
            {
                warningText.ForeColor = System.Drawing.Color.Red;
                warningText.Text = "El campo no puede estar vacío";
                warningText.Visible = true;
            }
           else
            {
                sectionJobs.addSection(SectionName.Text);
                SectionName.Text = null;
                fillGrid();
            }
           
        }

        private void DelSection_Click(object sender, EventArgs e)
        {
            if (GlobalComponents.IsEmptyText(SectionName.Text))
            {
                warningText.ForeColor = System.Drawing.Color.Red;
                warningText.Text = "El campo no puede estar vacío";
                warningText.Visible = true;
            }
            else
            {
                sectionJobs.delSection(SectionName.Text);
                SectionName.Text = null;
                fillGrid();
            }

        }

        private void SectionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (warningText.Visible == true)
                warningText.Visible = false;
        }
    }
}
