﻿using System;
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
        private delegate void AbrirConfiguracion();
        private delegate void AbrirFormConParametro(int count);

        public frmSplash()
        {
            InitializeComponent();
        }

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

        private void ConfigBaseDatos()
        {
            Formularios.frmConfiguracionBaseDatos.Instancia.ShowDialog(this);
            System.Threading.Thread.Sleep(0);
        }

        private void CrearConfiguracionTema()
        {
            //Colores sistema
            CConfiguracionXML.GuardarConfiguracion("tema", "imagenFondo", "Fondo");
        }

        private void CrearConfiguracionPromociones()
        {
            if (!CConfiguracionXML.ExisteConfiguracion("promociones"))
            {
                //Imagenes Promociones
                CConfiguracionXML.GuardarConfiguracion("promociones", "promo01", "null");
                CConfiguracionXML.GuardarConfiguracion("promociones", "promo02", "null");
                CConfiguracionXML.GuardarConfiguracion("promociones", "promo03", "null");
                CConfiguracionXML.GuardarConfiguracion("promociones", "promo04", "null");
                CConfiguracionXML.GuardarConfiguracion("promociones", "promo05", "null");
                CConfiguracionXML.GuardarConfiguracion("promociones", "promo06", "null");
            }
        }

        private void CargarInterfaz()
        {
            string imgFondo = CConfiguracionXML.LeerConfiguración("tema", "imagenFondo");
            if (imgFondo == "Fondo")
                CFuncionesGenerales.img = (Bitmap)Properties.Resources.ResourceManager.GetObject(imgFondo);
            else if (imgFondo != "null")
                CFuncionesGenerales.img = new Bitmap(imgFondo);
            else
                CFuncionesGenerales.img = null;
        }

        private void CargarSonidos()
        {
            if (!CConfiguracionXML.ExisteConfiguracion("sonidos"))
            {
                CConfiguracionXML.GuardarConfiguracion("sonidos", "activar", false.ToString());
                CConfiguracionXML.GuardarConfiguracion("sonidos", "bien", "Sonido01");
                CConfiguracionXML.GuardarConfiguracion("sonidos", "mal", "Sonido01");
                CFuncionesGenerales.usarSonidos = false;
                CFuncionesGenerales.sonidoRegBien = "Sonido01";
                CFuncionesGenerales.sonidoRegMal = "Sonido01";
            }
            else
            {
                CFuncionesGenerales.usarSonidos = bool.Parse(CConfiguracionXML.LeerConfiguración("sonidos", "activar"));
                CFuncionesGenerales.sonidoRegBien = CConfiguracionXML.LeerConfiguración("sonidos", "bien");
                CFuncionesGenerales.sonidoRegMal = CConfiguracionXML.LeerConfiguración("sonidos", "mal");
            }
        }

        private void CargarAcceso()
        {
            if (!CConfiguracionXML.ExisteConfiguracion("puerto"))
            {
                CConfiguracionXML.GuardarConfiguracion("puerto", "activar", false.ToString());
                CFuncionesGenerales.usarAcceso = false;

            }
            else
            {
                CFuncionesGenerales.usarAcceso = bool.Parse(CConfiguracionXML.LeerConfiguración("puerto", "activar"));
                if (CConfiguracionXML.ExisteConfiguracion("puerto", "nombre"))
                {
                    CFuncionesGenerales.puertoAcceso = CConfiguracionXML.LeerConfiguración("puerto", "nombre");
                }
               
            }
        }

        private void CargarPromociones()
        {
            if (CConfiguracionXML.LeerConfiguración("promociones", "promo01") != "null" && File.Exists(CConfiguracionXML.LeerConfiguración("promociones", "promo01")))
                CFuncionesGenerales.promo01 = new Bitmap(CConfiguracionXML.LeerConfiguración("promociones", "promo01"));
            else
                CFuncionesGenerales.promo01 = null;

            if (CConfiguracionXML.LeerConfiguración("promociones", "promo02") != "null" && File.Exists(CConfiguracionXML.LeerConfiguración("promociones", "promo02")))
                CFuncionesGenerales.promo02 = new Bitmap(CConfiguracionXML.LeerConfiguración("promociones", "promo02"));
            else
                CFuncionesGenerales.promo02 = null;

            if (CConfiguracionXML.LeerConfiguración("promociones", "promo03") != "null" && File.Exists(CConfiguracionXML.LeerConfiguración("promociones", "promo03")))
                CFuncionesGenerales.promo03 = new Bitmap(CConfiguracionXML.LeerConfiguración("promociones", "promo03"));
            else
                CFuncionesGenerales.promo03 = null;

            if (CConfiguracionXML.LeerConfiguración("promociones", "promo04") != "null" && File.Exists(CConfiguracionXML.LeerConfiguración("promociones", "promo04")))
                CFuncionesGenerales.promo04 = new Bitmap(CConfiguracionXML.LeerConfiguración("promociones", "promo04"));
            else
                CFuncionesGenerales.promo04 = null;

            if (CConfiguracionXML.LeerConfiguración("promociones", "promo05") != "null" && File.Exists(CConfiguracionXML.LeerConfiguración("promociones", "promo05")))
                CFuncionesGenerales.promo05 = new Bitmap(CConfiguracionXML.LeerConfiguración("promociones", "promo05"));
            else
                CFuncionesGenerales.promo05 = null;

            if (CConfiguracionXML.LeerConfiguración("promociones", "promo06") != "null" && File.Exists(CConfiguracionXML.LeerConfiguración("promociones", "promo06")))
                CFuncionesGenerales.promo06 = new Bitmap(CConfiguracionXML.LeerConfiguración("promociones", "promo06"));
            else
                CFuncionesGenerales.promo06 = null;
        }

        private void ConfiguracionBase()
        {
            try
            {
                AbrirConfiguracion a = new AbrirConfiguracion(ConfigBaseDatos);
                if (!MySQL() && !CFuncionesGenerales.soloRegistro)
                {
                    ActivarServicioMySQL();
                }
                if (MySQL())
                {
                    if (!CConfiguracionXML.ExisteConfiguracion("baseDatos"))
                    {
                        if (MessageBox.Show("No está configurada la base de datos.\n¿Desea configurarla?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Invoke(a);
                        }
                        else
                        {
                            MessageBox.Show("La aplicación se cerrará. Puede configurarla la próxima vez que abra el programa.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }
                    else
                    {
                        ConexionBD.servidor = CConfiguracionXML.LeerConfiguración("baseDatos", "servidor");
                        ConexionBD.baseDatos = CConfiguracionXML.LeerConfiguración("baseDatos", "base");
                        ConexionBD.usuario = CConfiguracionXML.LeerConfiguración("baseDatos", "usuario");
                        ConexionBD.pass = CConfiguracionXML.LeerConfiguración("baseDatos", "pass");
                    }
                    VerificarConfiguracion();
                }
                else
                {
                    if (CFuncionesGenerales.soloRegistro)
                    {
                        if (!CConfiguracionXML.ExisteConfiguracion("baseDatos"))
                        {
                            if (MessageBox.Show("No está configurada la base de datos.\n¿Desea configurarlo?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes)
                            {
                                this.Invoke(a);
                            }
                            else
                            {
                                MessageBox.Show("La aplicación se cerrará. Puede configurarla la próxima vez que abra el programa.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Exit();
                            }
                        }
                        else
                        {
                            ConexionBD.servidor = CConfiguracionXML.LeerConfiguración("baseDatos", "servidor");
                            ConexionBD.baseDatos = CConfiguracionXML.LeerConfiguración("baseDatos", "base");
                            ConexionBD.usuario = CConfiguracionXML.LeerConfiguración("baseDatos", "usuario");
                            ConexionBD.pass = CConfiguracionXML.LeerConfiguración("baseDatos", "pass");
                        }
                        VerificarConfiguracion();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido iniciar el servicio de MySQL. Intentelo desde la aplicación de administración.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                CFuncionesGenerales.MensajeError("No se ha podido conectar a la base de datos. Active el servicio de MySQL desde la aplicación de configuración.", ex);
            }
        }

        private void VerificarConfiguracion()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id FROM usuarios LIMIT 1";
                ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException)
            {
                if (MessageBox.Show("No se ha podido conectar con la base de datos. La aplicación se cerrará.\n¿Desea volver a configurar los datos de conexión?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    AbrirConfiguracion a = new AbrirConfiguracion(ConfigBaseDatos);
                    Invoke(a);
                    VerificarConfiguracion();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void CargarLector()
        {
            if (!CConfiguracionXML.ExisteConfiguracion("huella", "lector"))
                return;
            DPUruNet.ReaderCollection rs = DPUruNet.ReaderCollection.GetReaders();
            foreach (DPUruNet.Reader r in rs)
            {
                if (r.Description.SerialNumber.ToString() == CConfiguracionXML.LeerConfiguración("huella", "lector"))
                    HuellaDigital.reader = r;
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
                        if (CConfiguracionXML.ExisteConfiguracion("correo"))
                        {
                            CCorreos c = new CCorreos();
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
                CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            bgwCargar.RunWorkerAsync();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "v " + Application.ProductVersion.ToString();
        }

        private void bgwCargar_DoWork(object sender, DoWorkEventArgs e)
        {
            AbrirConfiguracion a = new AbrirConfiguracion(ConfigBaseDatos);
            try
            {
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\system.evch"))
                {
                    MessageBox.Show("No haz activado la licencia de este producto. Adquiere tu licencia hablando al:\n33354656\nO contactanos en ventas@hubsoluciones.com", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                if (!Directory.Exists(Application.StartupPath + "\\Img"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\Img");
                }
                if (!CConfiguracionXML.ExisteConfiguracion("general", "soloRegistro"))
                {
                    CConfiguracionXML.GuardarConfiguracion("general", "soloRegistro", false.ToString());
                    CFuncionesGenerales.soloRegistro = false;
                }
                else
                    CFuncionesGenerales.soloRegistro = bool.Parse(CConfiguracionXML.LeerConfiguración("general", "soloRegistro"));
                CargarLector();
                CargarSonidos();
                CargarAcceso();
                if (!CConfiguracionXML.ExisteConfiguracion("huella", "usar"))
                {
                    CConfiguracionXML.GuardarConfiguracion("huella", "usar", false.ToString());
                    CFuncionesGenerales.usarHuella = false;
                }
                else
                {
                    CFuncionesGenerales.usarHuella = bool.Parse(CConfiguracionXML.LeerConfiguración("huella", "usar"));
                }
                bgwCargar.ReportProgress(10);

                if (!CConfiguracionXML.ExisteConfiguracion("tema"))
                {
                    CrearConfiguracionTema();
                    CargarInterfaz();
                }
                else
                    CargarInterfaz();
                if (!CConfiguracionXML.ExisteConfiguracion("promociones"))
                {
                    CrearConfiguracionPromociones();
                    CargarPromociones();
                }
                else
                    CargarPromociones();
                bgwCargar.ReportProgress(20);

                ConfiguracionBase();
                try
                {
                    Membresia.DesactivarMembresia();
                }
                catch (MySqlException ex)
                {
                    CFuncionesGenerales.MensajeError("No se ha podido desactivar las membresías a los usuarios. No se ha podido conectar con la base de datos.", ex);
                }
                catch (Exception ex)
                {
                    CFuncionesGenerales.MensajeError("No se ha podido desactivar las membresías a los usuarios. Ocurrio un error genérico.", ex);
                }

                try
                {
                    Caja.CrearEstadoCaja();
                }
                catch (CajaException ex)
                {
                    CFuncionesGenerales.MensajeError("Ocurrió un error al crear el estado de la caja. Es posible que algunas funciones del software no funcionen correctamente.", ex);
                }
                catch (MySqlException ex)
                {
                    CFuncionesGenerales.MensajeError("Ocurrió un error al verificar el estado de la caja. No se pudo conectar con la base de datos.", ex);
                }
                catch (Exception ex)
                {
                    CFuncionesGenerales.MensajeError("Ocurrió un error al verificar el estado de la caja. Ocurrió un error genérico.", ex);
                }

                try
                {
                    CFuncionesGenerales.DesactivarLockers();
                }
                catch (MySqlException ex)
                {
                    CFuncionesGenerales.MensajeError("No se ha podido desactivar los lockers a los usuarios. No se ha podido conectar con la base de datos.", ex);
                }
                catch (Exception ex)
                {
                    CFuncionesGenerales.MensajeError("No se ha podido desactivar los lockers a los usuarios. Ocurrio un error genérico.", ex);
                }
                Socio.ObtenerHuellas();
                EnviarLog();
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

        private void bgwCargar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!CFuncionesGenerales.soloRegistro)
                (new Formularios.frmLogin()).Show();
            else
                Formularios.frmIngresoSocio.Instancia.Show();
            Close();
        }
    }
}
