using System;
using System.Windows.Forms;

namespace GYM.Formularios
{
    public partial class frmConfiguracionBaseDatos : Form
    {

        frmSplash frmS = null;
        bool reiniciar = false;
        #region Instancia
        private static frmConfiguracionBaseDatos frmInstancia;
        public static frmConfiguracionBaseDatos Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmConfiguracionBaseDatos();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmConfiguracionBaseDatos();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmConfiguracionBaseDatos()
        {
            InitializeComponent();
            Clases.FuncionesGenerales.CargarInterfaz(this);
        }
        public frmConfiguracionBaseDatos(frmSplash frm)
        {
            InitializeComponent();
            this.frmS = frm;
            reiniciar = false;
        }

        private void GuardarConfig()
        {
            try
            {
                Clases.ConfiguracionXML.GuardarConfiguracion("baseDatos", "servidor", txtServidor.Text);
                Clases.ConfiguracionXML.GuardarConfiguracion("baseDatos", "base", txtBaseDatos.Text);
                Clases.ConfiguracionXML.GuardarConfiguracion("baseDatos", "usuario", txtUsuario.Text);
                Clases.ConfiguracionXML.GuardarConfiguracion("baseDatos", "pass", txtPass.Text);
                Config.servidor = txtServidor.Text;
                Config.baseDatos = txtBaseDatos.Text;
                Config.usuario = txtUsuario.Text;
                Config.pass = txtPass.Text;
            }
            catch (System.Xml.XmlException ex)
            {
                MessageBox.Show("Ha ocurrido un error al querer guardar en el archivo XML. Mensaje de error:" + ex.Message + "\nNúmero de linea y posición: " + ex.LineNumber + ", " + ex.LinePosition,
                    "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.PathTooLongException ex)
            {
                Clases.FuncionesGenerales.MensajeError("La ruta del directorio es muy larga.", ex);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El directorio del archivo de configuración no se encontró.", ex);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se encontro el archivo de configuración.", ex);
            }
            catch (System.IO.IOException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error de E/S.", ex);
            }
            catch (InvalidOperationException ex)
            {
                Clases.FuncionesGenerales.MensajeError("La llamada al método no se pudo efectuar porque el estado actual del objeto no lo permite.", ex);
            }
            catch (NotSupportedException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se pudo leer o modificar la secuencia de datos.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El sistema ha negado el acceso al archivo de configuración.\nPuede deberse a un error de E/S o a un error de seguridad.", ex);
            }
            catch (System.Security.SecurityException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error de seguridad.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El método no acepta referencias nulas.", ex);
            }
            catch (ArgumentException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El argumento que se pasó al método no es aceptado por este.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarConfig();
                if (frmMain.Instancia.Visible)
                {
                    MessageBox.Show("La aplicación se cerrará.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                    this.Close();
            }
            catch (ObjectDisposedException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error llamando a un método en un objeto desechado.", ex);
            }
            catch (InvalidOperationException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Se ha llamado a un método en un objeto cuyo estado actual no lo permite.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void frmConfiguracionBaseDatos_Load(object sender, EventArgs e)
        {
            try
            {
                if (Clases.ConfiguracionXML.ExisteConfiguracion("baseDatos"))
                {
                    txtServidor.Text = Clases.ConfiguracionXML.LeerConfiguración("baseDatos", "servidor");
                    txtBaseDatos.Text = Clases.ConfiguracionXML.LeerConfiguración("baseDatos", "base");
                    txtUsuario.Text = Clases.ConfiguracionXML.LeerConfiguración("baseDatos", "usuario");
                    txtPass.Text = Clases.ConfiguracionXML.LeerConfiguración("baseDatos", "pass");
                }
            }
            catch (System.Xml.XmlException ex)
            {
                MessageBox.Show("Ha ocurrido un error al querer leer del archivo XML. Mensaje de error:" + ex.Message + "\nNúmero de linea y posición: " + ex.LineNumber + ", " + ex.LinePosition,
                    "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.PathTooLongException ex)
            {
                Clases.FuncionesGenerales.MensajeError("La ruta del directorio es muy larga.", ex);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El directorio del archivo de configuración no se encontró.", ex);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se encontro el archivo de configuración.", ex);
            }
            catch (System.IO.IOException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error de E/S.", ex);
            }
            catch (InvalidOperationException ex)
            {
                Clases.FuncionesGenerales.MensajeError("La llamada al método no se pudo efectuar porque el estado actual del objeto no lo permite.", ex);
            }
            catch (NotSupportedException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se pudo leer o modificar la secuencia de datos.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El sistema ha negado el acceso al archivo de configuración.\nPuede deberse a un error de E/S o a un error de seguridad.", ex);
            }
            catch (System.Security.SecurityException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error de seguridad.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El método no acepta referencias nulas.", ex);
            }
            catch (ArgumentException ex)
            {
                Clases.FuncionesGenerales.MensajeError("El argumento que se pasó al método no es aceptado por este.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
