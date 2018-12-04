using System;
using System.Drawing;
using System.Windows.Forms;
using DPUruNet;

namespace GYM.Formularios.Socio
{
    public partial class frmCapturarHuella : Form
    {
        
        DataResult<Fmd> res;
        frmNuevoSocio frmA = null;
        frmEditarSocio frmE = null;
        frmNuevoUsuario frmNU = null;
        frmEditarUsuario frmEU = null;

        public frmCapturarHuella(frmNuevoSocio frm)
        {
            InitializeComponent();
            Clases.CFuncionesGenerales.CargarInterfaz(this);
            frmA = frm;
        }

        public frmCapturarHuella(frmEditarSocio frm)
        {
            InitializeComponent();
            frmE = frm;
        }

        public frmCapturarHuella(frmNuevoUsuario frm)
        {
            InitializeComponent();
            frmNU = frm;
        }

        public frmCapturarHuella(frmEditarUsuario frm)
        {
            InitializeComponent();
            frmEU = frm;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (res != null)
            {
                if (frmA != null)
                    frmA.huella = res.Data.Bytes;
                else if (frmE != null)
                    frmE.huella = res.Data.Bytes;
                else if (frmNU != null)
                    frmNU.Huella = res.Data.Bytes;
                else if (frmEU != null)
                    frmEU.Huella = res.Data.Bytes;
            }
            else
            {
                MessageBox.Show("No haz registrado ninguna huella", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Close();
        }

        private void frmCapturarHuella_Load(object sender, EventArgs e)
        {
            pcbHuella.Image = null;
            if (!Clases.HuellaDigital.OpenReader())
            {
                Close();
            }

            if (!Clases.HuellaDigital.StartCaptureAsync(this.OnCaptured))
            {
                Close();
            }
        }

        /// <summary>
        /// Handler for when a fingerprint is captured.
        /// </summary>
        /// <param name="captureResult">contains info and data on the fingerprint capture</param>
        public void OnCaptured(CaptureResult captureResult)
        {
            try
            {
                // Check capture quality and throw an error if bad.
                if (!Clases.HuellaDigital.CheckCaptureResult(captureResult)) return;
                // Create bitmap
                foreach (Fid.Fiv fiv in captureResult.Data.Views)
                {
                    SendMessage(Action.SendBitmap, Clases.HuellaDigital.CreateBitmap(fiv.RawImage, fiv.Width, fiv.Height));
                }
                //Guardamos el FMD de la huella
                res = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);
            }
            catch (Exception ex)
            {
                // Send error message, then close form
                SendMessage(Action.SendMessage, "Error:  " + ex.Message);
            }
        }

        #region SendMessage
        private enum Action
        {
            SendBitmap,
            SendMessage
        }

        private delegate void SendMessageCallback(Action action, object payload);
        private void SendMessage(Action action, object payload)
        {
            try
            {
                if (this.pcbHuella.InvokeRequired)
                {
                    SendMessageCallback d = new SendMessageCallback(SendMessage);
                    this.Invoke(d, new object[] { action, payload });
                }
                else
                {
                    switch (action)
                    {
                        case Action.SendMessage:
                            MessageBox.Show((string)payload);
                            break;
                        case Action.SendBitmap:
                            pcbHuella.Image = (Bitmap)payload;
                            pcbHuella.Refresh();
                            break;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion

        private void frmCapturarHuella_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clases.HuellaDigital.CancelCaptureAndCloseReader(OnCaptured);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
