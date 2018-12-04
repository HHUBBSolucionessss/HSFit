﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Clases
{
    public partial class CTicket
    {
        #region Metodos Generales
        /// <summary>
        /// Función que obtiene información de los archivos de configuración.
        /// </summary>
        /// <exception cref="System.FormatException">Excepción que se produce cuando el formato de un argumento no cumple las especificaciones de los parámetros del método invocado.</exception>
        /// <exception cref="Systen.OverflowException">Excepción que se produce cuando una operación aritmética, de conversión de tipo o de conversión de otra naturaleza en un contexto comprobado, da como resultado una sobrecarga.</exception>
        /// <exception cref="System.Xml.XmlException">Devuelve información detallada sobre la última excepción.</exception>
        /// <exception cref="System.IO.PathTooLongException">Excepción que se produce cuando una ruta de acceso o un nombre de archivo supera la longitud máxima definida por el sistema.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">Excepción que se produce cuando no encuentra parte de un archivo o directorio.</exception>
        /// <exception cref="System.IO.FileNotFoundException">Excepción que se produce cuando se produce un error al intentar tener acceso a un archivo que no existe en el disco.</exception>
        /// <exception cref="System.IO.IOException">Excepción que es lanzada cuando se produce un error de E/S.</exception>
        /// <exception cref="System.NotSupportedException">Excepción que se produce cuando no se admite un método invocado o cuando se intenta leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Excepción que se produce cuando el sistema operativo deniega el acceso a causa de un error de E/S o de un error de seguridad de un tipo concreto.</exception>
        /// <exception cref="System.Security.SecurityException">La excepción que se produce cuando se detecta un error de seguridad.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        private void ObtenerDatosConfiguracion()
        {
            try
            {
                lineaSup01 = Clases.CConfiguracionXML.LeerConfiguración("ticket", "lineaSup01");
                lineaSup02 = Clases.CConfiguracionXML.LeerConfiguración("ticket", "lineaSup02");
                lineaSup03 = Clases.CConfiguracionXML.LeerConfiguración("ticket", "lineaSup03");
                lineaSup04 = Clases.CConfiguracionXML.LeerConfiguración("ticket", "lineaSup04");
                lineaSup05 = Clases.CConfiguracionXML.LeerConfiguración("ticket", "lineaSup05");
                lineaSup06 = Clases.CConfiguracionXML.LeerConfiguración("ticket", "lineaSup06");
                lineaSup07 = Clases.CConfiguracionXML.LeerConfiguración("ticket", "lineaSup07");
                lineaInf01 = Clases.CConfiguracionXML.LeerConfiguración("ticket", "lineaInf01");
                lineaInf02 = Clases.CConfiguracionXML.LeerConfiguración("ticket", "lineaInf02");
                lineaInf03 = Clases.CConfiguracionXML.LeerConfiguración("ticket", "lineaInf03");
                impresora = Clases.CConfiguracionXML.LeerConfiguración("ticket", "impresora");
                tamPapel = int.Parse(Clases.CConfiguracionXML.LeerConfiguración("ticket", "tamPapel"));
                turnoMat = TimeSpan.Parse(Clases.CConfiguracionXML.LeerConfiguración("ticket", "turnoMat"));
                turnoVes = TimeSpan.Parse(Clases.CConfiguracionXML.LeerConfiguración("ticket", "turnoVes"));
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (System.Xml.XmlException ex)
            {
                throw ex;
            }
            catch (System.IO.PathTooLongException ex)
            {
                throw ex;
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                throw ex;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                throw ex;
            }
            catch (System.IO.IOException ex)
            {
                throw ex;
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw ex;
            }
            catch (System.Security.SecurityException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que obtiene el dato del DataTable en la columna especifica.
        /// </summary>
        /// <param name="nomCol">Nombre de la columna</param>
        /// <exception cref="System.IndexOutOfRangeException">Excepción que se produce cuando se intenta tener acceso a un elemento de una matriz con un índice que está fuera de los límites de la matriz.</exception>
        /// <returns>Objeto con el dato</returns>
        private object ObtenerDatoDataTableMembresia(string nomCol)
        {
            try
            {
                return dtMembresia.Rows[0][nomCol];
            }
            catch (IndexOutOfRangeException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que obtiene el dato del DataTable en la columna especifica.
        /// </summary>
        /// <param name="nomCol">Nombre de la columna</param>
        /// <exception cref="System.IndexOutOfRangeException">Excepción que se produce cuando se intenta tener acceso a un elemento de una matriz con un índice que está fuera de los límites de la matriz.</exception>
        /// <returns>Objeto con el dato</returns>
        private object ObtenerDatoDataTableLocker(string nomCol)
        {
            try
            {
                return dtLocker.Rows[0][nomCol];
            }
            catch (IndexOutOfRangeException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos Ticket
        /// <summary>
        /// Función que agrega el encabezado al ticket con los datos del archivo de configuración.
        /// </summary>
        /// <param name="e">Referencia del objeto de PrintPageEventArgs.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void AgregarEncabezadoTicket(ref PrintPageEventArgs e)
        {
            try
            {
                if (lineaSup01 != "")
                {
                    CentrarTexto(ref e, lineaSup01, fuenteGrandeResaltada, Brushes.Black);
                    y += saltoLinea + 2;
                }

                if (lineaSup02 != "")
                {
                    CentrarTexto(ref e, lineaSup02, fuenteGrande, Brushes.Black);
                    y += saltoLinea;
                }

                if (lineaSup03 != "")
                {
                    CentrarTexto(ref e, lineaSup03, fuenteGrande, Brushes.Black);
                    y += saltoLinea;
                }

                if (lineaSup04 != "")
                {
                    CentrarTexto(ref e, lineaSup04, fuenteGrande, Brushes.Black);
                    y += saltoLinea;
                }

                if (lineaSup05 != "")
                {
                    CentrarTexto(ref e, lineaSup05, fuenteGrande, Brushes.Black);
                    y += saltoLinea;
                }

                if (lineaSup06 != "")
                {
                    CentrarTexto(ref e, lineaSup06, fuenteGrande, Brushes.Black);
                    y += saltoLinea;
                }

                if (lineaSup07 != "")
                {
                    CentrarTexto(ref e, lineaSup07, fuenteGrande, Brushes.Black);
                    y += saltoLinea;
                }
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que agrega la información de venta al ticket
        /// </summary>
        /// <param name="e">Referencia al objeto de la clase PrintPageEventArgs</param>
        /// <param name="esCierreCaja">Valor booleano que indica si la información que se agregará es sobre el cierre de caja</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void AgregarInformacionTicket(ref PrintPageEventArgs e, bool esCierreCaja)
        {
            try
            {
                string turno = "";
                string fecha="";

                if (!esCierreCaja)
                {
                    e.Graphics.DrawString("SERVICIO: VENTA MOSTRADOR", fuenteNormal, Brushes.Black, 0, y);
                    y += saltoLinea;
                    e.Graphics.DrawString("TICKET: " + folio.ToString("000000"), fuenteNormal, Brushes.Black, 0, y);
                    y += saltoLinea;
                    e.Graphics.DrawString("FECHA: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), fuenteNormal, Brushes.Black, 0, y);
                }
                else
                {
                    e.Graphics.DrawString("SERVICIO: CIERRE DE CAJA", fuenteNormal, Brushes.Black, 0, y+=saltoLineaPeque);
                    y += saltoLinea;
                   
                    e.Graphics.DrawString("FECHA: "+fecha, fuenteNormal, Brushes.Black, 0, y);
                }
                
                y += saltoLinea + 5;
                if (DateTime.Now.TimeOfDay >= turnoMat && DateTime.Now.TimeOfDay < turnoVes)
                    turno = "MATUTINO";
                else
                    turno = "VESPERTINO";
                e.Graphics.DrawString("TURNO: " + turno, fuenteNormal, Brushes.Black, 0, y);
                y += saltoLinea;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que agrega los datos del pie del ticket
        /// </summary>
        /// <param name="e"></param>
        /// <param name="dt">DataTable con los datos del pie del ticket.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void AgregarPieTicket(ref PrintPageEventArgs e, DataTable dt)
        {
            try
            {
                y += saltoLinea / 2;
                if (folio != 0 || dt != null)
                    e.Graphics.DrawString("ATENDIÓ: " + ObtenerNombreUsuario(int.Parse(dt.Rows[0]["create_user_id"].ToString())), fuenteNormal, Brushes.Black, 0, y);
                else
                    e.Graphics.DrawString("ATENDIÓ: " + ObtenerNombreUsuario(frmMain.id), fuenteNormal, Brushes.Black, 0, y);
                y += saltoLinea * 4 / 3;
                if (lineaInf01 != "")
                {
                    CentrarTexto(ref e, lineaInf01, fuenteNormal, Brushes.Black);
                    y += saltoLinea;
                }
                if (lineaInf02 != "")
                {
                    CentrarTexto(ref e, lineaInf02, fuenteNormal, Brushes.Black);
                    y += saltoLinea;
                }
                if (lineaInf03 != "")
                {
                    CentrarTexto(ref e, lineaInf03, fuenteNormal, Brushes.Black);
                    y += saltoLinea;
                }
                y += saltoLinea;
                CentrarTexto(ref e, "AGRADECEMOS SU PREFERENCIA", fuenteNormal, Brushes.Black);
                y += saltoLinea;
                CentrarTexto(ref e, "HS FIT v" + Application.ProductVersion.ToString(), fuentePequeña, Brushes.Black);
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que agrega la información de los productos de la venta
        /// </summary>
        /// <param name="e"></param>
        /// <param name="dt">DataTable con la información de los productos.</param>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void AgregarProductosVentas(ref PrintPageEventArgs e, DataTable dt)
        {
            try
            {
                e.Graphics.DrawString("PRODUCTO", fuenteResaltada, Brushes.Black, 0F, y);
                e.Graphics.DrawString("PRECIO", fuenteResaltada, Brushes.Black, (e.PageBounds.Width / 4) + 25, y);
                e.Graphics.DrawString("CANT", fuenteResaltada, Brushes.Black, (e.PageBounds.Width / 4) * 2 + 15, y);
                e.Graphics.DrawString("IMP", fuenteResaltada, Brushes.Black, (e.PageBounds.Width / 4) * 3 - 5, y);
                y += saltoLinea;
                foreach (DataRow dr in dt.Rows)
                {
                    string prod = ObtenerNombreProducto(dr["id_producto"].ToString());
                    decimal precio = ObtenerPrecioProducto(dr["id_producto"].ToString());
                    decimal cant = decimal.Parse(dr["cantidad"].ToString());
                    AgregarNombreProducto(ref e, prod);
                    e.Graphics.DrawString(precio.ToString("C2"), fuenteNormal, Brushes.Black, (e.PageBounds.Width / 4) + 25, y);
                    e.Graphics.DrawString(cant.ToString(), fuenteNormal, Brushes.Black, (e.PageBounds.Width / 4) * 2 + 15, y);
                    e.Graphics.DrawString((precio * cant).ToString("C2"), fuenteNormal, Brushes.Black, (e.PageBounds.Width / 4) * 3 - 5, y);
                    y += saltoLinea;
                }
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que recorta en caso de ser necesario y agrega al ticket la información de un producto.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="nomProd">Nombre del producto.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void AgregarNombreProducto(ref PrintPageEventArgs e, string nomProd)
        {
            try
            {
                if (e.Graphics.MeasureString(nomProd, fuenteNormal).Width > ((e.PageBounds.Width / 4) + 20))
                {
                    while (e.Graphics.MeasureString(nomProd, fuenteNormal).Width > ((e.PageBounds.Width / 4) + 20))
                        nomProd = nomProd.Substring(0, nomProd.Length - 1);
                    nomProd = nomProd.Substring(0, nomProd.Length - 3) + "...";
                }
                e.Graphics.DrawString(nomProd, fuenteNormal, Brushes.Black, 0, y);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que agrega el total de venta al ticket
        /// </summary>
        /// <param name="e"></param>
        /// <param name="dt">DataTable con la información de venta.</param>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void AgregarTotalVenta(ref PrintPageEventArgs e, DataTable dt)
        {
            try
            {
                decimal total = 0;
                total = decimal.Parse(dt.Rows[0]["total"].ToString());
                y += saltoLinea / 2;
                e.Graphics.DrawString("TOTAL: ", fuenteNormal, Brushes.Black, (e.PageBounds.Width / 4) * 3 - 20 - e.Graphics.MeasureString("TOTAL: ", fuenteNormal).Width, y);
                e.Graphics.DrawString(total.ToString("C2"), fuenteNormal, Brushes.Black, (e.PageBounds.Width / 4) * 3 - 20, y);
                y += saltoLinea * 3 / 2;

                string tot = Clases.CFuncionesGenerales.ConvertirNumeroLetra(total.ToString());
                CentrarTexto(ref e, tot, fuentePequeña, Brushes.Black);
                y += saltoLinea;
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que agrega los datos del miembro al ticket
        /// </summary>
        /// <param name="e"></param>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void AgregarDatosMembresia(ref PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString("NOMBRE DEL SOCIO: \n" + ObtenerNombreSocio(numSoc).ToUpper(), fuenteNormal, Brushes.Black, 0, y);
                y += (saltoLinea * 2);
                e.Graphics.DrawString("NÚM. SOCIO: " + ObtenerDatoDataTableMembresia("numSocio").ToString(), fuenteNormal, Brushes.Black, 0, y);
                y += saltoLinea + 5;
                e.Graphics.DrawString("INICIO: " + DateTime.Parse(ObtenerDatoDataTableMembresia("fecha_ini").ToString()).ToString("dd/MM/yyyy"), fuenteNormal, Brushes.Black, 0, y);
                e.Graphics.DrawString("FIN: " + DateTime.Parse(ObtenerDatoDataTableMembresia("fecha_fin").ToString()).ToString("dd/MM/yyyy"), fuenteNormal, Brushes.Black, e.PageBounds.Width / 2, y);
                y += saltoLinea;
                e.Graphics.DrawString("TOTAL: " + decimal.Parse(ObtenerDatoDataTableMembresia("precio").ToString()).ToString("C2"), fuenteNormal, Brushes.Black, 0, y);
                e.Graphics.DrawString("FOLIO: " + ObtenerDatoDataTableMembresia("folio_remision").ToString(), fuenteNormal, Brushes.Black, e.PageBounds.Width / 2, y);
                y += saltoLinea;
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AgregarDatosLocker(ref PrintPageEventArgs e)
        {
            try
            {
                DateTime fechaIni = (DateTime)ObtenerDatoDataTableLocker("fecha_ini"), 
                    fechaFin = (DateTime)ObtenerDatoDataTableLocker("fecha_fin");
                string tipoPago = "";
                if (ObtenerDatoDataTableLocker("tipo_pago").ToString() == "0")
                    tipoPago = "EFECTIVO";
                else
                    tipoPago = "TARJETA DE CRÉDITO";

                if (ObtenerDatoDataTableLocker("nom_persona") != DBNull.Value)
                    e.Graphics.DrawString("NOMBRE DE SOCIO: " + ObtenerDatoDataTableLocker("nom_persona"), fuenteNormal, Brushes.Black, 0, y);
                else
                    e.Graphics.DrawString("NOMBRE DE SOCIO: " + ObtenerNombreSocio((int)ObtenerDatoDataTableLocker("numSocio")), fuenteNormal, Brushes.Black, 0, y);
                y += saltoLinea;
                e.Graphics.DrawString("INICIA: " + fechaIni.ToString("dd") + " de " + fechaIni.ToString("MMMM") + " del " + fechaIni.ToString("yyyy"), fuenteNormal, Brushes.Black, 0, y);
                y += saltoLinea;
                e.Graphics.DrawString("TERMINA: " + fechaFin.ToString("dd") + " de " + fechaFin.ToString("MMMM") + " del " + fechaFin.ToString("yyyy"), fuenteNormal, Brushes.Black, 0, y);
                y += saltoLinea;
                e.Graphics.DrawString("PRECIO: " + ((decimal)ObtenerDatoDataTableLocker("precio")).ToString("C2"), fuenteNormal, Brushes.Black, 0, y);
                y += saltoLinea;
                e.Graphics.DrawString("SE PAGO CON: " + tipoPago, fuenteNormal, Brushes.Black, 0, y);
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que agrega los datos del cierre de caja
        /// </summary>
        /// <param name="e"></param>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void AgregarDatosCierreCaja(ref PrintPageEventArgs e)
        {
            try
            {
                decimal totTa = 0M;
                decimal efRet = 0M, efAp = 0M;
                int nuevaMembresia = 0, renovacionMembresia = 0, ventaMostrador = 0;
                decimal totEfMem = 0M, totTaMem = 0M, totEfRen = 0M, totTaRen = 0M, totEfVen = 0M, totTaVen = 0M, totEnt = 0M, totSal = 0M;
                foreach (DataRow dr in dtCaja.Rows)
                {
                    string efe, tar;
                    decimal ef = decimal.Parse(dr["efectivo"].ToString());
                    decimal ta = decimal.Parse(dr["tarjeta"].ToString());
                    DateTime fe = DateTime.Parse(dr["fecha"].ToString());
                    string tipoMov = "";
                    if (dr["tipo_movimiento"].ToString() == "0")
                        tipoMov = "ENTRADA";
                    else
                        tipoMov = "SALIDA";
                    if (ef < 0)
                        efe = (ef * -1).ToString("C2");
                    else
                        efe = ef.ToString("C2");
                    if (ta < 0)
                        tar = (ta * -1).ToString("C2");
                    else
                        tar = ta.ToString("C2");

                    //e.Graphics.DrawString(efe, fuentePequeña, Brushes.Black, 0F, y);
                    //e.Graphics.DrawString(tar, fuentePequeña, Brushes.Black, (e.PageBounds.Width / 4) - 15, y);
                    //e.Graphics.DrawString(tipoMov, fuentePequeña, Brushes.Black, (e.PageBounds.Width / 4) * 2 - 25, y);
                    //e.Graphics.DrawString(fe.ToString("dd/MM/yyyy"), fuentePequeña, Brushes.Black, (e.PageBounds.Width / 4) * 3 - 25, y);
                    if (ta > 0)
                        totTa += ta;
                    //y += saltoLinea;
                    //e.Graphics.DrawString(dr["descripcion"].ToString(), fuentePequeña, Brushes.Black, 0F, y);
                    //y += saltoLinea;
                    //AgregarLinea(ref e, new Pen(Brushes.Black));

                    if (dr["descripcion"].ToString()=="CIERRE DE CAJA")
                    {
                         efRet = ef;
                    }
                    else if (dr["descripcion"].ToString()=="APERTURA DE CAJA")
	                {
		                    efAp = ef;
	                }
                    else if (dr["descripcion"].ToString().Contains("NUEVA MEMBRESÍA"))
                    {
                            totEfMem += ef;
                            totTaMem += ta;
                            nuevaMembresia++;
                    }
                    else if (dr["descripcion"].ToString().Contains("RENOVACIÓN DE MEMBRESÍA"))
                    {
                            totEfRen += ef;
                            totTaRen += ta;
                        renovacionMembresia++;
                    }
                    else if (dr["descripcion"].ToString().Contains("VENTA POS"))
                    {
                            totEfVen += ef;
                            totTaVen += ta;
                    }
                    else if (dr["descripcion"].ToString().Contains("VENTA DE MOSTRADOR"))
                    {
                            totEfVen += ef;
                            totTaVen += ta;
                    }
                    else if (dr["descripcion"].ToString().Contains("VENTA MOSTRADOR"))
                    {
                        totEfVen += ef;
                        totTaVen += ta;
                        ventaMostrador++;
                    }
                    else
                    {
                           if (ef < 0)
                                totSal += ef;
                            else
                                totEnt += ef;
                    }
                    
                }
                e.Graphics.DrawString("CERRÓ CAJA: " + UsuarioCierre(), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("EFECTIVO APERTURA: " + (efAp).ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                AgregarLinea(ref e, new Pen(Brushes.Black));
                y += saltoLineaPeque;

                //Totales de membresías
                e.Graphics.DrawString("TOTAL NUEVAS MEMBRESÍAS", fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("EFECTIVO: " + totEfMem.ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("VOUCHERS: " + totTaMem.ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("MEMBRESIAS NUEVAS: " + nuevaMembresia, fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                AgregarLinea(ref e, new Pen(Brushes.Black));
                y += saltoLineaPeque;
                //Totales de renovaciones
                e.Graphics.DrawString("TOTAL RENOVACIÓN DE MEMBRESÍAS", fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("EFECTIVO: " + totEfRen.ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("VOUCHERS: " + totTaRen.ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("MEMBRESÍAS RENOVADAS: " + renovacionMembresia, fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                AgregarLinea(ref e, new Pen(Brushes.Black));
                y += saltoLineaPeque;
                //Totales de ventas
                e.Graphics.DrawString("TOTAL DE VENTAS MOSTRADOR", fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("EFECTIVO: " + totEfVen.ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("VOUCHERS: " + totTaVen.ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                AgregarLinea(ref e, new Pen(Brushes.Black));
                y += saltoLineaPeque;

                //Entradas y salidas
                e.Graphics.DrawString("OTROS CONCEPTOS", fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("TOTAL DE ENTRADAS: " + totEnt.ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("TOTAL DE SALIDAS: " + totSal.ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                AgregarLinea(ref e, new Pen(Brushes.Black));
                y += saltoLineaPeque;

                e.Graphics.DrawString("EFECTIVO RETIRADO: " + (efRet * -1).ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                e.Graphics.DrawString("TOTAL DE VOUCHERS: " + totTa.ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                y += saltoLinea;
                if (!esCierreCaja)
                {
                    e.Graphics.DrawString("EFECTIVO EN CAJA: " + TotalCajaCorte().ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                }
                else
                {
                    e.Graphics.DrawString("EFECTIVO EN CAJA: " + TotalCaja().ToString("C2"), fuenteResaltada, Brushes.Black, 0F, y);
                }
                y += saltoLinea;
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que agrega el código de barras de un producto al ticket
        /// </summary>
        /// <param name="e"></param>
        /// <param name="idProd">ID del producto a agregar</param>
        /// <exception cref="System.OverflowException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void AgregarCodigoBarrasProducto(ref PrintPageEventArgs e, string idProd)
        {
            try
            {
                int salto;
                e.Graphics.DrawString("PRODUCTO: " + ObtenerNombreProducto(idProd), fuenteGrande, Brushes.Black, 0, y);
                y += 30;
                CentrarTexto(ref e, "*" + idProd.ToString() + "*", new Font("IDAutomationHC39M", 10), Brushes.Black);
                salto = Convert.ToInt32(e.Graphics.MeasureString(idProd.ToString(), new Font("IDAutomationHC39M", 10)).Height - 10);
                y += salto;
                e.Graphics.FillRectangle(Brushes.White, 0, y, e.PageBounds.Width, 10);
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que centra el texto en el ticket
        /// </summary>
        /// <param name="e"></param>
        /// <param name="texto">Texto a centrar</param>
        /// <param name="f">Fuente a usar</param>
        /// <param name="b">Color del texto</param>
        /// <exception cref="System.ArgumentNull"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void CentrarTexto(ref PrintPageEventArgs e, string texto, Font f, Brush b)
        {
            try
            {
                float x = ((e.PageBounds.Width - e.Graphics.MeasureString(texto, f).Width) / 2);
                e.Graphics.DrawString(texto, f, b, x, y);
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que dibuja una linea en la posición actual de dibujado del ticket
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p">Color de la linea</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void AgregarLinea(ref PrintPageEventArgs e, Pen p)
        {
            try
            {
                y += 2;
                e.Graphics.DrawLine(p, 10, y, e.PageBounds.Width - 10, y);
                y += 5;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Consultas
        /// <summary>
        /// Función que obtiene el nombre del producto en la base de datos
        /// </summary>
        /// <param name="idProd">ID del producto</param>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException"></exception>
        /// <exception cref="System.Exception"></exception>
        /// <returns>Nombre del producto</returns>
        private string ObtenerNombreProducto(string idProd)
        {
            string nom = "";
            try
            {
                string sql = "SELECT nombre FROM producto WHERE id='" + idProd.ToString() + "'";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    nom = dr["nombre"].ToString();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nom;
        }

        /// <summary>
        /// Función que obtiene el precio de un producto de la base de datos
        /// </summary>
        /// <param name="idProd">ID del producto</param>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.Exception"></exception>
        /// <returns>Precio del producto</returns>
        private decimal ObtenerPrecioProducto(string idProd)
        {
            decimal precio = 0;
            try
            {
                string sql = "SELECT precio FROM producto WHERE id='" + idProd.ToString() + "'";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    precio = decimal.Parse(dr["precio"].ToString());
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return precio;
        }

        /// <summary>
        /// Función que obtiene el nombre del usuario de la base de datos
        /// </summary>
        /// <param name="idUsu">ID del usuario</param>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException"></exception>
        /// <exception cref="System.Exception"></exception>
        /// <returns>Nombre del usuario</returns>
        private string ObtenerNombreUsuario(int idUsu)
        {
            string nom = "";
            try
            {
                string sql = "SELECT userName FROM usuarios WHERE id='" + idUsu.ToString() + "'";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    nom = dr["userName"].ToString();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nom;
        }

        /// <summary>
        /// Función que obtiene el nombre del socio de la base de datos
        /// </summary>
        /// <param name="idSoc">Número de socio</param>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException"></exception>
        /// <exception cref="System.Exception"></exception>
        /// <returns>Nombre del socio</returns>
        private string ObtenerNombreSocio(int idSoc)
        {
            string nom = "";
            try
            {
                string sql = "SELECT nombre, apellidos FROM miembros WHERE numSocio = '" + idSoc.ToString() + "'";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    nom = dr["nombre"].ToString() + " " + dr["apellidos"].ToString();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nom;
        }

        /// <summary>
        /// Función que obtiene el total de efectivo en caja
        /// </summary>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException"></exception>
        /// <exception cref="System.FormatException"></exception>
        /// <exception cref="System.OverflowException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.Exception"></exception>
        /// <returns>Total de efectivo en caja</returns>
        private decimal TotalCaja()
        {
            decimal totEfe = 0;
            try
            {
                string sql = "SELECT SUM(efectivo) AS ef FROM caja";
                DataTable dt = Clases.ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                    totEfe = decimal.Parse(dr["ef"].ToString());
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return totEfe;
        }

        /// <summary>
        /// Función que obtiene todos los datos de la venta con el folio especificado
        /// </summary>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void ObtenerDatosVenta()
        {
            try
            {
                string sql = "SELECT * FROM venta WHERE id='" + folio.ToString() + "'";
                dtVenta = Clases.ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que obtiene todos los datos de la venta detallada de la base de datos
        /// </summary>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void ObtenerDatosVentaDetallada()
        {
            try
            {
                string sql = "SELECT * FROM venta_detallada WHERE id_venta='" + folio.ToString() + "'";
                dtVentaDetallada = Clases.ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que obtiene los datos de la membresía del socio especificado
        /// </summary>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void ObtenerDatosMembresia()
        {
            try
            {
                string sql = "SELECT m.numSocio, m.fecha_ini, m.fecha_fin, r.tipo, r.precio, r.folio_remision FROM membresias AS m INNER JOIN registro_membresias AS r ON (m.id=r.membresia_id) WHERE m.numSocio = '" + numSoc + "' ORDER BY r.id DESC LIMIT 1";
                dtMembresia = Clases.ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que obtiene los datos de la caja para el cierre
        /// </summary>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void ObtenerDatosCaja()
        {
            try
            {
                string sql = "SELECT * FROM caja WHERE id BETWEEN (SELECT MAX(id) FROM caja WHERE descripcion='APERTURA DE CAJA') AND (SELECT MAX(id) FROM caja WHERE descripcion='CIERRE DE CAJA')";
                dtCaja = Clases.ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que obtiene los datos de la caja de un cierre pasado
        /// </summary>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException"></exception>
        private void ObtenerDatosCorteCaja()
        {
            try
            {
                string sql = "SELECT * FROM caja WHERE id BETWEEN '" + idApertura + "' AND '" + idCierre + "'";
                dtCaja = Clases.ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que obtiene el total de caja al momento del corte efectuado.
        /// </summary>
        /// <returns>Total de caja en el momento en el que se presento el corte.</returns>
        private decimal TotalCajaCorte()
        {
            decimal total = 0M;
            try
            {
                string sql = "SELECT SUM(efectivo) AS efe FROM caja WHERE id BETWEEN '1' AND '" + idCierre + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    total = (decimal)dr["efe"];
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return total;
        }

        private string UsuarioCierre()
        {
            string usu = "Sin información";
            try
            {
                string sql = "SELECT u.userName FROM caja AS c INNER JOIN usuarios AS u ON (c.create_user_id=u.id) WHERE c.id='" + idCierre + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["userName"] != DBNull.Value)
                        usu = dr["userName"].ToString();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usu;
        }

        /// <summary>
        /// Función que obtiene todos los datos del locker
        /// </summary>
        private void ObtenerDatosLocker()
        {
            try
            {
                string sql = "SELECT r.*, l.numSocio FROM registro_locker AS r INNER JOIN locker AS l ON (r.locker_id=l.id) WHERE locker_id='" + idLocker + "' GROUP BY id DESC LIMIT 1";
                dtLocker = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
