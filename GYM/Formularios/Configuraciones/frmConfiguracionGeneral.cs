using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GYM.Clases;

namespace GYM.Formularios
{
    public partial class frmConfiguracionGeneral : Form
    {
        #region Instancia
        private static frmConfiguracionGeneral frmInstancia;
        public static frmConfiguracionGeneral Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmConfiguracionGeneral();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmConfiguracionGeneral();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion
        bool solo;

        public frmMain Frm
        {
            get { return frm; }
            set { frm = value; }
        }
        
        #region Variables
        frmMain frm;
        frmEspere e;
        Bitmap img;
        Bitmap promo01;
        Bitmap promo02;
        Bitmap promo03;
        Bitmap promo04;
        Bitmap promo05;
        Bitmap promo06;
        OpenFileDialog ofdImagen;

        string tmpLetrasCumple;
        string tmpFondoCumple;
        #endregion

        public frmConfiguracionGeneral()
        {
            InitializeComponent();
        }

        #region Metodos
        private void CargarConfiguracion()
        {
            img = FuncionesGenerales.img;
            promo01 = FuncionesGenerales.promo01;
            promo02 = FuncionesGenerales.promo02;
            promo03 = FuncionesGenerales.promo03;
            promo04 = FuncionesGenerales.promo04;
            promo05 = FuncionesGenerales.promo05;
            promo06 = FuncionesGenerales.promo06;
            chbLectorHuella.Checked = FuncionesGenerales.usarHuella;
            solo = chbRegistro.Checked = FuncionesGenerales.soloRegistro;
        }

        private void CargarInterfaz()
        {
            pcbFondo.Image = img;
            pcbPromocion01.Image = promo01;
            pcbPromocion02.Image = promo02;
            pcbPromocion03.Image = promo03;
            pcbPromocion04.Image = promo04;
            pcbPromocion05.Image = promo05;
            pcbPromocion06.Image = promo06;
        }





        private void GuardarVariables()
        {
            FuncionesGenerales.img = img;
            FuncionesGenerales.promo01 = promo01;
            FuncionesGenerales.promo02 = promo02;
            FuncionesGenerales.promo03 = promo03;
            FuncionesGenerales.promo04 = promo04;
            FuncionesGenerales.promo05 = promo05;
            FuncionesGenerales.promo06 = promo06;
            FuncionesGenerales.usarHuella = chbLectorHuella.Checked;
            FuncionesGenerales.soloRegistro = chbRegistro.Checked;
        }

        private void GuardarConfiguracion()
        {
            try
            {
                ConfiguracionXML.GuardarConfiguracion("huella", "usar", chbLectorHuella.Checked.ToString());
                ConfiguracionXML.GuardarConfiguracion("general", "soloRegistro", chbRegistro.Checked.ToString());
                if (FuncionesGenerales.CompararImagenes(img,Properties.Resources.Fondo))
                    ConfiguracionXML.GuardarConfiguracion("tema", "imagenFondo", "Fondo");
                else if (img != null)
                {
                    string ruta = Application.StartupPath + "\\Img\\fondo.png";
                    ConfiguracionXML.GuardarConfiguracion("tema", "imagenFondo", ruta);
                    Bitmap b = new Bitmap(img);
                    try
                    {
                        b.Save(ruta, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch
                    {
                    }
                }
                else
                    ConfiguracionXML.GuardarConfiguracion("tema", "imagenFondo", "null");

                if (pcbPromocion01.Image == null)
                {
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo01", "null");
                    FuncionesGenerales.promo01 = null;
                }
                else
                {
                    string ruta = Application.StartupPath + "\\Img\\promo01.jpeg";
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo01", ruta);
                    Bitmap b = new Bitmap(pcbPromocion01.Image);
                    b.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                if (pcbPromocion02.Image == null)
                {
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo02", "null");
                    FuncionesGenerales.promo02 = null;
                }
                else
                {
                    string ruta = Application.StartupPath + "\\Img\\promo02.jpeg";
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo02", ruta);
                    Bitmap b = new Bitmap(pcbPromocion02.Image);
                    b.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                if (pcbPromocion03.Image == null)
                {
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo03", "null");
                    FuncionesGenerales.promo03 = null;
                }
                else
                {
                    string ruta = Application.StartupPath + "\\Img\\promo03.jpeg";
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo03", ruta);
                    Bitmap b = new Bitmap(pcbPromocion03.Image);
                    b.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                if (pcbPromocion04.Image == null)
                {
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo04", "null");
                    FuncionesGenerales.promo04 = null;
                }
                else
                {
                    string ruta = Application.StartupPath + "\\Img\\promo04.jpeg";
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo04", ruta);
                    Bitmap b = new Bitmap(pcbPromocion04.Image);
                    b.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                if (pcbPromocion05.Image == null)
                {
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo05", "null");
                    FuncionesGenerales.promo05 = null;
                }
                else
                {
                    string ruta = Application.StartupPath + "\\Img\\promo05.jpeg";
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo05", ruta);
                    Bitmap b = new Bitmap(pcbPromocion05.Image);
                    b.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                if (pcbPromocion06.Image == null)
                {
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo06", "null");
                    FuncionesGenerales.promo06 = null;
                }
                else
                {
                    string ruta = Application.StartupPath + "\\Img\\promo06.jpeg";
                    ConfiguracionXML.GuardarConfiguracion("promociones", "promo06", ruta);
                    Bitmap b = new Bitmap(pcbPromocion06.Image);
                    b.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (System.Xml.XmlException ex)
            {
                MessageBox.Show("Ha ocurrido un error al querer leer del archivo XML. Mensaje de error:" + ex.Message + "\nNúmero de linea y posición: " + ex.LineNumber + ", " + ex.LinePosition,
                    "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.PathTooLongException ex)
            {
                FuncionesGenerales.MensajeError("La ruta del directorio es muy larga.", ex);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                FuncionesGenerales.MensajeError("El directorio del archivo de configuración no se encontró.", ex);
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
        #endregion

        private void frmConfiguracionGeneral_Load(object sender, EventArgs e)
        {
            CargarConfiguracion();
        }

        private void frmConfiguracionGeneral_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void pcbFondo_Click(object sender, EventArgs e)
        {
            try
            {
                ofdImagen = new OpenFileDialog();
                ofdImagen.Filter = "Imagenes (*.jpg;*.bmp,*.png,*.gif)|*.jpg;*.bmp;*.png;*.gif";
                ofdImagen.Multiselect = false;
                ofdImagen.RestoreDirectory = false;
                DialogResult d = ofdImagen.ShowDialog();
                if (d == DialogResult.OK)
                {
                    img = new Bitmap(ofdImagen.FileName);
                    pcbFondo.Image = img;
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                FuncionesGenerales.MensajeError("El archivo no se encontró. Verífique que no se haya borrado.", ex);
            }
            catch (ArgumentException ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un error al asignar una propiedad.", ex);
            }
            catch (Exception ex)
            {
               FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void pcbPromociones_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox pcb = (PictureBox)sender;
                int n = int.Parse(pcb.Name.Substring(pcb.Name.Length - 2, 2));
                ofdImagen = new OpenFileDialog();
                ofdImagen.Filter = "Imagenes (*.jpg;*.bmp,*.png,*.gif)|*.jpg;*.bmp;*.png;*.gif";
                ofdImagen.Multiselect = false;
                ofdImagen.RestoreDirectory = false;
                DialogResult d = ofdImagen.ShowDialog();
                if (d == DialogResult.OK)
                {
                    switch (n)
                    {
                        case 1:
                            promo01 = new Bitmap(ofdImagen.FileName);
                            pcb.Image = img;
                            break;
                        case 2:
                            promo02 = new Bitmap(ofdImagen.FileName);
                            pcb.Image = img;
                            break;
                        case 3:
                            promo03 = new Bitmap(ofdImagen.FileName);
                            pcb.Image = img;
                            break;
                        case 4:
                            promo04 = new Bitmap(ofdImagen.FileName);
                            pcb.Image = img;
                            break;
                        case 5:
                            promo05 = new Bitmap(ofdImagen.FileName);
                            pcb.Image = img;
                            break;
                        case 6:
                            promo06 = new Bitmap(ofdImagen.FileName);
                            pcb.Image = img;
                            break;
                    }
                   CargarInterfaz();
                }
                
            }
            catch (System.IO.FileNotFoundException ex)
            {
                FuncionesGenerales.MensajeError("El archivo no se encontró. Verífique que no se haya borrado.", ex);
            }
            catch (FormatException ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un error al dar formato a una variable.", ex);
            }
            catch (OverflowException ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un desbordamiento.", ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                FuncionesGenerales.MensajeError("El argumento dado se sale de rango.", ex);
            }
            catch (ArgumentNullException ex)
            {
                FuncionesGenerales.MensajeError("El método llamado no admite argumentos nulos.", ex);
            }
            catch (ArgumentException ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un error al asignar una propiedad.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Deseas guardar los cambios?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    GuardarVariables();
                    bgwGuardar.RunWorkerAsync();
                    this.e = new frmEspere();
                    this.e.ShowDialog();
                    if (chbRegistro.Checked != solo)
                    {
                        MessageBox.Show("La aplicación se reiniciará.", "HS FIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                }
            }
            catch (InvalidEnumArgumentException ex)
            {
                FuncionesGenerales.MensajeError("La enumeración pasada no es válida para el método llamado.", ex);
            }
            catch (InvalidOperationException ex)
            {
                FuncionesGenerales.MensajeError("La llamada al método no es válida para el estado actual del objeto.", ex);
            }
            catch (NotSupportedException ex)
            {
                FuncionesGenerales.MensajeError("No se admite el método invocado o una secuencia no admite ningún tipo de operación.", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.MensajeError("Ha ocurrido un error genérico.", ex);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            img = null;
            pcbFondo.Image = img;
        }

        private void btnPredeterminado_Click(object sender, EventArgs e)
        {
            img = Properties.Resources.Fondo;
            pcbFondo.Image = img;
        }

        private void btnQuitarPromo01_Click(object sender, EventArgs e)
        {
            pcbPromocion01.Image = null;
        }

        private void btnQuitarPromo02_Click(object sender, EventArgs e)
        {
            pcbPromocion02.Image = null;
        }

        private void btnQuitarPromo03_Click(object sender, EventArgs e)
        {
            pcbPromocion03.Image = null;
        }

        private void btnQuitarPromo04_Click(object sender, EventArgs e)
        {
            pcbPromocion04.Image = null;
        }

        private void btnQuitarPromo05_Click(object sender, EventArgs e)
        {
            pcbPromocion05.Image = null;
        }

        private void btnQuitarPromo06_Click(object sender, EventArgs e)
        {
            pcbPromocion06.Image = null;
        }

        private void bgwGuardar_DoWork(object sender, DoWorkEventArgs e)
        {
            GuardarConfiguracion();
            if (frm != null)
            {
                frm.Controls["pnlFondo"].BackgroundImage = img;
                frm.Controls["pnlFondo"].BackColor = Color.Transparent;
 
            }
        }

        private void bgwGuardar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.e.Close();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grbVisual_Enter(object sender, EventArgs e)
        {

        }
    }
}
