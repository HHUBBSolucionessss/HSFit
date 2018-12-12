using System.Windows.Forms;

namespace System
{
    public class Config
    {
        public static string shrug = "¯\\_(ツ)_/¯";
        public static decimal iva = 0M;
        public static int cantMedioMayoreo = 0;
        public static int cantMayoreo = 0;
        public static int cantImprimirTickets;

        #region Base de datos
        public static string baseDatos = "", servidor = "", usuario = "", pass = "";
        public static int idMySQL = -1;
        #endregion

        #region Correo
        public static string correoOrigenInterno = "", contraseñaOrigenInterno = "", puertoInterno = "", hostInterno = "", 
            correoOrigenExterno = "", contraseñaOrigenExterno = "", puertoExterno = "", hostExterno = "";
        #endregion

        #region Sonidos
        public static string rutaSonidoObturador = Application.StartupPath + "\\Sonidos\\obturador.wav";
        #endregion

        #region Sucursal
        public static int idSucursal = 0;
        public static string nombreSucursal = "";
        #endregion
    }
}
