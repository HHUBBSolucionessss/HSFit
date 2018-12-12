using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GYM.Clases;
using MySql.Data.MySqlClient;
using System.IO;

namespace GYM
{
    public partial class frmSplash : Form
    {
        int intentos = 0;
        int c = 0;
        DelegadoMensajes m = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        private delegate void AbrirConfiguracion();
        private delegate void AbrirFormConParametro(int count);

        public frmSplash()
        {
            InitializeComponent();
        }

        private void ActualizarLabel(string mensaje)
        {
            lblEstado.Text = mensaje;
        }

        private void ReconfigurarConexion()
        {
            DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "Admin CSY");
            if (re == DialogResult.Yes)
            {
                (new Formularios.frmConfiguracionBaseDatos(this)).ShowDialog(this);
            }
            else
            {
                bgwCargar.CancelAsync();
            }
        }

        #region Paso 01 Verificación de conexión

        /// <summary>
        /// Método recursivo que verifica si el servicio de MySQL se encuentra activo, en caso de estarlo, guarda el ID del proceso, en caso contrario,
        /// lo trata de iniciar e inicia la recursividad para verificar si se logro iniciar.
        /// </summary>
        private bool MySQL()
        {
            bool activo = false;
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.Contains("mysqld"))
                {
                    activo = true;
                    break;
                }
            }
            return activo;
        }

        /// <summary>
        /// Función que verifica que la configuración de la base de datos exista en el archivo de configuración,
        /// en caso de que no exista, lo crea.
        /// </summary>
        private void ConfiguracionBase()
        {
            try
            {
                AbrirConfiguracion a = new AbrirConfiguracion(ConfigBaseDatos);
                if (!MySQL() && !FuncionesGenerales.soloRegistro)
                {
                    ActivarServicioMySQL();
                }
                if (MySQL())
                {
                    if (!ConfiguracionXML.ExisteConfiguracion("baseDatos"))
                    {
                        if (MessageBox.Show("No está configurada la base de datos.\n¿Desea configurarla?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Invoke(a);
                        }
                        else
                        {
                            MessageBox.Show("La aplicación se cerrará. Puede configurarla la próxima vez que abra el programa.", "GymCSY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                    else
                    {
                        Config.servidor = ConfiguracionXML.LeerConfiguración("baseDatos", "servidor");
                        Config.baseDatos = ConfiguracionXML.LeerConfiguración("baseDatos", "base");
                        Config.usuario = ConfiguracionXML.LeerConfiguración("baseDatos", "usuario");
                        Config.pass = ConfiguracionXML.LeerConfiguración("baseDatos", "pass");
                    }
                    VerificarConexion();
                }
                else
                {
                    if (FuncionesGenerales.soloRegistro)
                    {
                        if (!ConfiguracionXML.ExisteConfiguracion("baseDatos"))
                        {
                            if (MessageBox.Show("No está configurada la base de datos.\n¿Desea configurarlo?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes)
                            {
                                this.Invoke(a);
                            }
                            else
                            {
                                MessageBox.Show("La aplicación se cerrará. Puede configurarla la próxima vez que abra el programa.", "GymCSY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Exit();
                            }
                        }
                        else
                        {
                            Config.servidor = ConfiguracionXML.LeerConfiguración("baseDatos", "servidor");
                            Config.baseDatos = ConfiguracionXML.LeerConfiguración("baseDatos", "base");
                            Config.usuario = ConfiguracionXML.LeerConfiguración("baseDatos", "usuario");
                            Config.pass = ConfiguracionXML.LeerConfiguración("baseDatos", "pass");
                        }
                        VerificarConexion();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido iniciar el servicio de MySQL. Intentelo desde la aplicación de administración.", "GymCSY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se ha podido conectar a la base de datos. Active el servicio de MySQL desde la aplicación de configuración.", ex);
            }
        }

        /// <summary>
        /// Método que verifica la conexión con la base de datos
        /// </summary>
        private void VerificarConexion()
        {
            try
            {
                if (!ConexionBD.Ping())
                {
                    this.Invoke(new Action(ReconfigurarConexion));
                }
            }
            catch (Exception)
            {
                this.Invoke(new Action(ReconfigurarConexion));
            }
        }


        #endregion

        private void ConfigBaseDatos()
        {
            Formularios.frmConfiguracionBaseDatos.Instancia.ShowDialog(this);
            System.Threading.Thread.Sleep(0);
        }

        private void ActivarServicioMySQL()
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo();
                Process p = new Process();
                info.Arguments = "-H";
                info.CreateNoWindow = false;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                info.FileName = "C:\\xampp\\mysql_start.bat";
                p.StartInfo = info;
                p.Start();
                System.Threading.Thread.Sleep(4500);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region Crear Configuraciones

        private void CrearConfiguracionTema()
        {
            //Colores sistema
            ConfiguracionXML.GuardarConfiguracion("tema", "imagenFondo", "Fondo");
        }

        private void CrearConfiguracionPromociones()
        {
            if (!ConfiguracionXML.ExisteConfiguracion("promociones"))
            {
                //Imagenes Promociones
                ConfiguracionXML.GuardarConfiguracion("promociones", "promo01", "null");
                ConfiguracionXML.GuardarConfiguracion("promociones", "promo02", "null");
                ConfiguracionXML.GuardarConfiguracion("promociones", "promo03", "null");
                ConfiguracionXML.GuardarConfiguracion("promociones", "promo04", "null");
                ConfiguracionXML.GuardarConfiguracion("promociones", "promo05", "null");
                ConfiguracionXML.GuardarConfiguracion("promociones", "promo06", "null");
            }
        }

        #endregion

        #region Paso 02


        private void VerificarConfiguracionesGenerales()
        {
            try
            {
                if (ConfiguracionXML.ExisteConfiguracion("ticket", "cant"))
                {
                    Config.cantImprimirTickets = int.Parse(ConfiguracionXML.LeerConfiguración("ticket", "cant"));
                }
                else
                {
                    ConfiguracionXML.GuardarConfiguracion("ticket", "cant", "1");
                    Config.cantImprimirTickets = 1;
                }
            }
            catch (MySqlException ex)
            {
                this.Invoke((new DelegadoMensajes(FuncionesGenerales.Mensaje)), new object[] { this, Mensajes.Error, "Ocurrió un error al verificar las configuraciones generales. Es probable que algunas partes del software no funcionen correctamente. No se ha podido conectar con la base de datos.", Config.shrug, ex });
                bgwCargar.CancelAsync();
            }
            catch (Exception ex)
            {
                this.Invoke((new DelegadoMensajes(FuncionesGenerales.Mensaje)), new object[] { this, Mensajes.Error, "Ocurrió un error al verificar las configuraciones generales. Es probable que algunas partes del software no funcionen correctamente.", Config.shrug, ex });
                bgwCargar.CancelAsync();
            }
        }

        private void EnviarLog()
        {
            try
            {
                string ruta = Application.StartupPath + "\\log.txt";
                if (File.Exists(ruta))
                {
                    DateTime fechaArchivo = File.GetCreationTime(ruta);
                    if (fechaArchivo.Date == DateTime.Now.Date.AddDays(-7))
                    {
                        if (ConfiguracionXML.ExisteConfiguracion("correo"))
                        {
                            Correos c = new Correos();
                            c.Adjuntos = new string[] { ruta };
                            c.Asunto = "Log de errores HS FIT.";
                            c.CorreosDestino = "errores@hubsoluciones.com";
                            c.EnviarCorreo();
                            System.Threading.Thread.Sleep(500);
                            File.Delete(ruta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }


        #endregion

        #region Funciones Cargar
        private void CargarInterfaz()
        {
            string imgFondo = ConfiguracionXML.LeerConfiguración("tema", "imagenFondo");
            if (imgFondo == "Fondo")
                FuncionesGenerales.img = (Bitmap)Properties.Resources.ResourceManager.GetObject(imgFondo);
            else if (imgFondo != "null")
                FuncionesGenerales.img = new Bitmap(imgFondo);
            else
                FuncionesGenerales.img = null;
        }

        private void CargarSonidos()
        {
            if (!ConfiguracionXML.ExisteConfiguracion("sonidos"))
            {
                ConfiguracionXML.GuardarConfiguracion("sonidos", "activar", false.ToString());
                ConfiguracionXML.GuardarConfiguracion("sonidos", "bien", "Sonido01");
                ConfiguracionXML.GuardarConfiguracion("sonidos", "mal", "Sonido01");
                FuncionesGenerales.usarSonidos = false;
                FuncionesGenerales.sonidoRegBien = "Sonido01";
                FuncionesGenerales.sonidoRegMal = "Sonido01";
            }
            else
            {
                FuncionesGenerales.usarSonidos = bool.Parse(ConfiguracionXML.LeerConfiguración("sonidos", "activar"));
                FuncionesGenerales.sonidoRegBien = ConfiguracionXML.LeerConfiguración("sonidos", "bien");
                FuncionesGenerales.sonidoRegMal = ConfiguracionXML.LeerConfiguración("sonidos", "mal");
            }
        }

        private void CargarAcceso()
        {
            if (!ConfiguracionXML.ExisteConfiguracion("puerto"))
            {
                ConfiguracionXML.GuardarConfiguracion("puerto", "activar", false.ToString());
                FuncionesGenerales.usarAcceso = false;
            }
            else
            {
                FuncionesGenerales.usarAcceso = bool.Parse(ConfiguracionXML.LeerConfiguración("puerto", "activar"));
                if (ConfiguracionXML.ExisteConfiguracion("puerto", "nombre"))
                {
                    FuncionesGenerales.puertoAcceso = ConfiguracionXML.LeerConfiguración("puerto", "nombre");
                }

            }
        }

        private void CargarPromociones()
        {
            if (ConfiguracionXML.LeerConfiguración("promociones", "promo01") != "null" && File.Exists(ConfiguracionXML.LeerConfiguración("promociones", "promo01")))
                FuncionesGenerales.promo01 = new Bitmap(ConfiguracionXML.LeerConfiguración("promociones", "promo01"));
            else
                FuncionesGenerales.promo01 = null;

            if (ConfiguracionXML.LeerConfiguración("promociones", "promo02") != "null" && File.Exists(ConfiguracionXML.LeerConfiguración("promociones", "promo02")))
                FuncionesGenerales.promo02 = new Bitmap(ConfiguracionXML.LeerConfiguración("promociones", "promo02"));
            else
                FuncionesGenerales.promo02 = null;

            if (ConfiguracionXML.LeerConfiguración("promociones", "promo03") != "null" && File.Exists(ConfiguracionXML.LeerConfiguración("promociones", "promo03")))
                FuncionesGenerales.promo03 = new Bitmap(ConfiguracionXML.LeerConfiguración("promociones", "promo03"));
            else
                FuncionesGenerales.promo03 = null;

            if (ConfiguracionXML.LeerConfiguración("promociones", "promo04") != "null" && File.Exists(ConfiguracionXML.LeerConfiguración("promociones", "promo04")))
                FuncionesGenerales.promo04 = new Bitmap(ConfiguracionXML.LeerConfiguración("promociones", "promo04"));
            else
                FuncionesGenerales.promo04 = null;

            if (ConfiguracionXML.LeerConfiguración("promociones", "promo05") != "null" && File.Exists(ConfiguracionXML.LeerConfiguración("promociones", "promo05")))
                FuncionesGenerales.promo05 = new Bitmap(ConfiguracionXML.LeerConfiguración("promociones", "promo05"));
            else
                FuncionesGenerales.promo05 = null;

            if (ConfiguracionXML.LeerConfiguración("promociones", "promo06") != "null" && File.Exists(ConfiguracionXML.LeerConfiguración("promociones", "promo06")))
                FuncionesGenerales.promo06 = new Bitmap(ConfiguracionXML.LeerConfiguración("promociones", "promo06"));
            else
                FuncionesGenerales.promo06 = null;
        }

        private void CargarLector()
        {
            if (!ConfiguracionXML.ExisteConfiguracion("huella", "lector"))
                return;
            DPUruNet.ReaderCollection rs = DPUruNet.ReaderCollection.GetReaders();
            foreach (DPUruNet.Reader r in rs)
            {
                if (r.Description.SerialNumber.ToString() == ConfiguracionXML.LeerConfiguración("huella", "lector"))
                    HuellaDigital.reader = r;
            }
        }
        #endregion



        

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            bgwCargar.RunWorkerAsync();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "v " + Application.ProductVersion.ToString();
        }

        private void BgwCargar_DoWork(object sender, DoWorkEventArgs e)
        {
            Action<string> lbl = new Action<string>(ActualizarLabel);
            try
            {
                Invoke(lbl, "Inicializando la conexión con la base de datos");
                MySQL();
            }
            catch (Exception ex)
            {
                this.Invoke(m, new object[] { this, Mensajes.Error, "No se ha logrado inicializar la conexión a la base de datos. La aplicación se cerrará.", "Admin CSY", ex });
                e.Cancel = true;
                return;
            }
            Invoke(lbl, "Inicializando la configuración de la base de datos");
            ConfiguracionBase();
            if (bgwCargar.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            
            try
            {
                Invoke(lbl, "Validando Licencia se uso");
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\system.evch"))
                {
                    MessageBox.Show("No haz activado la licencia de este producto. Adquiere tu licencia hablando al:\n33354656\nO contactanos en ventas@hubsoluciones.com", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }

                if (!Directory.Exists(Application.StartupPath + "\\Img"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\Img");
                }
                if (!ConfiguracionXML.ExisteConfiguracion("general", "soloRegistro"))
                {
                    ConfiguracionXML.GuardarConfiguracion("general", "soloRegistro", false.ToString());
                    FuncionesGenerales.soloRegistro = false;
                }
                else
                    FuncionesGenerales.soloRegistro = bool.Parse(ConfiguracionXML.LeerConfiguración("general", "soloRegistro"));
                Invoke(lbl, "Cargando configuraciones");
                CargarLector();
                CargarSonidos();
                CargarAcceso();
                if (!ConfiguracionXML.ExisteConfiguracion("huella", "usar"))
                {
                    ConfiguracionXML.GuardarConfiguracion("huella", "usar", false.ToString());
                    FuncionesGenerales.usarHuella = false;
                }
                else
                {
                    FuncionesGenerales.usarHuella = bool.Parse(ConfiguracionXML.LeerConfiguración("huella", "usar"));
                }
                bgwCargar.ReportProgress(10);

                if (!ConfiguracionXML.ExisteConfiguracion("promociones"))
                {
                    Invoke(lbl, "Cargando Promociones");
                    CrearConfiguracionPromociones();
                    CargarPromociones();
                }
                else
                    CargarPromociones();
                bgwCargar.ReportProgress(20);

                ConfiguracionBase();
                try
                {
                    Invoke(lbl, "Comprobando membresias vencidas");
                    Membresia.DesactivarMembresia();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.MensajeError("No se ha podido desactivar las membresías a los usuarios. No se ha podido conectar con la base de datos.", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.MensajeError("No se ha podido desactivar las membresías a los usuarios. Ocurrio un error genérico.", ex);
                }

                try
                {
                    Caja.CrearEstadoCaja();
                }
                catch (CajaException ex)
                {
                    FuncionesGenerales.MensajeError("Ocurrió un error al crear el estado de la caja. Es posible que algunas funciones del software no funcionen correctamente.", ex);
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.MensajeError("Ocurrió un error al verificar el estado de la caja. No se pudo conectar con la base de datos.", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.MensajeError("Ocurrió un error al verificar el estado de la caja. Ocurrió un error genérico.", ex);
                }

                try
                {
                    FuncionesGenerales.DesactivarLockers();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.MensajeError("No se ha podido desactivar los lockers a los usuarios. No se ha podido conectar con la base de datos.", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.MensajeError("No se ha podido desactivar los lockers a los usuarios. Ocurrio un error genérico.", ex);
                }
                bgwCargar.ReportProgress(50);
                Invoke(lbl, "Cargando huellas digitales");
                Socio.ObtenerHuellas();
                bgwCargar.ReportProgress(80);
                EnviarLog();
                Invoke(lbl, "Cargando Interfaz");
                if (!ConfiguracionXML.ExisteConfiguracion("tema"))
                {
                    
                    CrearConfiguracionTema();
                    CargarInterfaz();
                }
                else
                    CargarInterfaz();
                bgwCargar.ReportProgress(100);
                System.Threading.Thread.Sleep(600);
            }
            catch
            {
            }
        }

        private void bgwCargar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prbProgreso1.Value = e.ProgressPercentage;
        }

        private void BgwCargar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!FuncionesGenerales.soloRegistro)
                (new Formularios.frmLogin()).Show();
            else
                Formularios.frmIngresoSocio.Instancia.Show();
            Close();
        }
    }
}
