using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace GYM.Formularios.Configuraciones
{
    public partial class frmConfiguracionAcceso : Form
    {
        string puerto;


        #region Instancia
        private static frmConfiguracionAcceso frmInstancia;
        public static frmConfiguracionAcceso Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmConfiguracionAcceso();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmConfiguracionAcceso();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion
        public frmConfiguracionAcceso()
        {
            InitializeComponent();
        }



        private void CargarPuertos()
        {
            foreach (string s in SerialPort.GetPortNames())
                cboPuertos.Items.Add(s);
            for (int i = 0; i < cboPuertos.Items.Count; i++)
            {
                if (i == 0)
                    cboPuertos.SelectedIndex = 0;
                if (cboPuertos.Items[i].ToString() == puerto)
                {
                    cboPuertos.SelectedIndex = i;
                    break;
                }
            }
        }

        private void CargarConfiguracion()
        {
            puerto = Clases.CConfiguracionXML.LeerConfiguración("puerto", "nombre");
        }

        private void chbSonidosMembresias_CheckedChanged(object sender, EventArgs e)
        {
            cboPuertos.Enabled = chbConfigurarAcceso.Value;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Deseas guardar la configuración?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                GuardarConfiguracion();
                this.Close();
            }
            
        }

        private void GuardarConfiguracion()
        {
            try
            {
                Clases.CConfiguracionXML.GuardarConfiguracion("puerto", "activar", chbConfigurarAcceso.Value.ToString());
                if (cboPuertos.Items.Count > 0)
                {
                    Clases.CConfiguracionXML.GuardarConfiguracion("puerto", "nombre", cboPuertos.Items[cboPuertos.SelectedIndex].ToString());
                    Clases.CFuncionesGenerales.usarAcceso = chbConfigurarAcceso.Value;
                    Clases.CFuncionesGenerales.puertoAcceso = cboPuertos.Items[cboPuertos.SelectedIndex].ToString();
                }
                else
                {
                    Clases.CConfiguracionXML.GuardarConfiguracion("puerto", "nombre", "");
                    Clases.CFuncionesGenerales.usarAcceso = chbConfigurarAcceso.Value;
                    Clases.CFuncionesGenerales.puertoAcceso = "";
                }
                this.Close();
            }
            catch (System.Xml.XmlException ex)
            {
                MessageBox.Show("Ha ocurrido un error al querer guardar en el archivo XML. Mensaje de error:" + ex.Message + "\nNúmero de linea y posición: " + ex.LineNumber + ", " + ex.LinePosition,
                    "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.PathTooLongException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("La ruta del directorio es muy larga.", ex);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("El directorio del archivo de configuración no se encontró.", ex);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("No se encontro el archivo de configuración.", ex);
            }
            catch (System.IO.IOException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error de E/S.", ex);
            }
            catch (ObjectDisposedException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("No se pudo llamar al método porque el objeto ha sido desechado.", ex);
            }
            catch (InvalidOperationException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("La llamada al método no se pudo efectuar porque el estado actual del objeto no lo permite.", ex);
            }
            catch (NotSupportedException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("No se pudo leer o modificar la secuencia de datos.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("El sistema ha negado el acceso al archivo de configuración.\nPuede deberse a un error de E/S o a un error de seguridad.", ex);
            }
            catch (System.Security.SecurityException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error de seguridad.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("El método no acepta referencias nulas.", ex);
            }
            catch (ArgumentException ex)
            {
                Clases.CFuncionesGenerales.MensajeError("El argumento que se pasó al método no es aceptado por este.", ex);
            }
            catch (Exception ex)
            {
                Clases.CFuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }


        private void frmConfiguracionAcceso_Load(object sender, EventArgs e)
        {
            if (bool.Parse(Clases.CConfiguracionXML.LeerConfiguración("puerto", "activar")))
            {
                cboPuertos.Enabled = chbConfigurarAcceso.Value = true;
            }
            CargarPuertos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbConfigurarAcceso_OnValueChange(object sender, EventArgs e)
        {
            cboPuertos.Enabled = chbConfigurarAcceso.Value;
        }
    }
}
