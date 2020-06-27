using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.CodeDom;
using EasyMed.Medical;

namespace EasyMed
{
   
    sealed partial class EventDataProcessor
    {
        SqlConnection Connector;
        

        private void InitializeComponents()
        {
            DataConnector localConn = new DataConnector();
            Connector = localConn.initializeDataComponent();
        }


        public void getStreamOn()
        {
            string error;

            InitializeComponents();

            try
            {
                Connector.Open();
            }
            catch (Exception e)
            {
                error = e.ToString();
                // MessageBox.Show("Error retrieve information for server, try again \n" + error);
            }
        }

        public void getStreamOff()
        {
            if (Connector.State != ConnectionState.Open)
                Connector.Close();
        }

        private void connectionFail(Exception e)
        {
            MessageBox.Show($"Fallo de coneccion con servidor \n Response : {e} ");
        }

        public SqlDataReader execReader(string sqlSentence)
        {
            SqlDataReader reader;
            this.cmdText = sqlSentence;
            this.cmdExec = new SqlCommand(cmdText, Connector);
            reader = cmdExec.ExecuteReader();

            return reader;
        }

        public SqlCommand execCommand(string sqlSentence)
        {
            this.cmdText = sqlSentence;
            SqlCommand cmdexec = new SqlCommand(cmdText, Connector);

            return cmdexec;
        }
    }


    partial class EventDataProcessor
    {
        private SqlCommand cmdExec;
        private SqlDataReader Reader;
        private string cmdText;
        private string ResultSet, session,  sessionId;

        //Retrieve commands in SQL sintax for data operations
        //
        //
        private string getCommandLogin(string us, string ppwd)
        {
            string tsql = $"select NameUser from PassAPP inner join SMM_Users on PassAPP.UserId = SMM_Users.UserId and PassAPP.pwd = '{ppwd}' and SMM_Users.UserId = '{us}' ";

            return tsql;
        }

        private string fillType()
        {
            string tsql = "select matricula from tbspALM";

            return tsql;
        }

        private string VisitView()
        {
            string tsql = "select VisitType from VisitTable";

            return tsql;
        }

        private string SectionView()
        {
            string tsql = "select * from SectionTable";

            return tsql;
        }

        private string MedicalView()
        {
            string tsql = "select Barcode6, ComercialName, Formula,Presentation,expirDate,WeightQty, WeightUnit,ContentQty,DosisQty" +
                    " from MedicalTable where IsEnable = 1";

            return tsql;
        }

        public string getMedicalView()
        {
            return "select Barcode6 as 'Codigo', ComercialName as 'Nombre', Formula,Presentation as 'Presentacion',expirDate as 'Caducidad'," +
                " WeightQty as 'Peso', WeightUnit as 'Unidad', ContentQty as 'Contenido',DosisQty as 'Dosis' " +
                    " from MedicalTable where IsEnable = 1";
        }
        
        //Execute commands to CRUD operations
        //
        //
        public string getLogin(string us, string ppwd)
        {
            string nameUser = "";
            this.getStreamOn();

            if (Connector.State == ConnectionState.Open)
            {
                try
                {
                    this.cmdText = getCommandLogin(us, ppwd);

                    cmdExec = new SqlCommand(cmdText, Connector);
                    Reader = cmdExec.ExecuteReader();

                    if (Reader.Read())
                        nameUser = Reader.GetValue(0).ToString();

                    Reader.Close();

                    if (nameUser != String.Empty)
                    {
                        ResultSet = nameUser;
                        this.session = nameUser;
                    
                    }
                    else
                    {
                        ResultSet = "Error, validar usuario y/o contraseña ";
                    }

                    getStreamOff();


                }
                catch (Exception e)
                {

                    ResultSet = e.ToString();
                }

            }
            else
            {
                ResultSet = "Error al comunicarse con servidor";
            }

            return ResultSet;
        }


        public string getSession { 
            get { return this.session; } 
         }

          

         public List<string> getFillType()
        {
           List<string> Matriculas = new List<string>();

            this.getStreamOn();

            this.cmdText = this.fillType();
            cmdExec = new SqlCommand(cmdText, Connector);
            Reader = cmdExec.ExecuteReader();


            while (Reader.Read())
            {
                Matriculas.Add(Reader[0].ToString());
                // Matriculas.Add(String.Format("{0}",Reader[0]));
                // Matriculas.Add(Reader.GetString(0));
                 // Matriculas.Add(Reader.GetValue(0).ToString());
            }


            Reader.Close();
            this.getStreamOff();

            return Matriculas;

        }


        public IList<string> getFillVisit()
        {
             IList<string> getVisitType = new List<string>();

            try
            {
                this.getStreamOn();
                Reader = this.execReader(this.VisitView());
                while (Reader.Read())
                {
                    getVisitType.Add(Reader.GetString(0));
                }

            }
            catch(Exception e)
            {
                this.connectionFail(e);
            }
            finally
            {
                this.getStreamOff();
            }

            return getVisitType;
        }
        
        public SortedDictionary<int,string> getFillSection()
        {
            SortedDictionary<int, string> getSection = new SortedDictionary<int, string>();

            try
            {
                this.getStreamOn();
                Reader = this.execReader(this.SectionView());

                while (Reader.Read())
                {
                    getSection.Add(Reader.GetInt32(0),Reader.GetString(1));
                }


            }
            catch (Exception e)
            {

                this.connectionFail(e);
            }
            finally
            {
                this.getStreamOff();
            }

            return getSection;

        }

        public List<MedicalForm> getFillMedical()
        {
            List<MedicalForm> getMedicine = new List<MedicalForm>();

            try
            {
                getStreamOn();
                Reader = execReader(MedicalView());

                while(Reader.Read())
                {
                                                       
                    getMedicine.Add( new MedicalForm { BarCode = Reader.GetInt32(0)  , Name = Reader.GetString(1), Formula = Reader.GetString(2),
                                                       Presentation = Reader.GetString(3), ExpDate = Reader.GetDateTime(4).ToString() , WeightQty = Reader.GetInt32(5) ,
                                                        WeightUnit = Reader.GetString(6) ,ContentQty = Reader.GetInt32(7), DosisQty = Reader.GetDecimal(8)
                    }  );
                }    

            }
            catch (Exception e)
            {

                connectionFail(e);
            }
            finally
            {
                getStreamOff();
            }

            return getMedicine;
        }
    }

}

    

