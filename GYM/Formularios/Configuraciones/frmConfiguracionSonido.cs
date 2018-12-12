﻿using System;
using System.Media;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GYM.Formularios
{
    public partial class frmConfiguracionAcceso : Form
    {
        bool cargando = true;
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

        private delegate void EnviarMensaje(string mensaje);

        public frmConfiguracionAcceso()
        {
            InitializeComponent();

            cboSonidosBien.SelectedIndex = cboSonidosError.SelectedIndex = 0;
        }

        private void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmConfiguracionSonido_Load(object sender, EventArgs e)
        {
            try
            {
                if (bool.Parse(Clases.ConfiguracionXML.LeerConfiguración("sonidos", "activar")))
                {
                    grbSonidosMembresia.Enabled = chbSonidosMembresias.Checked = true;
                }
                string sonidobien = Clases.ConfiguracionXML.LeerConfiguración("sonidos", "bien"), sonidomal = Clases.ConfiguracionXML.LeerConfiguración("sonidos", "bien");

                if (sonidobien != "Personalizado")
                    cboSonidosBien.SelectedIndex = int.Parse(sonidobien.Substring(sonidobien.Length - 2, 2)) - 1;
                else
                    cboSonidosBien.SelectedIndex = 5;

                if (sonidomal != "Personalizado")
                    cboSonidosError.SelectedIndex = int.Parse(sonidomal.Substring(sonidomal.Length - 2, 2)) - 1;
                else
                    cboSonidosError.SelectedIndex = 5;

                cargando = false;
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
            catch (FormatException ex)
            {
                Clases.FuncionesGenerales.MensajeError("Ha ocurrido un error al dar formato a una variable.", ex);
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

        private void bgwReproduccion_DoWork(object sender, DoWorkEventArgs e)
        {
            EnviarMensaje m = new EnviarMensaje(Mensaje);
            try
            {
                if (e.Argument.ToString() != "SonidoBienP" && e.Argument.ToString() != "SonidoErrorP")
                {
                    SoundPlayer sonido = new SoundPlayer(Application.StartupPath + "\\Sonidos\\" + e.Argument.ToString() + ".wav");
                    sonido.PlaySync();
                }
                else
                {
                    SoundPlayer sonido = new SoundPlayer(Application.StartupPath + "\\Sonidos\\" + e.Argument.ToString().Substring(0, e.Argument.ToString().Length - 1).ToLower() + ".wav");
                    sonido.PlaySync();
                }
            }
            catch (UriFormatException ex)
            {
                this.Invoke(m, "Ha ocurrido un error al reproducir el sonido, URI no valido:\n" + ex.Message);
            }
            catch (TimeoutException ex)
            {
                this.Invoke(m, "Ha ocurrido un error al reproducir el sonido, expiro la hora asiganada del proceso:\n" + ex.Message);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                this.Invoke(m, "Ha ocurrido un error al reproducir el sonido, no se encontro el archivo:\n" + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                this.Invoke(m, "Ha ocurrido un error al reproducir el sonido, la llamada al método no es valida:\n" + ex.Message);
            }
            catch (Exception ex)
            {
                this.Invoke(m, "Ha ocurrido un error al reproducir el sonido:\n" + ex.Message);
            }
        }

        private void bgwReproduccion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void pcbPlayBien_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bgwReproduccion.IsBusy)
                {
                    if (cboSonidosBien.SelectedIndex < 5)
                    {
                        bgwReproduccion.RunWorkerAsync("SonidoBien" + (cboSonidosBien.SelectedIndex + 1).ToString("00"));
                    }
                    else
                    {
                        bgwReproduccion.RunWorkerAsync("SonidoBienP");
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se puede reproducir el sonido. El estado actual del objeto no lo permite.", ex);
            }
        }

        private void pcbPlayMal_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bgwReproduccion.IsBusy)
                {
                   
                    if (cboSonidosError.SelectedIndex < 5)
                    {
                        bgwReproduccion.RunWorkerAsync("SonidoError" + (cboSonidosError.SelectedIndex + 1).ToString("00"));
                    }
                    else
                    {
                        bgwReproduccion.RunWorkerAsync("SonidoErrorP");
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se puede reproducir el sonido. El estado actual del objeto no lo permite.", ex);
            }
        }

        private void chbSonidosMembresias_CheckedChanged(object sender, EventArgs e)
        {
            grbSonidosMembresia.Enabled = chbSonidosMembresias.Checked;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.ConfiguracionXML.GuardarConfiguracion("sonidos", "activar", chbSonidosMembresias.Checked.ToString());
                if (chbSonidosMembresias.Checked)
                {
                    Clases.ConfiguracionXML.GuardarConfiguracion("sonidos", "bien", cboSonidosBien.Items[cboSonidosBien.SelectedIndex].ToString());
                    Clases.ConfiguracionXML.GuardarConfiguracion("sonidos", "mal", cboSonidosError.Items[cboSonidosError.SelectedIndex].ToString());
                    Clases.FuncionesGenerales.usarSonidos = chbSonidosMembresias.Checked;
                    Clases.FuncionesGenerales.sonidoRegBien = cboSonidosBien.Items[cboSonidosBien.SelectedIndex].ToString();
                    Clases.FuncionesGenerales.sonidoRegMal = cboSonidosError.Items[cboSonidosError.SelectedIndex].ToString();
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
            catch (ObjectDisposedException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se pudo llamar al método porque el objeto ha sido desechado.", ex);
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

        private void cboSonidosBien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSonidosBien.SelectedIndex == 5 && !cargando)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos de audio (*.wav)|*.wav";
                ofd.Multiselect = false;
                DialogResult r = ofd.ShowDialog();
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    if (!Directory.Exists(Application.StartupPath + "\\Sonidos"))
                        Directory.CreateDirectory(Application.StartupPath + "\\Sonidos");
                    if (File.Exists(Application.StartupPath + "\\Sonidos\\sonidobien.wav"))
                        File.Delete(Application.StartupPath + "\\Sonidos\\sonidobien.wav");
                    File.Copy(ofd.FileName, Application.StartupPath + "\\Sonidos\\sonidobien.wav");
                }
                else
                {
                    cboSonidosBien.SelectedIndex = 4;
                }
            }
        }

        private void cboSonidosError_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSonidosError.SelectedIndex == 5 && !cargando)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos de audio (*.wav)|*.wav";
                ofd.Multiselect = false;
                DialogResult r = ofd.ShowDialog();
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    if (!Directory.Exists(Application.StartupPath + "\\Sonidos"))
                        Directory.CreateDirectory(Application.StartupPath + "\\Sonidos");
                    if (File.Exists(Application.StartupPath + "\\Sonidos\\sonidoerror.wav"))
                        File.Delete(Application.StartupPath + "\\Sonidos\\sonidoerror.wav");
                    File.Copy(ofd.FileName, Application.StartupPath + "\\Sonidos\\sonidoerror.wav");
                }
                else
                {
                    cboSonidosError.SelectedIndex = 4;
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo i = new ProcessStartInfo();
                i.FileName = "SoundRecorder.exe";
                i.CreateNoWindow = false;
                i.WindowStyle = ProcessWindowStyle.Normal;
                Process p = new Process();
                p.StartInfo = i;
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
