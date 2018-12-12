using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GYM.Formularios.Reportes;

namespace GYM
{
    public partial class frmMain : Form
    {
        int segundos = 0;
        public static int id;
        bool cierreSesion = false;

        #region Instancia
        private static frmMain frmInstancia;
        public static frmMain Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmMain();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmMain();
                return frmInstancia;

            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion


        public frmMain()
        {
            InitializeComponent();
            pnlFondo.BackgroundImage = Clases.FuncionesGenerales.img;
            
        }

        internal void UserDataChanged(object sender, EventArgs e)
        {
            lblNombre.Text = Clases.Usuario.NombreUsuarioActual + "\n" + Clases.Usuario.ApellidosUsuarioActual;
        }

        private void main_Load(object sender, EventArgs e)
        {
            Clases.FuncionesGenerales.CargarInterfaz(this);
                tmrCumpleaños.Enabled = true;
            if (Clases.Caja.EstadoDeCaja)
                abrirToolStripMenuItem.Text = "Cierre de Caja";
            else
                abrirToolStripMenuItem.Text = "Apertura de Caja";
            
        }

        private void toolStripSesion_Click(object sender, EventArgs e)
        {
            Hide();
            List<Form> frms = new List<Form>();
            (new Formularios.frmLogin()).Show();
            foreach (Form frm in Application.OpenForms)
                frms.Add(frm);
            foreach (Form frm in frms)
                if (frm.Name != "frmLogin" && frm.Name != "frmMain")
                    frm.Close();
        }


        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void ingresarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Formularios.Socio.frmNuevoSocio()).ShowDialog();
        }

        private void editarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Formularios.Socio.frmEditarSocio(1)).ShowDialog();
        }

        private void registroDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.frmIngresoSocio.Instancia.Visible)
            {
                Formularios.frmIngresoSocio.Instancia.Show(this);
            }
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.Membresia.frmMembresia.Instancia.Visible)
            {
                Formularios.Membresia.frmMembresia.Instancia.Show(this);
            }
        }

        private void acercaDeGymCSYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Formularios.frmAcercaDe()).ShowDialog();
        }

        private void modificarInformacionPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.frmUsuarios.Instancia.Visible)
                Formularios.frmUsuarios.Instancia.Show();
        }


        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Formularios.Socio.frmSocios()).Show();
        }

 


        private void toolStripSocios_Click(object sender, EventArgs e)
        {
            (new Formularios.Socio.frmSocios()).Show(this);
        }


        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Formularios.frmConfigurarTicket()).Show(this);
        }

        private void registrarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.frmCaja.Instancia.Visible)
                Formularios.frmCaja.Instancia.Show(this);
        }


        private void agregarDineroACajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clases.Caja.EstadoCaja())
            {
                Formularios.Caja.frmMovimientoCaja frm = new Formularios.Caja.frmMovimientoCaja();
                frm.TipoMovimiento = Formularios.Caja.frmMovimientoCaja.Movimiento.Entrada;
                frm.ShowDialog(this);
            }
            else
                if (MessageBox.Show("No puedes realizar operaciones de venta si la caja esta cerrada.\n¿Deseas abrirla?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    (new Formularios.Caja.frmAperturaCaja()).ShowDialog(this);
        }

        private void agregarGastoDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clases.Caja.EstadoCaja())
            {
                Formularios.Caja.frmMovimientoCaja frm = new Formularios.Caja.frmMovimientoCaja();
                frm.TipoMovimiento = Formularios.Caja.frmMovimientoCaja.Movimiento.Salida;
                frm.ShowDialog(this);
            }
            else
                if (MessageBox.Show("No puedes realizar operaciones de venta si la caja esta cerrada.\n¿Deseas abrirla?", "HS FIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    (new Formularios.Caja.frmAperturaCaja()).ShowDialog(this);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cierreSesion)
            {
                Application.Exit();
                Clases.ConexionBD.CerrarConexion();
            }
            if (Clases.Caja.EstadoCaja())
                {
                    DialogResult d = MessageBox.Show("La caja se encuentra abierta, ¿Desea cerrarla?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    if (d == DialogResult.Yes)
                        (new Formularios.Caja.frmCierreCaja()).ShowDialog(this);
                    else if (d == DialogResult.Cancel)
                        e.Cancel = true;
                }
        }

        private void tmrCumpleaños_Tick(object sender, EventArgs e)
        {
            try
            {
                if (segundos == 300)
                {
                    (new Socio(DateTime.Now)).Cumpleaños(this);
                    tmrCumpleaños.Enabled = false;
                }
                else
                    segundos += 1;
            }
            catch (MySqlException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se ha podido mostrar a los socios que cumplen años. No se pudo conectar con la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se ha podido mostrar a los socios que cumplen años. La llamada al método no es válida para el estado actual del objeto", ex);
            }
            catch (System.Threading.ThreadStateException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se ha podido mostrar a los socios que cumplen años. El ThreadState del hilo no es válido para el método invocado.", ex);
            }
            catch (OutOfMemoryException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se ha podido mostrar a los socios que cumplen años. No hay suficiente memoria para continuar la ejecución del programa.", ex);
            }
            catch (ArgumentNullException ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se ha podido mostrar a los socios que cumplen años. El argumento dado al método no es válido.", ex);
            }
            catch (Exception ex)
            {
                Clases.FuncionesGenerales.MensajeError("No se ha podido mostrar a los socios que cumplen años. Ha ocurrido un error genérico.", ex);
            }
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.frmConfiguracionGeneral.Instancia.Visible)
            {
                Formularios.frmConfiguracionGeneral.Instancia.Frm = this;
                Formularios.frmConfiguracionGeneral.Instancia.Show();
            }
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.PuntoDeVenta.frmProducto.Instancia.Visible)
            {
                Formularios.PuntoDeVenta.frmProducto.Instancia.Show(this);
            }
        }

        private void agregarProductoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            (new Formularios.PuntoDeVenta.frmAgregarProducto()).ShowDialog(this);
        }

        private void sociosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Formularios.Socio.frmSocios.Instancia.Visible)
            {
                Formularios.Socio.frmSocios.Instancia.Show(this);
            }
        }

        private void registroDeentradasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!Formularios.frmIngresoSocio.Instancia.Visible)
            {
                Formularios.frmIngresoSocio.Instancia.Show(this);
            }
        }

        private void ticketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Formularios.frmConfigurarTicket.Instancia.Visible)
            {
                Formularios.frmConfigurarTicket.Instancia.Show(this);
            }
        }

        private void puntoDeventaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (!Formularios.POS.frmPuntoVenta.Instancia.Visible)
                Formularios.POS.frmPuntoVenta.Instancia.Show();
            else
                Formularios.POS.frmPuntoVenta.Instancia.Select();
        }

        private void generalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!Formularios.frmConfiguracionGeneral.Instancia.Visible)
            {
                Formularios.frmConfiguracionGeneral.Instancia.Frm = this;
                Formularios.frmConfiguracionGeneral.Instancia.Show();
            }
        }


        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.PuntoDeVenta.frmInventario.Instancia.Visible)
            {
                Formularios.PuntoDeVenta.frmInventario.Instancia.Show(this);
            }
        }

        private void cumpleañosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrCumpleaños.Enabled = false;
            Socio c = new Socio(DateTime.Now);
            c.Cumpleaños(this);
            System.Threading.Thread.Sleep(1000);
        }

        private void baseDedatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.frmConfiguracionBaseDatos.Instancia.Visible)
            {
                Formularios.frmConfiguracionBaseDatos.Instancia.Show(this);
            }
        }


        private void huellaDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Formularios.frmConfigurarHuella()).ShowDialog(this);
        }

        private void sonidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.frmConfiguracionAcceso.Instancia.Visible)
            {
                Formularios.frmConfiguracionAcceso.Instancia.Show();
            }
            else
            {
                Formularios.frmConfiguracionAcceso.Instancia.Select();
            }
        }

        private void cortesíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.Membresia.frmCortesias.Instancia.Visible)
                Formularios.Membresia.frmCortesias.Instancia.Show();
            else
                Formularios.Membresia.frmCortesias.Instancia.Select();
        }

        private void cortesDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Formularios.Caja.frmCorte()).ShowDialog(this);
        }

        private void correoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Formularios.frmCorreos()).ShowDialog(this);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clases.Caja.EstadoCaja())
            {
                (new Formularios.Caja.frmCierreCaja()).ShowDialog();
                if (Clases.Caja.EstadoDeCaja == false)
                {
                    abrirToolStripMenuItem.Text = "Abrir caja";
                }
            }
            else
            {
                (new Formularios.Caja.frmAperturaCaja()).ShowDialog();
                if (Clases.Caja.EstadoDeCaja)
                {
                    abrirToolStripMenuItem.Text = "Cerrar caja";
                }

            } 
        }

        private void listaDeSociosInactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void lockersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.FrmLockers.Instancia.Visible)
                Formularios.FrmLockers.Instancia.Show();
            else
                Formularios.FrmLockers.Instancia.Select();
        }

        private void pendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.frmPendientes.Instancia.Visible)
                Formularios.frmPendientes.Instancia.Show();
            else
                Formularios.frmPendientes.Instancia.Select();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.Compras.frmCompras.Instancia.Visible)
                Formularios.Compras.frmCompras.Instancia.Show();
            else
                Formularios.Compras.frmCompras.Instancia.Select();
        }

        private void membresíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!frmReporteMembresíasSocio.Instancia.Visible)
                frmReporteMembresíasSocio.Instancia.Show();
            else
                frmReporteMembresíasSocio.Instancia.Select();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!frmReporteVentas.Instancia.Visible)
                frmReporteVentas.Instancia.Show();
            else
                frmReporteVentas.Instancia.Select();
        }

        private void preciosDemembresíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.frmConfigurarMembresías.Instancia.Visible)
                Formularios.frmConfigurarMembresías.Instancia.Show();
            else
                Formularios.frmConfigurarMembresías.Instancia.Select();
        }

        private void promocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.Membresia.frmPromociones.Instancia.Visible)
                Formularios.Membresia.frmPromociones.Instancia.Show();
            else
                Formularios.Membresia.frmPromociones.Instancia.Select();
        }

        private void frmMain_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void ventasDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!frmReporteVentaDia.Instancia.Visible)
                frmReporteVentaDia.Instancia.Show();
            else
                frmReporteVentaDia.Instancia.Select();
        }

        private void ventaDeMembresíasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!frmReporteMembresias.Instancia.Visible)
                frmReporteMembresias.Instancia.Show();
            else
                frmReporteMembresias.Instancia.Select();
        }

        private void gananciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!frmReporteGanancia.Instancia.Visible)
                frmReporteGanancia.Instancia.Show();
            else
                frmReporteGanancia.Instancia.Select();
        }

        private void dispositivoAccesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Formularios.Configuraciones.frmConfiguracionAcceso.Instancia.Visible)
                Formularios.Configuraciones.frmConfiguracionAcceso.Instancia.Show();
            else
                Formularios.Configuraciones.frmConfiguracionAcceso.Instancia.Select();

        }

        private void toolStripArchivo_Click(object sender, EventArgs e)
        {

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoSocio_Click(object sender, EventArgs e)
        {
            (new Formularios.Socio.frmNuevoSocio()).ShowDialog(this);
        }

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            if (!Formularios.Membresia.frmMembresia.Instancia.Visible)
            {
                Formularios.Membresia.frmMembresia.Instancia.Show(this);
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (!Formularios.POS.frmPuntoVenta.Instancia.Visible)
                Formularios.POS.frmPuntoVenta.Instancia.Show();
            else
                Formularios.POS.frmPuntoVenta.Instancia.Select();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            if (!Formularios.Compras.frmCompras.Instancia.Visible)
                Formularios.Compras.frmCompras.Instancia.Show();
            else
                Formularios.Compras.frmCompras.Instancia.Select();
        }

        private void btnMovCaja_Click(object sender, EventArgs e)
        {
            if (!Formularios.frmCaja.Instancia.Visible)
                Formularios.frmCaja.Instancia.Show(this);
        }

        private void btnExistencias_Click(object sender, EventArgs e)
        {
        }

        private void pnlAccesosDirectos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            List<Form> forms = new List<Form>();
            cierreSesion = true;
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                forms.Add(frm);
            }
            for (int i = 0; i < forms.Count; i++)
            {
                forms[i].Close();
            }
            (new Formularios.frmLogin()).Show();
        }
    }
}
