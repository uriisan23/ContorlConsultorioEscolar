using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace EasyMed
{
    class VisitForm
    {

        EventDataProcessor DataProcessor = new EventDataProcessor();
        SqlDataReader Reader;
        SqlCommand cmdExec;

        private string tsql;

        
        private string sqlAdd(int Id, string Type)
        {
            string tsql = $"Insert into VisitTable (NoReg, VisitType) values ('{Id}','{Type}' )";
            return tsql;
        }
        private string sqlDel(string Type)
        {
            string tsql = $"Delete from VisitTable where VisitType = '{Type}'";

            return tsql;
        }

        private string visitItemValidation(string visit)
        {
            string tsql = $"Select VisitType from VisitTable where VisitType = '{visit}'";

            return tsql;
        }

       

        public void addType(string item)
        {
                int.TryParse(item.Substring(0, 1), out int Id);

                string Tipo = item.Substring(2);

                Regex IsChar = new Regex(@"\w");

                bool isText = IsChar.IsMatch(Tipo);

                if (!visitValidation(Tipo))
                {
                    if (Id == 0)
                    {
                        MessageBox.Show($"El primer argumento debe ser un numero entero");
                    }
                    else if (isText)
                    {
                        try
                        {

                            DataProcessor.getStreamOn();

                            cmdExec = DataProcessor.execCommand(sqlAdd(Id, Tipo));

                            cmdExec.ExecuteNonQuery();

                            MessageBox.Show($"El valor {Id} , {Tipo} se ha agregado correctamente.");
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
                        MessageBox.Show($"El segundo argumento solo debe contener texto");
                }
                else
                {
                    MessageBox.Show($"Ya existe un miembro {Tipo} en el catalogo");
                }
            }
            

        public void delType(string item)
        {
            if(visitValidation(item))
            {

                var Warning = MessageBox.Show($"Esta a punto de eliminar un elemento \n Desea continuar", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


                 if (Warning == DialogResult.OK)
                {  
                    try
                    {
                        DataProcessor.getStreamOn();
                        cmdExec = DataProcessor.execCommand(sqlDel(item));
                        cmdExec.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"Response : {e}");
                    }
                    finally
                    {
                        DataProcessor.getStreamOff();
                    }
                }
            }
        }

        private bool visitValidation(string item)
        {
            bool Response = false;
            try
            {
                DataProcessor.getStreamOn();
                Reader = DataProcessor.execReader(visitItemValidation(item));

                if (Reader.Read())
                    Response = true;
            }
            catch(Exception e)
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
