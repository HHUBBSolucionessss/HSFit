using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using GYM.Clases;

namespace GYM.Formularios.Socio
{
    public partial class frmEditarSocio : Form
    {

        int numSocio;
        global::Socio miem = new global::Socio();
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public byte[] huella = null;

        #region Funciones Camara

        /*
         * Función con la cual se cargan los dispositivos (camaras conectadas a la computadora).
         * Recibe como parametro FilterInfoCollection @var Dispositivos
         */
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
                cbxCamara.Items.Add(Dispositivos[i].Name.ToString());
            cbxCamara.Text = cbxCamara.Items[0].ToString();
        }

        /*
         * BuscarDispositivos() verifica si existen webcams conectadas a la computadora
         * return @var bool ExisteDispositivo
         */
        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
                ExisteDispositivo = false;
            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);
            }
        }

        /*
         * TerminarFuenteVideo()
         * Cierra la conexión con la webcam.
         */
        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        public void Mostrar_Imagen(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pbxImagenPerfil.Image = Imagen;
        }

        #endregion

        #region Metodos
        public frmEditarSocio(int numSocio)
        {
            InitializeComponent();
            FuncionesGenerales.CargarInterfaz(this);
            cbxEstado.SelectedIndex = 0;
            cbxSexo.SelectedIndex = 0;
            BuscarDispositivos();
            this.numSocio = numSocio;
            miem.ObtenerUsuarioPorID(numSocio);
        }

        private bool validarCampos()
        {
            bool res = true;
            if (txtNumSocio.Text == "")
            {
                FuncionesGenerales.ColoresError(txtNumSocio);
                res = false;
                return false;
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtNombre);
                res = false;
                return false;
            }
            if (txtApellidos.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtApellidos);
                res = false;
                return false;
            }
            if (txtTel.Text == "")
            {
                if (txtCelular.Text == "")
                {
                    FuncionesGenerales.ColoresError(txtCelular);
                    res = false;
                    return false;
                }
            }
            else if (txtCelular.Text == "")
            {
                if (txtTel.Text == "")
                {
                    FuncionesGenerales.ColoresError(txtTel);
                    res = false;
                    return false;
                }
            }
            return res;
        }

        private void MostrarDatosMiembro()
        {
            DateTime dt;
            txtNumSocio.Text = miem.NumeroSocio.ToString();
            txtNombre.Text = miem.Nombre;
            txtApellidos.Text = miem.Apellidos;
            if (DateTime.TryParse(miem.FechaNacimiento.ToString(), out dt) && miem.FechaNacimiento >= dtpFechaNac.MinDate && miem.FechaNacimiento <= dtpFechaNac.MaxDate)
                dtpFechaNac.Value = dt;
            else
                dtpFechaNac.Value = DateTime.Now;
            cbxSexo.SelectedIndex = miem.Genero;
            txtDomicilio.Text = miem.Direccion;
            cbxEstado.Text = miem.Estado;
            txtCiudad.Text = miem.Ciudad;
            txtCelular.Text = miem.Celular;
            txtTel.Text = miem.Telefono;
            txtEmail.Text = miem.Email;
            pbxImagenPerfil.Image = global::Socio.ObtenerImagenSocio(miem.NumeroSocio);
            this.huella = miem.Huella;
        }
        #endregion

        private void frmEditarMiembro_Load(object sender, EventArgs e)
        {
            FuncionesGenerales.CerrarHuellas();
            if (HuellaDigital.reader == null)
                btnHuella.Enabled = false;
            FuncionesGenerales.CargarInterfaz(this);
            MostrarDatosMiembro();
        }

        private void txtNumSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    DialogResult dialogResult = MessageBox.Show("¿Los datos ingresados son correctos?", "Nuevo Miembro -HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        global::Socio miembro = new global::Socio();
                        miembro.UpdateUser = frmMain.id;
                        miembro.NumeroSocio = int.Parse(txtNumSocio.Text);
                        miembro.Nombre = txtNombre.Text;
                        miembro.Direccion = txtDomicilio.Text;
                        miembro.Apellidos = txtApellidos.Text;
                        miembro.Ciudad = txtCiudad.Text;
                        miembro.Celular = txtCelular.Text;
                        miembro.Telefono = txtTel.Text;
                        miembro.Email = txtEmail.Text;
                        miembro.Estado = cbxEstado.Text;
                        miembro.FechaNacimiento = dtpFechaNac.Value;
                        miembro.Genero = cbxSexo.SelectedIndex;
                        if (tbxCredito.Text == "")
                        {
                            miembro.LimiteCredito = 0;
                        }
                        else
                            miembro.LimiteCredito = decimal.Parse(tbxCredito.Text);
                        miembro.Huella = huella;
                        miembro.ImagenMiembro = pbxImagenPerfil.Image;
                        miembro.EditarMiembro();
                        MessageBox.Show("Socio modificado Satisfactoriamente", "Actualización Socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        global::Socio.ObtenerHuellas();
                        Close();
                    }
                    else
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            if (btnTomarFoto.Text.Equals("Iniciar Camara"))
            {
                btnTomarFoto.Text = "Tomar Imagen";
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxCamara.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Mostrar_Imagen);
                    FuenteDeVideo.Start();
                    cbxCamara.Enabled = false;
                }
                else
                    MessageBox.Show("No se encuentra ningún dispositivo de vídeo en el sistema\nPor lo tanto no se podran tomar fotografias.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    btnTomarFoto.Text = "Iniciar Camara";
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditarMiembro_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (FuenteDeVideo.IsRunning)
                    TerminarFuenteDeVideo();
            }
            catch (Exception) { }
        }

        private void btnHuella_Click(object sender, EventArgs e)
        {
            (new frmCapturarHuella(this)).ShowDialog(this);
        }

        private void frmEditarMiembro_FormClosed(object sender, FormClosedEventArgs e)
        {
            FuncionesGenerales.AbrirHuellas();
        }

        private void frmEditarSocio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
