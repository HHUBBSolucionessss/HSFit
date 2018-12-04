using System;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;

namespace GYM.Clases
{
    class Usuario
    {
        
        #region Eventos
        /// <summary>
        /// Evento que se produce cuando se ha cambiado los datos del usuario actual.
        /// </summary>
        public event EventHandler UserDataChanged;

        /// <summary>
        /// Método que se llama cuando los datos del usuario actual han cambiado, actualizandolos y lanzando el evento.
        /// </summary>
        /// <param name="e">Parametro de evento vacío</param>
        protected virtual void OnChanged(EventArgs e)
        {
            if (UserDataChanged != null)
            {
                nomUsuActual = Nombre;
                apeUsuActual = Apellidos;
                imgUsuActual = Imagen;
                UserDataChanged(this, e);
            }
        }
        #endregion

        #region Propiedades
        private int id;
        private string userName;
        private string contraseña;
        private string nombre;
        private string apellidos;
        private string correo;
        private bool eliminado;
        private string numAut;
        private Image imagen;
        private byte[] huella;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;

        private static int idUsuActual;
        private static string nomUsuActual;
        private static string apeUsuActual;
        private static Image imgUsuActual;
        private static int cantUsu = -1;

        /// <summary>
        /// Obtiene o establece el ID del usuario
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        //public int IDSucursal
        //{
        //    get { return idSucursal; }
        //    set { idSucursal = value; }
        //}

        /// <summary>
        /// Obtiene o establece el nombre de usuario único
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        /// <summary>
        /// Obtiene o establece la contraseña del usuario
        /// </summary>
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del usuario
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece los apellidos de el usuario
        /// </summary>
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        /// <summary>
        /// Obtiene o establece el correo del usuario
        /// </summary>
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        
        /// <summary>
        /// Obtiene o establece un valor booleano que indica si el usuario se encuentra en estado eliminado
        /// </summary>
        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        /// <summary>
        /// Obtiene o establece el número de autorización del usuario
        /// </summary>
        public string NumeroAutorizacion
        {
            get { return numAut; }
            set { numAut = value; }
        }

        /// <summary>
        /// Obtiene o establece la imagen del usuario
        /// </summary>
        public Image Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        /// <summary>
        /// Obtiene o establece el valor en binario de la huella digital del usuario
        /// </summary>
        public byte[] Huella
        {
            get { return huella; }
            set { huella = value; }
        }

        /// <summary>
        /// Obtiene el usuario creador del usuario
        /// </summary>
        public int CreateUser
        {
            get { return createUser; }
        }

        /// <summary>
        /// Obtiene la fecha de creación del usuario
        /// </summary>
        public DateTime CreateTime
        {
            get { return createTime; }
        }

        /// <summary>
        /// Obtiene el usuario que actualizó por última vez a el usuario
        /// </summary>
        public int UpdateUser
        {
            get { return updateUser; }
        }

        /// <summary>
        /// Obtiene la fecha de actualización por última vez a el usuario
        /// </summary>
        public DateTime UpdateTime
        {
            get { return updateTime; }
        }
        
        /// <summary>
        /// Obtiene el ID del usuario que actualmente tiene la sesión iniciada
        /// </summary>
        public static int IDUsuarioActual
        {
            get { return idUsuActual; }
        }
        
        /// <summary>
        /// Obtiene el nombre del usuario que actualmente tiene la sesión iniciada
        /// </summary>
        public static string NombreUsuarioActual
        {
            get { return nomUsuActual; }
        }

        /// <summary>
        /// Obtiene los apellidos del usuario que actualmente tiene la sesión iniciada
        /// </summary>
        public static string ApellidosUsuarioActual
        {
            get { return apeUsuActual; }
        }

        /// <summary>
        /// Obtiene la imagen del usuario que actualmente tiene la sesión iniciada
        /// </summary>
        public static Image ImagenUsuarioActual
        {
            get { return imgUsuActual; }
        }

        /// <summary>
        /// Obtiene la cantidad de usuarios en total que hay en la base de datos
        /// </summary>
        public static int CantidadUsuarios
        {
            get
            {
                if (cantUsu < 0)
                    cantUsu = CantUsus();
                return cantUsu;
            }
        }
        
        #endregion

        #region Cantidades
        /// <summary>
        /// Método que actualiza los valores de las cantidades de los usuarios.
        /// </summary>
        private void CambioCantidadUsuarios()
        {
            cantUsu = CantUsus();
        }

        /// <summary>
        /// Función que obtiene la cantidad de usuarios que hay en la base de datos.
        /// </summary>
        /// <returns>Cantidad de usuarios</returns>
        private static int CantUsus()
        {
            int cant = 0;
            try
            {
                //MySqlCommand sql = new MySqlCommand();
                //sql.CommandText = "SELECT COUNT(id) AS c FROM usuario WHERE eliminado=0 AND (sucursal_id='" + Config.idSucursal + "' OR sucursal_id='-1')";
                //DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                //foreach (DataRow dr in dt.Rows)
                //{
                //    if (dr["c"] != DBNull.Value)
                //        cant = int.Parse(dr["c"].ToString());
                //}
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cant;
        }
        
        #endregion

        /// <summary>
        /// Inicializa la instancia de la clase Usuario
        /// </summary>
        public Usuario()
        {

        }

        /// <summary>
        /// Inicializa la instancia de la clase Usuario con el ID especificado
        /// </summary>
        /// <param name="id"></param>
        public Usuario(int id)
        {
            this.ID = id;
        }

        /// <summary>
        /// Función que verifica los datos del usuario para su ingreso, y en caso de ser correctos, guarda la información del usuario.
        /// </summary>
        /// <param name="nomUsu">Nombre del usuario</param>
        /// <param name="pass">Contraseña del usuario</param>
        /// <returns>Valor booleano que indica si los datos son correctos</returns>
        async public static Task<bool> VerificarIngresoUsuario(string nomUsu, string pass)
        {
            bool existe = false;
            try
            {
                //MySqlCommand sql = new MySqlCommand();
                //sql.CommandText = "SELECT id, nivel, nombre, apellidos, imagen FROM usuario WHERE username=?userName AND pass=?pass AND eliminado=0 AND (sucursal_id='" + Config.idSucursal + "' OR sucursal_id='-1')";
                //sql.Parameters.AddWithValue("?userName", nomUsu);
                //sql.Parameters.AddWithValue("?pass", Criptografia.Cifrar(pass));
                //DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                //foreach (DataRow dr in dt.Rows)
                //{
                //    idUsuActual = (int)dr["id"];
                //    nomUsuActual = dr["nombre"].ToString();
                //    apeUsuActual = dr["apellidos"].ToString();
                //    if (dr["imagen"] != DBNull.Value)
                //        imgUsuActual = FuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
                //    else
                //        imgUsuActual = null;
                //    existe = true;
                //    await Privilegios.PrivilegiosUsuario(idUsuActual);
                //}
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return existe;
        }
        
        /// <summary>
        /// Método que obtiene los datos del usuario y los guarda en las propiedades
        /// </summary>
        public void ObtenerDatosUsuario()
        {
            try
            {
                //MySqlCommand sql = new MySqlCommand();
                //sql.CommandText = "SELECT * FROM usuario WHERE id=?id";
                //sql.Parameters.AddWithValue("?id", ID);
                //DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                //foreach (DataRow dr in dt.Rows)
                //{
                //    idSucursal = (int)dr["sucursal_id"];
                //    userName = dr["username"].ToString();
                //    contraseña = Criptografia.Descifrar(dr["pass"].ToString());
                //    nombre = dr["nombre"].ToString();
                //    apellidos = dr["apellidos"].ToString();
                //    correo = dr["email"].ToString();
                //    eliminado = bool.Parse(dr["eliminado"].ToString());
                //    numAut = dr["num_aut"].ToString();
                //    if (dr["imagen"] != DBNull.Value)
                //        imagen = FuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
                //    else
                //        imagen = null;
                //    if (dr["huella"] != DBNull.Value)
                //        huella = (byte[])dr["huella"];
                //    else
                //        huella = null;
                //    createUser = (int)dr["create_user"];
                //    createTime = (DateTime)dr["create_time"];
                //    if (dr["update_user"] != DBNull.Value)
                //        updateUser = (int)dr["update_user"];
                //    else
                //        updateUser = 0;
                //    if (dr["update_time"] != DBNull.Value)
                //        updateTime = (DateTime)dr["update_time"];
                //    else
                //        updateTime = new DateTime();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que inserta un nuevo usuario con los datos de las propiedades.
        /// </summary>
        public void InsertarUsuario()
        {
            try
            {
                //MySqlCommand sql = new MySqlCommand();
                //sql.CommandText = "INSERT INTO usuario (sucursal_id, username, pass, nombre, apellidos, email, imagen, huella, create_user, create_time) " +
                //    "VALUES (?sucursal_id, ?username, ?pass, ?nombre, ?apellidos, ?email, ?imagen, ?huella, ?create_user, NOW())";
                //sql.Parameters.AddWithValue("?sucursal_id", idSucursal);
                //sql.Parameters.AddWithValue("?username", UserName);
                //sql.Parameters.AddWithValue("?pass", Criptografia.Cifrar(Contraseña));
                //sql.Parameters.AddWithValue("?nombre", Nombre);
                //sql.Parameters.AddWithValue("?apellidos", Apellidos);
                //sql.Parameters.AddWithValue("?email", Correo);
                //if (Imagen != null)
                //    sql.Parameters.AddWithValue("?imagen", FuncionesGenerales.ImagenBytes(Imagen));
                //else
                //    sql.Parameters.AddWithValue("?imagen", DBNull.Value);
                //if (Huella != null)
                //    sql.Parameters.AddWithValue("?huella", huella);
                //else
                //    sql.Parameters.AddWithValue("?huella", DBNull.Value);
                //if (CantidadUsuarios > 0)
                //    sql.Parameters.AddWithValue("?create_user", idUsuActual);
                //else
                //    sql.Parameters.AddWithValue("?create_user", 1);
                //this.id = ConexionBD.EjecutarConsulta(sql);
                //CambioCantidadUsuarios();
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
        /// Método que edita la información de un usuario con la información de las propiedades
        /// </summary>
        public void EditarUsuario()
        {
            try
            {
                //MySqlCommand sql = new MySqlCommand();
                //sql.CommandText = "UPDATE usuario SET sucursal_id=?sucursal_id, pass=?pass, nombre=?nombre, apellidos=?apellidos, email=?email, imagen=?imagen, " + 
                //    "huella=?huella, update_user=?update_user, update_time=NOW() WHERE id=?id";
                //sql.Parameters.AddWithValue("?pass", Criptografia.Cifrar(Contraseña));
                //sql.Parameters.AddWithValue("?nombre", Nombre);
                //sql.Parameters.AddWithValue("?apellidos", Apellidos);
                //sql.Parameters.AddWithValue("?email", Correo);
                //if (Imagen != null)
                //    sql.Parameters.AddWithValue("?imagen", FuncionesGenerales.ImagenBytes(Imagen));
                //else
                //    sql.Parameters.AddWithValue("?imagen", DBNull.Value);
                //if (Huella != null)
                //    sql.Parameters.AddWithValue("?huella", Huella);
                //else
                //    sql.Parameters.AddWithValue("?huella", DBNull.Value);
                //sql.Parameters.AddWithValue("?update_user", IDUsuarioActual);
                //sql.Parameters.AddWithValue("?id", ID);
                //ConexionBD.EjecutarConsulta(sql);
                //if (ID == IDUsuarioActual)
                //{
                //    OnChanged(EventArgs.Empty);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que cambia el estado de un usuario a eliminado
        /// </summary>
        /// <param name="id">ID del usuario a eliminar</param>
        /// <param name="estado">true para eliminar, false para restablecer</param>
        public static void CambiarEstadoEliminadoUsuario(int id, bool estado)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE usuario SET eliminado=?eliminado WHERE id=?id";
                sql.Parameters.AddWithValue("?eliminado", estado);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
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
        /// Método que verifica que el nombre de usuario esté disponible.
        /// </summary>
        /// <param name="nomUsu">Nombre de usuario a verificar</param>
        /// <returns>Valor booleano que indica si el usuario existe</returns>
        public static bool ExisteUsuario(string nomUsu)
        {
            bool existe = false;
            try
            {
                string sql = "SELECT id FROM usuario WHERE username='" + nomUsu + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    existe = true;
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
            return existe;
        }

        /// <summary>
        /// Método que obtiene el nombre y los apellidos de un usuario
        /// </summary>
        /// <param name="id">ID del usuario del que se desea obtener el nombre</param>
        /// <returns>Nombre y apellidos del usuario</returns>
        public static string ObtenerNombreUsuario(int id)
        {
            string nom = "Sin información";
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT userName FROM usuarios WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    nom = dr["userName"].ToString();
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
            return nom;
        }

        /// <summary>
        /// Método que crea el número de autorización para el reestablecimiento de la contraseña
        /// </summary>
        /// <param name="id">ID del usuario al que se reestablecerá la contraseña</param>
        public static void CrearNumeroAutorizacion(int id, string correo)
        {
            try
            {
                //string num = NumAut();
                //MySqlCommand sql = new MySqlCommand();
                //sql.CommandText = "UPDATE usuario SET num_aut=?num_aut WHERE id=?id";
                //sql.Parameters.AddWithValue("?num_aut", num);
                //sql.Parameters.AddWithValue("?id", id);
                //ConexionBD.EjecutarConsulta(sql);

                //Correos c = new Correos(true);
                //c.CorreoOrigen = Config.correoOrigenInterno;
                //c.Contraseña = Config.contraseñaOrigenInterno;
                //c.CorreosDestino = correo;
                //c.Host = Config.hostInterno;
                //c.Puerto = int.Parse(Config.puertoInterno);
                //c.Asunto = "Reestablecimiento de contraseña Admin-CSY";
                //c.Cuerpo = "Ingresa el siguiente número de autorización en el programa para poder reestablecer la contraseña: " + num;
                //c.EnviarCorreo();
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
        /// Método que genera un número aleatorio de seis cifras para crear el número de autorización
        /// </summary>
        /// <returns>Número de autorización</returns>
        private static string NumAut()
        {
            string num = "";
            for (int i = 0; i < 6; i++)
            {
                num += new Random().Next(0, 9).ToString();
                System.Threading.Thread.Sleep(10);
            }
            return num;
        }
    }
}
