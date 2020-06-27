using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMed.Medical
{
    public partial class MedicalView : Form
    {
        EventDataProcessor DataProcessor = new EventDataProcessor();
        MedicalForm medicalJobs = new MedicalForm();

        public MedicalView()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (newMedical.Width == 33)
            {
                newMedical.Width = 391;
             }
            else
                newMedical.Width = 33;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSection_Click(object sender, EventArgs e)
        {

            medicalJobs.addMedicine(this.medicalChainString());
            fillWithDataAdapter();
            clearForm();
                        
        }

        private void DelSection_Click(object sender, EventArgs e)
        {
            medicalJobs.delMedicine(this.barCode.Text);
            fillWithDataAdapter();
            clearForm();
        }


        private void MedicalView_Load(object sender, EventArgs e)
        {
            // fillGrid();
            fillWithDataAdapter();
        }

        private void fillGrid()
        {

            MedicalGrid.DataSource = DataProcessor.getFillMedical().Select
                (x => new
                {
                    Codigo = x.BarCode,
                    Nombre = x.Name,
                    Formula = x.Formula,
                    Presentacion = x.Presentation,
                    Caducidad = x.ExpDate,
                    Peso = x.WeightQty,
                    Unidad = x.WeightUnit,
                    Contenido = x.ContentQty,
                    Dosis = x.DosisQty
                }).ToList();
        }

        private void fillWithDataAdapter()
        {
            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter adapter = new SqlDataAdapter();

            // A table mapping names the DataTable.
            adapter.TableMappings.Add("Table", "MedicalTable");

            // Open the connection.
            DataProcessor.getStreamOn();
            Console.WriteLine("The SqlConnection is open.");

            // Create a SqlCommand to retrieve Suppliers data.
            //SqlCommand command = DataProcessor.execCommand("SELECT * FROM dbo.MedicalTable;");
            SqlCommand command = DataProcessor.execCommand(DataProcessor.getMedicalView());
            //new SqlCommand(
            //"SELECT * FROM dbo.MedicalTable;",
            //Coneccion);
            command.CommandType = CommandType.Text;
            
            // Set the SqlDataAdapter's SelectCommand.
            adapter.SelectCommand = command;

            // Fill the DataSet.
            // DataSet dataSet = new DataSet("MedicalTable");

            //Create the Data Table element
            DataTable table = new DataTable();

            // Fill the Data Table with the Data Adapter
            adapter.Fill(table);

            MedicalGrid.DataSource = table;

        }


        private string medicalChainString()
        {
            string medicineValues;

            string text1 = (!GlobalComponents.IsEmptyText(this.barCode.Text))? this.barCode.Text :null;
            string text2 = (!GlobalComponents.IsEmptyText(this.textBox1.Text)) ? this.textBox1.Text : null;
            string text3 = (!GlobalComponents.IsEmptyText(this.textBox2.Text)) ? this.textBox2.Text : null;
            string text4 = (!GlobalComponents.IsEmptyText(this.textBox3.Text)) ? this.textBox3.Text : null;
            string date =  (this.dateTimePicker2.Value.Date > DateTime.Now.Date)? $"{(this.dateTimePicker2.Value):yyyy/MM/dd}": null;
            string text5 = (!GlobalComponents.IsEmptyText(this.textBox4.Text)) ? this.textBox4.Text : null;
            string text6 = (!GlobalComponents.IsEmptyText(this.textBox5.Text)) ? this.textBox5.Text : null;
            string text7 = (!GlobalComponents.IsEmptyText(this.textBox6.Text)) ? this.textBox6.Text : null;
            string text8 = (!GlobalComponents.IsEmptyText(this.textBox7.Text)) ? this.textBox7.Text : null;



            if (text1 == null || text2 == null || text3 == null || date == null || text4 == null || text5 == null || text6 == null || text7 == null || text8 == null)
            {
                medicineValues = "";
            }
            else
            {
                medicineValues =

                 $"{this.barCode.Text},'{this.textBox1.Text}','{this.textBox2.Text}','{this.textBox3.Text}'," +
                 $"'{(this.dateTimePicker2.Value):yyyy/MM/dd}',{this.textBox4.Text},'{ this.textBox5.Text}'," +
                 $"{this.textBox6.Text },{this.textBox7.Text}," +
                 $"'{DateTime.Now:yyy/MM/dd HH:mm}','{GlobalComponents.getSessionId}'," +
                 $"{((this.radioButton1.Checked) ? "1" : "0")}";

               }

 
            return medicineValues;

        }


        private void clearForm()
        {
           this.barCode.Text = null;
           this.textBox1.Text = null;
           this.textBox2.Text = null;
           this.textBox3.Text = null;
           this.dateTimePicker2.Value = DateTime.Now;
           this.textBox4.Text = null;
           this.textBox5.Text = null;
           this.textBox6.Text = null;
           this.textBox7.Text = null;
        }


    }
}
