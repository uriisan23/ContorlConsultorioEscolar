using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMed.Medical
{
    class MedicalForm
    {
        private EventDataProcessor DataProcessor = new EventDataProcessor();
        private SqlCommand cmdExec;
        private SqlDataReader Reader;
        private string tsql;

        public int BarCode { get; set; }
        public string Name { get; set; }
        public string Formula { get; set; }
        public string Presentation { get; set; }
        public string ExpDate { get; set; }
        public int WeightQty { get; set; }
        public string WeightUnit { get; set; }
        public int ContentQty { get; set; }
        public decimal DosisQty { get; set; }


        private string sqlAdd( string _meds)
        {
            tsql = "insert into MedicalTable" +
                   "(BarCode6, ComercialName, Formula, Presentation, expirDate, WeightQty, WeightUnit, ContentQty, DosisQty," +
                   " entryDate, UserIdRef, IsEnable)" +
                   "  values (" + _meds + " ) ";

            //251899, 'METOCLOPRAMIDA',  'clorhidrato de Metoclopramida-Excipiente cpb',  'Tabletas',  '2027/09/01',   10,  'grs',  20,  2,  2," +
            //"3,  01 / 12 / 2019,  'usanchez',   1

            return tsql;
        }

        private string sqlDel(int _meds)
        {
            tsql = $"delete from  MedicalTable where BarCode6 ={_meds}";

            return tsql;
        }

        private string  medicineItemValidation(int medicineItem)
        {
            tsql = $"select Barcode6 from MedicalTable where Barcode6 = {medicineItem}";

            return tsql;
        }

        public void addMedicine(string meds)
        {

            if (!GlobalComponents.IsEmptyText(meds))
            {
                if (!medicalValidation(meds))
                {

                    try
                    {
                        DataProcessor.getStreamOn();

                        cmdExec = DataProcessor.execCommand(sqlAdd(meds));
                        cmdExec.ExecuteNonQuery();

                        MessageBox.Show($"Medicamento ingresado con Exito");
                    }
                    catch (Exception e)
                    {

                        GlobalComponents.InsertError(e);
                    }
                    finally
                    {
                        DataProcessor.getStreamOff();
                    }
                }
                else
                {
                    MessageBox.Show($"Ya existe un codigo similar en el catalogo");
                }
            }
            else
            {
                MessageBox.Show($"Todos los campos son obligatorios");
            }


        }

        public void delMedicine( string code)
        {
            if (!GlobalComponents.IsEmptyText(code))
            {
                ///TODO
                ///hay que agregar una validacion, si hay existencias no se puede eliminar
                int barcode = int.Parse(code);
                try
                {
                    DialogResult a = MessageBox.Show("El elemento se eliminara de manera definitiva \n ¿desea continuar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (a == DialogResult.OK)
                    {
                        DataProcessor.getStreamOn();
                        cmdExec = DataProcessor.execCommand(this.sqlDel(barcode));
                        cmdExec.ExecuteNonQuery();

                        MessageBox.Show("Se elimino el registro");
                    }
                    
                }
                catch (Exception e)
                {

                    GlobalComponents.InsertError(e);
                }
                finally
                {
                    DataProcessor.getStreamOff();
                }
            }
            else
            {
                MessageBox.Show($"El codigo del medicamento es obligatorio");
            }
        }

        private bool medicalValidation(string medicine)
        {

            bool Response = false;
            

            string[] _args = medicine.Split(',');

             try
                {
                    DataProcessor.getStreamOn();

                int code = int.Parse(_args[0].ToString());

                    Reader = DataProcessor.execReader(medicineItemValidation(code));

                if (Reader.Read())
                    Response = true;

                }
                catch (Exception e)
                {

                MessageBox.Show($"Response : {e}");
                 }
            finally
            {
                DataProcessor.getStreamOff();
            }

            return Response;
        }

    }
}
