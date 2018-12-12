using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYM.Clases;
using System.Xml;
using System.IO;

namespace GYM.Formularios
{
    public partial class frmCorreos : Form
    {
        public frmCorreos()
        {
            InitializeComponent();

        }

        private void CargarDatos()
        {
            try
            {
                if (ConfiguracionXML.ExisteConfiguracion("correo"))
                {
                    txtCorreo.Text = ConfiguracionXML.LeerConfiguración("correo", "correoR");
                    txtPass.Text = ConfiguracionXML.LeerConfiguración("correo", "pass");
                    txtPuerto.Text = ConfiguracionXML.LeerConfiguración("correo", "puerto");
                    txtHost.Text = ConfiguracionXML.LeerConfiguración("correo", "host");
                }
            }
            catch (XmlException ex)
            {
                MessageBox.Show("Ocurrio un error al leer el archivo de configuración. Linea y posición de error: " + ex.LineNumber + ", " + ex.LinePosition, "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PathTooLongException ex)
            {
                FuncionesGenerales.MensajeError("La ruta especificada para el arhcivo de configuración en muy larga.", ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                FuncionesGenerales.MensajeError("El directorio del archivo de configuración no se pudo encontrar.", ex);
            }
            catch (FileNotFoundException ex)
            {
                FuncionesGenerales.MensajeError("El archivo de configuración no se pudo encontrar.", ex);
            }
            catch (IOException ex)
            {
                FuncionesGenerales.MensajeError("Ocurrio un error de E/S.", ex);
            }
            catch (NotSupportedException ex)
            {
                FuncionesGenerales.MensajeError("El método invocado no admite la funcionalidad invocada.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                FuncionesGenerales.MensajeError("Windows ha denegado el acceso al archivo de configuración por un error de E/S o por un problema de seguridad.", ex);
            }
            catch (System.Security.SecurityException ex)
            {
                FuncionesGenerales.MensajeError("Se detectó un error de seguridad.", ex);
            }
            catch (ArgumentNullException ex)
            {
                FuncionesGenerales.MensajeError("El argumento dado en el método es nulo.", ex);
            }
            catch (ArgumentException ex)
            {
                FuncionesGenerales.MensajeError("El argumento dado en el método no es aceptado por éste.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void GuardarDatos()
        {
            try
            {
                ConfiguracionXML.GuardarConfiguracion("correo", "correoR", txtCorreo.Text );
                ConfiguracionXML.GuardarConfiguracion("correo", "pass", txtPass.Text);
                ConfiguracionXML.GuardarConfiguracion("correo", "puerto", txtPuerto.Text);
                ConfiguracionXML.GuardarConfiguracion("correo", "host", txtHost.Text);
                pcbImagen.Image.Save(Application.StartupPath + "\\Img\\imagencorreo.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (XmlException ex)
            {
                MessageBox.Show("Ocurrio un error al leer el archivo de configuración. Linea y posición de error: " + ex.LineNumber + ", " + ex.LinePosition, "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PathTooLongException ex)
            {
                FuncionesGenerales.MensajeError("La ruta especificada para el arhcivo de configuración en muy larga.", ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                FuncionesGenerales.MensajeError("El directorio del archivo de configuración no se pudo encontrar.", ex);
            }
            catch (FileNotFoundException ex)
            {
                FuncionesGenerales.MensajeError("El archivo de configuración no se pudo encontrar.", ex);
            }
            catch (IOException ex)
            {
                FuncionesGenerales.MensajeError("Ocurrio un error de E/S.", ex);
            }
            catch (NotSupportedException ex)
            {
                FuncionesGenerales.MensajeError("El método invocado no admite la funcionalidad invocada.", ex);
                throw ex;
            }
            catch (UnauthorizedAccessException ex)
            {
                FuncionesGenerales.MensajeError("Windows ha denegado el acceso al archivo de configuración por un error de E/S o por un problema de seguridad.", ex);
            }
            catch (System.Security.SecurityException ex)
            {
                FuncionesGenerales.MensajeError("Se detectó un error de seguridad.", ex);
            }
            catch (ArgumentNullException ex)
            {
                FuncionesGenerales.MensajeError("El argumento dado en el método es nulo.", ex);
            }
            catch (ArgumentException ex)
            {
                FuncionesGenerales.MensajeError("El argumento dado en el método no es aceptado por éste.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private bool ValidarDatos()
        {
            if (txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("El campo correo no debe ir vacío. Este dato se tomará para enviar el correo.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    MessageBox.Show("El correo ingresado no es válido.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("El campo contraseña no debe ir vacío. Este dato se tomará para enviar el correo.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtPuerto.Text.Trim() == "")
            {
                MessageBox.Show("El campo puerto no debe ir vacío. Este dato servirá para conectar con el servidor de correos.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtHost.Text.Trim() == "")
            {
                MessageBox.Show("El campo host no puede ir vacío. Este dato servirá para conectar con el servidor de correos.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                GuardarDatos();
                MessageBox.Show("Se ha guardado la información correctamente.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void frmCorreos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen (*.jpeg, *.jpg) | *.jpeg; *.jpg;";
            ofd.Multiselect = false;
            DialogResult r = ofd.ShowDialog(this);
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                pcbImagen.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
