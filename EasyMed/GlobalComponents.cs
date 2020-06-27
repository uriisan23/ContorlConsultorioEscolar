using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMed
{
    public static class GlobalComponents
    {
        private static string globalSession = null;
        private static string globalSessionId = null;
        private static bool sessionState= false ;

        

     
        public static string  getSesion { get => globalSession; set => globalSession = value; }

        public static string getSessionId { get => globalSessionId; set => globalSessionId = value; }

        public static bool getSessionState { get => sessionState; set => sessionState = value; }

        ///<summary>
        ///Determina si un elemento TextBox esta vacío
        ///</summary>
        ///<returns>
        ///True si el valor es empty o null
        /// </returns>
        public static bool IsEmptyText(string Textbox) => (Textbox.Length <= 0) ? true : false;

        /// <summary>
        /// Inserta un mensaje de error en una operacion para agregar elementos
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string InsertError(Exception e) =>$"Error al insertar nuevo elemento \n Response : \n {e}";

    }

    
}
