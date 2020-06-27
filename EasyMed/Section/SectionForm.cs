using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EasyMed
{
    class SectionForm
    {
        EventDataProcessor DataProcessor = new EventDataProcessor();
        SqlDataReader Reader;
        SqlCommand cmdExec;

        private string tsql;

     
        private string sqlAdd(string sectionItem)
        {
            tsql = $"Insert into SectionTable (SectionName) values ('{sectionItem}')";

            return tsql;
        }

        private string sqlDel(string sectionItem)
        {
            tsql = $"Delete from SectionTable where sectionName = '{sectionItem}';";
            return tsql;
        }

        private string sectionItemValidatioin(string sectionItem)
        {
            tsql = $"select SectionName from SectionTable Where SectionName = '{sectionItem}';";

            return tsql;
        }




        public void addSection(string sectionItem)
        {
            Regex isChar = new Regex(@"\w");

            bool isText = isChar.IsMatch(sectionItem);

            if (isText)
            {
                if (!SectionValidation(sectionItem))
                {
                    try
                    {
                        DataProcessor.getStreamOn();

                        cmdExec = DataProcessor.execCommand(sqlAdd(sectionItem));
                        cmdExec.ExecuteNonQuery();

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
                    MessageBox.Show($"Ya existe un miembro {sectionItem} en el catalogo");

            }
            else
            {
                MessageBox.Show("No se admiten caracteres especiales +!_@","Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        public void delSection(string sectionItem)
        {
            if (SectionValidation(sectionItem))
            {
                DialogResult Warning = MessageBox.Show($"Esta a punto de eliminar un elemento \n Desea continuar", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (Warning == DialogResult.OK)
                {
                    try
                    {
                        DataProcessor.getStreamOn();
                        cmdExec = DataProcessor.execCommand(sqlDel(sectionItem));

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
        /// <summary>
        /// Valida la concordancia con un campo en un datasource de tipo EventDataProcessor
        /// </summary>
        /// <param name="Item"></param>
        /// <returns>True si hay concordancia</returns>
        private bool SectionValidation(string Item)
        {
            bool Response = false;

            try
            {
                DataProcessor.getStreamOn();

                Reader = DataProcessor.execReader(sectionItemValidatioin(Item));

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
