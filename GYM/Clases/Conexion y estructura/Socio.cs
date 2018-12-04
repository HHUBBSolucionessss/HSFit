﻿using System;
using System.Threading;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using GYM.Clases;
using GYM;

public class Socio
{
    private int numSocio;
    private string nombre;
    private string apellidos;
    private string direccion;
    private int codigoPostal;
    private string ciudad;
    private  string estado;
    private string telefono;
    private string celular;
	private string email;
    private int genero;
    private DateTime fechaNacimiento;
    private Socio persona;
    private byte[] huella = null;
    private Image imgMiembro;
    private int createUser;
    private DateTime createTime;
    private int updateUser;
    private DateTime updateTime;

    Thread hiloCumpleaños;
    DataTable dt;
    DateTime fecha;
    public bool hayCumpleañeros = false;
    public frmMain frmM;

    #region Propiedades
    public int NumeroSocio
    {
        get { return this.numSocio; }
        set { this.numSocio = value; }
    }

    public string Nombre
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }

    public string Apellidos
    {
        get { return this.apellidos; }
        set { this.apellidos = value; }
    }

    public string Direccion
    {
        get { return this.direccion; }
        set { this.direccion = value; }
    }

    public int CodigoPostal
    {
        get { return codigoPostal; }
        set { codigoPostal = value; }
    }
    
    public string Ciudad
    {
        get { return this.ciudad; }
        set { this.ciudad = value; }
    }

    public string Estado
    {
        get { return this.estado; }
        set { this.estado = value; }
    }

    public string Telefono
    {
        get { return this.telefono; }
        set { this.telefono = value; }
    }

    public string Celular
    {
        get { return this.celular; }
        set { this.celular = value; }
    }

    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public int Genero
    {
        get { return this.genero; }
        set { this.genero = value; }
    }

    public DateTime FechaNacimiento
    {
        get { return this.fechaNacimiento; }
        set { this.fechaNacimiento = value; }
    }

    public Socio Persona
    {
        get { return this.persona; }
        set { this.persona = value; }
    }

    public byte[] Huella
    {
        get { return huella; }
        set { huella = value; }
    }

    public Image ImagenMiembro
    {
        get { return imgMiembro; }
        set { imgMiembro = value; }
    }

    public int CreateUser
    {
        get { return createUser; }
        set { createUser = value; }
    }

    public DateTime CreateTime
    {
        get { return createTime; }
    }

    public int UpdateUser
    {
        get { return updateUser; }
        set { updateUser = value; }
    }

    public DateTime UpdateTime
    {
        get { return updateTime; }
    }
    #endregion

    /// <summary>
    /// Método que verifica la existencia de un socio por su id
    /// </summary>
    /// <param name="numSocio">Número del socio que se desea verificar.</param>
    /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
    /// <returns>Valor booleano que indica si existe o no el socio.</returns>
    public bool VerificarExistenciaMiembro(int numSocio)
    {
        try
        {
            MySqlCommand sql = new MySqlCommand();
            sql.CommandText = "SELECT nombre FROM miembros WHERE numSocio=? LIMIT 1";
            sql.Parameters.AddWithValue("@numSocio", numSocio);
            DataTable list = ConexionBD.EjecutarConsultaSelect(sql);
            if (list.Rows.Count > 0)
                return true;
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return false;
    }

    /// <summary>
    /// Función que obtiene toda la información guardada en la base de datos del socio por su número de socio
    /// </summary>
    /// <param name="numSocio"></param>
    /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
    /// <exception cref="System.FormatException">Excepción que se produce cuando el formato de un argumento no cumple las especificaciones de los parámetros del método invocado.</exception>
    /// <exception cref="Systen.OverflowException">Excepción que se produce cuando una operación aritmética, de conversión de tipo o de conversión de otra naturaleza en un contexto comprobado, da como resultado una sobrecarga.</exception>
    /// <exception cref="System.IO.IOException">Excepción que es lanzada cuando se produce un error de E/S.</exception>
    /// <exception cref="System.ObjectDisposedException">Excepción que se produce cuando se realiza una operación en un objeto desechado.</exception>
    /// <exception cref="System.NotSupportedException">Excepción que se produce cuando no se admite un método invocado o cuando se intenta leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.</exception>
    /// <exception cref="System.ArgumentOutOfRangeException">Excepción que se produce cuando el valor de un argumento se encuentra fuera del intervalo de valores permitido definido por el método invocado.</exception>
    /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
    /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de un programa.</exception>
    /// <returns>Objeto de la clase CMiembro con la información del usuario.</returns>
    public void ObtenerUsuarioPorID(int numSocio)
    {
        try
        {
            MySqlCommand sql = new MySqlCommand();

            //strftime('%d/%m/%Y',miembros.fecha_nac) AS 
            //strftime('%d/%m/%Y',miembros.fecha_creacion) AS 
            //
            sql.CommandText = "SELECT * FROM miembros WHERE numSocio=?";
            sql.Parameters.AddWithValue("@numSocio", numSocio);
            DataTable list = ConexionBD.EjecutarConsultaSelect(sql);
            foreach (DataRow dr in list.Rows)
            {
                NumeroSocio = numSocio;
                if (dr["nombre"].ToString().Equals("") || dr["nombre"].Equals(DBNull.Value))
                    nombre = "";
                else
                    nombre = dr["nombre"].ToString();

                if (dr["apellidos"].ToString().Equals("") || dr["apellidos"].Equals(DBNull.Value))
                    Apellidos = "";
                else
                    Apellidos = dr["apellidos"].ToString();

                if (dr["direccion"].ToString().Equals("") || dr["direccion"].Equals(DBNull.Value))
                    direccion = "";
                else
                    direccion = dr["direccion"].ToString();

                if (dr["ciudad"].ToString().Equals("") || dr["ciudad"].Equals(DBNull.Value))
                    ciudad = "";
                else
                    ciudad = dr["ciudad"].ToString();

                if (dr["estado"].ToString().Equals("") || dr["estado"].Equals(DBNull.Value))
                    estado = "";
                else
                    estado = dr["estado"].ToString();

                if (dr["telefono"].ToString().Equals("") || dr["telefono"].Equals(DBNull.Value))
                    telefono = "";
                else
                    telefono = dr["telefono"].ToString();

                if (dr["celular"].ToString().Equals("") || dr["celular"].Equals(DBNull.Value))
                    celular = "";
                else
                    celular = dr["celular"].ToString();

                if (dr["email"].ToString().Equals("") || dr["email"].Equals(DBNull.Value))
                    email = "";
                else
                    email = dr["email"].ToString();


                genero = int.Parse(dr["genero"].ToString());
                if (genero == 2 || genero == 3)
                    genero = 1;

                if (dr["fecha_nac"].ToString().Equals("") || dr["fecha_nac"] == DBNull.Value)
                    fechaNacimiento = DateTime.Now;
                else
                    fechaNacimiento = DateTime.Parse(dr["fecha_nac"].ToString());

                if (dr["huella"] != DBNull.Value)
                    huella = (byte[])dr["huella"];
                if (dr["imagen"] != DBNull.Value)
                    ImagenMiembro = CFuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
                else
                    ImagenMiembro = null;

                if (dr["create_time"] != DBNull.Value)
                    createTime = DateTime.Parse(dr["create_time"].ToString());
                else
                    createTime = new DateTime();
                if (dr["create_user_id"] != DBNull.Value)
                    createUser = int.Parse(dr["create_user_id"].ToString());
                else
                    createUser = 0;

                if (dr["update_time"] != DBNull.Value)
                    updateTime = DateTime.Parse(dr["update_time"].ToString());
                else
                    updateTime = new DateTime();
                if (dr["update_user_id"] != DBNull.Value)
                    updateUser = int.Parse(dr["update_user_id"].ToString());
                else
                    updateUser = 0;
            }

        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        catch (FormatException ex)
        {
            throw ex;
        }
        catch (OverflowException ex)
        {
            throw ex;
        }
        catch (System.IO.IOException ex)
        {
            throw ex;
        }
        catch (ObjectDisposedException ex)
        {
            throw ex;
        }
        catch (NotSupportedException ex)
        {
            throw ex;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            throw ex;
        }
        catch (ArgumentNullException ex)
        {
            throw ex;
        }
        catch (ArgumentException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Función que convierte un valor binario a hexadecimal.
    /// </summary>
    /// <param name="hue">Variable de tipo binario que se convertirá a hexadecimal.</param>
    /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
    /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
    /// <returns>Cadena con los datos hexadecimales.</returns>
    public static string ByteToHex(byte[] hue)
    {
        try
        {
            string hex = BitConverter.ToString(hue).Replace("-", string.Empty);
            return hex;
        }
        catch (ArgumentNullException ex)
        {
            throw ex;
        }
        catch (ArgumentException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Función que convierte un valor hexadecimal a binario
    /// </summary>
    /// <param name="hex">Cadena con la información en hexadecimal</param>
    /// <exception cref="System.Exception">Se lanza cuando el valor hexadecimal tiene una longitud impar.</exception>
    /// <returns>Valor binario de la cadena hexadecimal.</returns>
    public static byte[] HexToByte(string hex)
    {
        if (hex.Length % 2 == 1)
        {
            throw new Exception("La clave primaria no puede ser un número impar.");
        }

        byte[] arr = new byte[hex.Length >> 1];

        for (int i = 0; i < hex.Length >> 1; ++i)
        {
            arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
        }

        return arr;
    }

    /// <summary>
    /// Función que genera un valor entero a partir de un valor hexadecimal.
    /// </summary>
    /// <param name="hex">Caracter hexadecimal.</param>
    /// <returns>Valor convertido a entero del caracter hexadecimal.</returns>
    private static int GetHexVal(char hex)
    {
        int val = (int)hex;
        //For uppercase A-F letters:
        return val - (val < 58 ? 48 : 55);
        //For lowercase a-f letters:
        //return val - (val < 58 ? 48 : 87);
        //Or the two combined, but a bit slower:
        //return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
    }

    /// <summary>
    /// Función que regresa la fecha final de la membresía de un socio.
    /// </summary>
    /// <param name="numSocio">Número de socio del que se desea obtener su fecha final de membresía.</param>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
    /// <exception cref="System.IndexOutOfRangeException">Excepción que se produce cuando se intenta tener acceso a un elemento de una matriz con un índice que está fuera de los límites de la matriz.</exception>
    /// <exception cref="System.FormatException">Excepción que se produce cuando el formato de un argumento no cumple las especificaciones de los parámetros del método invocado.</exception>
    /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
    /// <returns>La fecha final de la membresía</returns>
    public DateTime FechaFinalMembresia(int numSocio)
    {
        DateTime fecha = new DateTime();
        try
        {
            MySqlCommand sql = new MySqlCommand();
            sql.CommandText = "SELECT fecha_fin FROM membresias WHERE numSocio=?numSocio";
            sql.Parameters.AddWithValue("?numSocio", numSocio);
            DataTable list = ConexionBD.EjecutarConsultaSelect(sql);
            foreach (DataRow dr in list.Rows)
            {
                if (dr["fecha_fin"] != DBNull.Value)
                    fecha = DateTime.Parse(dr["fecha_fin"].ToString());   
            }
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        catch (IndexOutOfRangeException ex)
        {
            throw ex;
        }
        catch (FormatException ex)
        {
            throw ex;
        }
        catch (ArgumentNullException ex)
        {
            throw ex;
        }
        return fecha;
    }

    /// <summary>
    /// Función que inserta un nuevo miembro en la base de datos.
    /// </summary>
    /// <param name="miembro">Objeto de la clase CMiembro con toda la información del miembro a insertar.</param>
    /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
    /// <exception cref="System.Runtime.InteropServices.ExternalException">El tipo de excepción base para todas las excepciones de interoperabilidad COM y excepciones de control de excepciones estructurado (SEH).</exception>
    /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
    /// <returns>Valor booleano que indica si se inserto el miembro correctamente.</returns>
    public bool InsertarMiembro(Socio miembro)
    {
        bool inserto = false;
        try
        {
            MySqlCommand sql = new MySqlCommand();
            sql.CommandText = "INSERT INTO miembros (numSocio, nombre, apellidos, direccion, ciudad, estado, telefono, celular, email, genero, fecha_nac, create_time, create_user_id, huella, imagen)" +
                "VALUES (?numSocio, ?nombre, ?apellidos, ?direccion, ?ciudad, ?estado, ?telefono, ?celular, ?email, ?genero, ?fecha_nac, NOW(), ?create_user_id, ?huella, ?imagen)";
            sql.Parameters.AddWithValue("?numSocio", miembro.numSocio);
            sql.Parameters.AddWithValue("?nombre", miembro.nombre);
            sql.Parameters.AddWithValue("?apellidos", miembro.apellidos);
            sql.Parameters.AddWithValue("?direccion", miembro.direccion);
            sql.Parameters.AddWithValue("?ciudad", miembro.ciudad);
            sql.Parameters.AddWithValue("?estado", miembro.estado);
            sql.Parameters.AddWithValue("?telefono", miembro.telefono);
            sql.Parameters.AddWithValue("?celular", miembro.celular);
            sql.Parameters.AddWithValue("?email", miembro.email);
            sql.Parameters.AddWithValue("?genero", miembro.genero);
            sql.Parameters.AddWithValue("?fecha_nac", miembro.fechaNacimiento.ToString("yyyy-MM-dd") + " 00:00:00");
            sql.Parameters.AddWithValue("?create_user_id", miembro.CreateUser);
            if (huella != null)
                sql.Parameters.AddWithValue("?huella", huella);
            else
                sql.Parameters.AddWithValue("?huella", DBNull.Value);
            if (imgMiembro != null)
                sql.Parameters.AddWithValue("@imagen", CFuncionesGenerales.ImagenBytes(imgMiembro));
            else
                sql.Parameters.AddWithValue("@imagen", DBNull.Value);
            ConexionBD.EjecutarConsulta(sql);
            inserto = true;
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        catch (System.Runtime.InteropServices.ExternalException ex)
        {
            throw ex;
        }
        catch (ArgumentNullException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return inserto;
    }

    /// <summary>
    /// Función que edita un miembro con la información guardada en las propiedades de la clase.
    /// </summary>
    /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
    /// <exception cref="System.Runtime.InteropServices.ExternalException">El tipo de excepción base para todas las excepciones de interoperabilidad COM y excepciones de control de excepciones estructurado (SEH).</exception>
    /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
    public void EditarMiembro()
    {
        try
        {
            MySqlCommand sql = new MySqlCommand();
            sql.CommandText = "UPDATE miembros SET nombre=?, apellidos=?, direccion=?, ciudad=?, estado=?, telefono=?, celular=?, " + 
                "email=?, fecha_nac=?, genero=?, update_time=NOW(), update_user_id=?, huella=?, imagen=? WHERE numSocio=?";
            sql.Parameters.AddWithValue("@nombre", nombre);
            sql.Parameters.AddWithValue("@apellidos", apellidos);
            sql.Parameters.AddWithValue("@direccion", direccion);
            sql.Parameters.AddWithValue("@ciudad", ciudad);
            sql.Parameters.AddWithValue("@estado", estado);
            sql.Parameters.AddWithValue("@telefono", telefono);
            sql.Parameters.AddWithValue("@celular", celular);
            sql.Parameters.AddWithValue("@email", email);
            sql.Parameters.AddWithValue("@fecha_nac", fechaNacimiento.ToString("yyyy-MM-dd") + " 00:00:00");
            sql.Parameters.AddWithValue("@genero", genero);
            sql.Parameters.AddWithValue("@update_user_id", updateUser);
            if (huella != null)
                sql.Parameters.AddWithValue("@huella", huella);
            else
                sql.Parameters.AddWithValue("@huella", DBNull.Value);
            if (imgMiembro != null)
                sql.Parameters.AddWithValue("@imagen", CFuncionesGenerales.ImagenBytes(imgMiembro));
            else
                sql.Parameters.AddWithValue("@imagen", DBNull.Value);
            sql.Parameters.AddWithValue("@numSocio", numSocio);
            ConexionBD.EjecutarConsulta(sql);
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        catch (System.Runtime.InteropServices.ExternalException ex)
        {
            throw ex;
        }
        catch (ArgumentNullException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Función que obtiene las huellas digitales de los miembros guardadas en la base de datos de los ultimos 6 meses.
    /// </summary>
    /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
    public static void ObtenerHuellas()
    {
        try
        {
            HuellaDigital.Fmds.Clear();
            MySqlCommand sql = new MySqlCommand();
            sql.CommandText = "SELECT m.numSocio AS numSocio,m.huella AS huella FROM miembros AS m INNER JOIN membresias AS mem ON (m.numSocio=mem.numsocio) WHERE mem.fecha_fin >= date_sub(curdate(), interval 6 month)";
            DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["huella"] != DBNull.Value)
                {
                    byte[] h = (byte[])dr["huella"];
                    DPUruNet.Fmd fm = DPUruNet.Importer.ImportFmd(h, DPUruNet.Constants.Formats.Fmd.ANSI, DPUruNet.Constants.Formats.Fmd.ANSI).Data;
                    HuellaDigital.Fmds.Add(int.Parse(dr["numSocio"].ToString()), fm);
                }
            }
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Función que registra el ingreso de un socio al gimnasio.
    /// </summary>
    /// <param name="numSocio">Número del socio que ingreso.</param>
    /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
    /// <returns>Valor booleano que indica si la operación se completo correctamente.</returns>
    public bool AgregarIngreso(int numSocio)
    {
        bool ingreso = false;
        try
        {
            MySqlCommand sql = new MySqlCommand();
            sql.CommandText = "INSERT INTO ingreso_miembros(numSocio,fecha_entrada) VALUES (?,?)";
            sql.Parameters.AddWithValue("@persona_id", numSocio);
            sql.Parameters.AddWithValue("@fecha_entrada", DateTime.Now.ToShortDateString());
            sql.CommandType = CommandType.Text;
            ConexionBD.EjecutarConsulta(sql);
            ingreso = true;
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return ingreso;
    }

    /// <summary>
    /// Función que obtiene la imagen del socio guardada en la base de datos.
    /// </summary>
    /// <param name="numSocio">Número de socio del que se desea obtener la imagen</param>
    /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
    /// <exception cref="System.IO.IOException">Excepción que es lanzada cuando se produce un error de E/S.</exception>
    /// <exception cref="System.ObjectDisposedException">Excepción que se produce cuando se realiza una operación en un objeto desechado.</exception>
    /// <exception cref="System.NotSupportedException">Excepción que se produce cuando no se admite un método invocado o cuando se intenta leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.</exception>
    /// <exception cref="System.ArgumentOutOfRangeException">Excepción que se produce cuando el valor de un argumento se encuentra fuera del intervalo de valores permitido definido por el método invocado.</exception>
    /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
    /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de un programa.</exception>
    /// <returns>Imagen del socio.</returns>
    public static Image ObtenerImagenSocio(int numSocio)
    {
        Image img = null;
        try
        {
            string sql = "SELECT imagen FROM miembros WHERE numSocio='" + numSocio + "'";
            DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["imagen"] != DBNull.Value)
                    img = CFuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
            }
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        catch (System.IO.IOException ex)
        {
            throw ex;
        }
        catch (ObjectDisposedException ex)
        {
            throw ex;
        }
        catch (NotSupportedException ex)
        {
            throw ex;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            throw ex;
        }
        catch (ArgumentNullException ex)
        {
            throw ex;
        }
        catch (ArgumentException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return img;
    }

    /// <summary>
    /// Inicializa una nueva instancia de la clase CMiembro
    /// </summary>
    public Socio()
    {

    }

    /// <summary>
    /// Inicializa una nueva instancia de la clase CMiembro con un parametro usado en el método de cumpleaños
    /// </summary>
    /// <param name="dt">Fecha actual.</param>
    public Socio(DateTime dt)
    {
        this.fecha = dt;
    }

    /// <summary>
    /// Función que obtiene los miembros que cumplen años en la fecha asignada y los muestra en una ventana.
    /// </summary>
    /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
    /// <exception cref="System.InvalidOperationException">Excepción que se produce cuando una llamada a un método no es válida para el estado actual del objeto.</exception>
    /// <exception cref="System.Threading.ThreadStateException">Excepción que se produce cuando un Thread es un ThreadState que no es válido para la llamada de método.</exception>
    /// <exception cref="System.OutOfMemoryException">Excepción que se produce cuando no hay suficiente memoria para continuar con la ejecución de un programa.</exception>
    /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
    public void Cumpleaños(frmMain frm)
    {
        try
        {
            this.frmM = frm;
            hiloCumpleaños = new Thread(ObtenerCumpleañeros);
            hiloCumpleaños.Start();
        }
        catch (MySqlException ex)
        {
            throw ex;
        }
        catch (InvalidOperationException ex)
        {
            throw ex;
        }
        catch (System.Threading.ThreadStateException ex)
        {
            throw ex;
        }
        catch (OutOfMemoryException ex)
        {
            throw ex;
        }
        catch (ArgumentNullException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Función que obtiene los miembros que cumplen años en la fecha asignada.
    /// </summary>
    /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
    /// <exception cref="System.InvalidOperationException">Excepción que se produce cuando una llamada a un método no es válida para el estado actual del objeto.</exception>
    /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
    private void ObtenerCumpleañeros()
    {
        MensajeError m = new MensajeError(CFuncionesGenerales.MensajeError);
        try
        {
            string sql = "SELECT numSocio, nombre, apellidos, fecha_nac, email FROM miembros WHERE DATE_FORMAT(fecha_nac, '%m')='" + fecha.Month.ToString("00") + "' AND DATE_FORMAT(fecha_nac, '%d')='" + fecha.Day.ToString("00") + "'";
            dt = ConexionBD.EjecutarConsultaSelect(sql);
            if (dt.Rows.Count > 0)
            {
                hayCumpleañeros = true;
                GYM.Formularios.frmCumple frm = new GYM.Formularios.frmCumple(dt);
                frm.AgregarCumpleañeros();
                frm.ShowDialog();
                CFuncionesGenerales.SiempreEncima(frm.Handle.ToInt32());
            }
        }
        catch (MySqlException ex)
        {
            if (frmM != null)
            {
                frmM.Invoke(m, new object[] { "No se ha podido obtener los cumpleañeros. No se ha podido conectar a la base de datos.", ex });
            }
        }
        catch (InvalidOperationException ex)
        {
            if (frmM != null)
            {
                frmM.Invoke(m, new object[] { "No se ha podido obtener los cumpleañeros. La operación no pudo ser completada por el estado actual del objeto.", ex });
            }
        }
        catch (Exception ex)
        {
            if (frmM != null)
            {
                frmM.Invoke(m, new object[] { "No se ha podido obtener los cumpleañeros. Ha ocurrido un error genérico.", ex });
            }
        }
    }
}

