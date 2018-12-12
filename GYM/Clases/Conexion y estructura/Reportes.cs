using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using Fuente = iTextSharp.text.Font;

namespace GYM.Clases
{
    class Reportes
    {

        Fuente fChica = new Fuente(Fuente.FontFamily.HELVETICA, 9F, Fuente.NORMAL, BaseColor.BLACK);
        Fuente fNormal = new Fuente(Fuente.FontFamily.HELVETICA, 12F, Fuente.NORMAL, BaseColor.BLACK);
        Fuente fGrande = new Fuente(Fuente.FontFamily.HELVETICA, 15F, Fuente.NORMAL, BaseColor.BLACK);



        #region Propiedades
        private TipoReporte tipo;
        private string titulo;
        private int idS;
        private string sucursal;
        DataTable dtCaja;
        private string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        int idApertura;
        int idCierre;

        public TipoReporte Tipo_Reporte
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int IDSucursal
        {
            get { return idS; }
            set { idS = value; }
        }
        #endregion



        private FileStream CrearRutaTCP(string nombre)
        {
            if (!Directory.Exists(ruta + "\\Reportes HS FIT"))
            {
                ruta += "\\Reportes HS FIT";
                Directory.CreateDirectory(ruta);
            }
            else
            {
                ruta += "\\Reportes HS FIT";
            }
            if (!Directory.Exists(ruta + "\\" + tipo.ToString()))
            {
                ruta += "\\" + tipo.ToString();
                Directory.CreateDirectory(ruta);
            }
            else
            {
                ruta += "\\" + tipo.ToString();
            }

            if (!Directory.Exists(ruta + "\\" + nombre))
            {
                ruta += "\\" + nombre;
                Directory.CreateDirectory(ruta);
            }
            else
            {
                ruta += "\\" + nombre;
            }

            if (!Directory.Exists(ruta + "\\" + DateTime.Now.Year.ToString()))
            {
                ruta += "\\" + DateTime.Now.Year.ToString();
                Directory.CreateDirectory(ruta);
            }
            else
            {
                ruta += "\\" + DateTime.Now.Year.ToString();
            }
            if (!Directory.Exists(ruta + "\\" + DateTime.Now.Month.ToString()))
            {
                ruta += "\\" + DateTime.Now.ToString("MMMM");
                Directory.CreateDirectory(ruta);
            }
            else
            {
                ruta += "\\" + DateTime.Now.ToString("MMMM");
            }

                FileStream stream = new FileStream(ruta + @"\"+ tipo.ToString() + " " + sucursal + " " + DateTime.Now.ToString("dd-MM-yyyy H mm ss") + ".pdf", FileMode.Create);
                ruta += @"\" + tipo.ToString() + " " + sucursal + " " + DateTime.Now.ToString("dd-MM-yyyy H mm ss") + ".pdf";
                return stream;
            
        }

        private FileStream CrearRuta()
        {
            if (!Directory.Exists(ruta + "\\Reportes HS FIT"))
            {
                ruta += "\\Reportes HS FIT";
                Directory.CreateDirectory(ruta);
            }
            else
            {
                ruta += "\\Reportes HS FIT";
            }
            if (!Directory.Exists(ruta + "\\" +tipo.ToString()))
            {
                ruta += "\\" + tipo.ToString();
                Directory.CreateDirectory(ruta);
            }
            else
            {
                ruta += "\\" + tipo.ToString();
            }
            if (!Directory.Exists(ruta + "\\" + DateTime.Now.Year.ToString()))
            {
                ruta += "\\" + DateTime.Now.Year.ToString();
                Directory.CreateDirectory(ruta);
            }
            else
            {
                ruta += "\\" + DateTime.Now.Year.ToString();
            }
            if (!Directory.Exists(ruta + "\\" + DateTime.Now.Month.ToString()))
            {
                ruta += "\\" + DateTime.Now.ToString("MMMM");
                Directory.CreateDirectory(ruta);
            }
            else
            {
                ruta += "\\" + DateTime.Now.ToString("MMMM");
            }
            FileStream stream = new FileStream(ruta + @"\" +tipo.ToString() + " " + sucursal + " " + DateTime.Now.ToString("dd-MM-yyyy H mm ss") + ".pdf", FileMode.Create);
            ruta += @"\" + tipo.ToString() + " " + sucursal + " " + DateTime.Now.ToString("dd-MM-yyyy H mm ss") + ".pdf";
            return stream;
        }

        private Paragraph CrearParrafo(string texto, int alineacion, Fuente fuente)
        {
            Paragraph parrafo = new Paragraph();
            parrafo.Add(texto);
            parrafo.Alignment = alineacion;
            parrafo.Font = fuente;
            return parrafo;
        }

        private PdfPTable CrearTabla(int columnas, int borde, List<PdfPCell> celdas)
        {
            PdfPTable tabla = new PdfPTable(columnas);
            tabla.DefaultCell.Border = borde;
            tabla.WidthPercentage = 100;
            for (int i = 0; i < celdas.Count; i++)
            {
                tabla.AddCell(celdas[i]);
            }
            return tabla;
        }

        private PdfPTable CrearTabla(int columnas, float[] anchosDeColumnas, int borde, List<PdfPCell> celdas)
        {
            PdfPTable tabla = new PdfPTable(columnas);
            tabla.DefaultCell.Border = borde;
            tabla.WidthPercentage = 100;
            tabla.SetWidths(anchosDeColumnas);
            for (int i = 0; i < celdas.Count; i++)
            {
                tabla.AddCell(celdas[i]);
            }
            return tabla;
        }



        /// <summary>
        /// Metodo para generar reportes de ventas y compras.
        /// </summary>
        /// <param name="fechaInicio">Inicio del periodo</param>
        /// <param name="fechaFin">Fin del periodo</param>
        /// <param name="total">Total de ventas-compras</param>
        /// <param name="totalEfectivo">Total en efectivo de ventas-compras</param>
        /// <param name="totalVoucher">Total en voucher de ventas-compras</param>
        /// <param name="movimientos">Total de movimientos</param>
        /// <param name="datos">DataGridView con los datos</param>
        public void GenerarReporte(int idApertura, int idCierre)
        {
            try
            {
                this.idApertura = idApertura;
                this.idCierre = idCierre;
                dtCaja = new DataTable();
                ObtenerDatosCorteCaja();
  
                //Creacion del documento añadiendo titulo y fuente
                Document doc = new Document(PageSize.LETTER);
                PdfWriter writer = PdfWriter.GetInstance(doc, CrearRuta());
                doc.AddTitle("Reporte de cierre de caja");
                doc.AddCreator("HS FIT ");
                doc.Open();
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //Añade el titulo
                Paragraph title = new Paragraph();
                title.Add("Reporte de cierre de caja");
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                title.Clear();


        
                decimal totTa = 0M;
                decimal efRet = 0M, efAp = 0M;
                int nuevaMembresia = 0, renovacionMembresia = 0, ventaMostrador = 0;
                decimal totEfMem = 0M, totTaMem = 0M, totEfRen = 0M, totTaRen = 0M, totEfVen = 0M, totTaVen = 0M, totEnt = 0M, totSal = 0M;
                DateTime fe = DateTime.Now;
                foreach (DataRow dr in dtCaja.Rows)
                {
                    string efe, tar;
                    decimal ef = decimal.Parse(dr["efectivo"].ToString());
                    decimal ta = decimal.Parse(dr["tarjeta"].ToString());
                    fe = DateTime.Parse(dr["fecha"].ToString());
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
                    if (ta > 0)
                        totTa += ta;

                    if (dr["descripcion"].ToString() == "CIERRE DE CAJA")
                    {
                        efRet = ef;
                    }
                    else if (dr["descripcion"].ToString() == "APERTURA DE CAJA")
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

                       //Añadir el periodo de fechas
                Paragraph periodo = new Paragraph();
                periodo.Add("Corte del día "+fe.ToString());
                periodo.Alignment = Element.ALIGN_CENTER;
                doc.Add(periodo);
                periodo.Clear();
                doc.Add(Chunk.NEWLINE);


                //Añadir informacion general
                PdfPTable infoReporte = new PdfPTable(2);
                infoReporte.WidthPercentage = 100;
                infoReporte.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                PdfPCell cell3 = new PdfPCell();
                cell3.Colspan = 2;
                infoReporte.AddCell(cell3);
                infoReporte.AddCell("Fecha de realización: " + System.DateTime.Now.ToLongDateString());
                infoReporte.AddCell("Realizado por: " + Usuario.ObtenerNombreUsuario(frmMain.id));
                infoReporte.AddCell("");
                doc.Add(infoReporte);
                doc.Add(Chunk.NEWLINE);




                //Añadir informacion especifica
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                PdfPCell cell2 = new PdfPCell();
                cell2.Colspan = 2;
                table.AddCell(cell2);
                table.AddCell("Ventas en efectivo: " + totEfVen.ToString("C2"));
                table.AddCell("Ventas con tarjeta: " + totTaVen.ToString("C2"));
                decimal totalmembresia=totEfRen+totEfMem;
                decimal totalmembresiasTarjeta = totTaRen + totTaMem;
                table.AddCell("Venta de membresías efectivo:" +totalmembresia.ToString("C2"));
                table.AddCell("Venta de membresías tarjeta: " +totalmembresiasTarjeta.ToString("C2"));
                table.AddCell("Entradas: " + totEnt.ToString("C2"));
                table.AddCell("Salidas: " + totSal.ToString("C2"));
                table.AddCell("Membresiás Nuevas: " + nuevaMembresia);
                table.AddCell("Membresías Renovadas: " + renovacionMembresia);
                table.AddCell("Efectivo retirado: " + (efRet * -1).ToString("C2"));
                table.AddCell("Voucher retirado: " + totTa.ToString("C2"));



                table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                doc.Add(table);
                doc.Add(Chunk.NEWLINE);

                //Añadir datos del DataGridView
                PdfPTable pdfTable = new PdfPTable(dtCaja.Columns.Count - 3);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.DefaultCell.BorderWidth = .5f;
                var colWidthPercentages = new[] { 4f, 6f, 5f, 5f, 5f, 8f,5f };
                pdfTable.SetWidths(colWidthPercentages);

                

                foreach (DataColumn column in dtCaja.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName.ToString()));
                    cell.Column.Alignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(230, 230, 240);
                    if (column.ColumnName.ToString() =="id")
                    {
                        pdfTable.AddCell("Folio");
                    }
                    else if (column.ColumnName.ToString() == "fecha")
                    {
                        pdfTable.AddCell("Fecha");
                    }
                    else if (column.ColumnName.ToString() == "efectivo")
                    {
                        pdfTable.AddCell("Efectivo");
                    }
                    else if (column.ColumnName.ToString() == "tarjeta")
                    {
                        pdfTable.AddCell("Tarjeta");
                    }
                    else if (column.ColumnName.ToString() == "tipo_movimiento")
                    {
                        pdfTable.AddCell("Movimiento");
                    }
                    else if (column.ColumnName.ToString() == "descripcion")
                    {
                        pdfTable.AddCell("Descripción");
                    }
                    else if (column.ColumnName.ToString() == "create_user_id")
                    {
                        pdfTable.AddCell("Registró");
                    }
                    
                }

                foreach (DataRow row in dtCaja.Rows)
                {
                    pdfTable.AddCell(row["id"].ToString());
                    DateTime fecha = (DateTime)row["fecha"];
                    pdfTable.AddCell(fecha.ToShortDateString());
                    decimal tot = (decimal)row["efectivo"];
                    pdfTable.AddCell(tot.ToString("C2"));
                    decimal tarjeta = (decimal)row["tarjeta"];
                    pdfTable.AddCell(tarjeta.ToString("C2"));
                    if (row["tipo_movimiento"].ToString()=="0")
                        pdfTable.AddCell("Entrada");
                    else
                        pdfTable.AddCell("Salida");
                    pdfTable.AddCell(row["descripcion"].ToString());

                    pdfTable.AddCell(Usuario.ObtenerNombreUsuario((int)row["create_user_id"]));

                  
                }

                
                doc.Add(pdfTable);
                doc.Close();
                writer.Close();
                Process.Start(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        /// Metodo para generar el reporte de inventario.
        /// </summary>
        /// <param name="inversion">Inversion del inventario</param>
        /// <param name="cantidadProductos">Cantidad total de piezas en productos</param>
        /// <param name="productosMostrados">Productos que se muestran</param>
        /// <param name="datos">Datos del DataGridView</param>
        //public void GenerarReporte(string inversion, string cantidadProductos, string productosMostrados, DataGridView datos)
        //{
        //    try
        //    {
        //        //Creacion del documento añadiendo titulo y fuente
        //        Document doc = new Document(PageSize.LETTER);
        //        PdfWriter writer = PdfWriter.GetInstance(doc, CrearRuta());
        //        doc.AddTitle(titulo);
        //        doc.AddCreator("AdminCSY ");
        //        doc.Open();
        //        iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

        //        //Añade el titulo
        //        Paragraph title = new Paragraph();
        //        title.Add(titulo);
        //        title.Alignment = Element.ALIGN_CENTER;
        //        doc.Add(title);
        //        title.Clear();
        //        doc.Add(Chunk.NEWLINE);


        //        //Añadir informacion general
        //        PdfPTable infoReporte = new PdfPTable(2);
        //        infoReporte.WidthPercentage = 100;
        //        infoReporte.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
        //        PdfPCell cell3 = new PdfPCell();
        //        cell3.Colspan = 2;
        //        infoReporte.AddCell(cell3);
        //        infoReporte.AddCell("Fecha: " + System.DateTime.Now.ToLongDateString());
        //        infoReporte.AddCell("Realizado por: " + Usuario.ObtenerNombreUsuario(Usuario.IDUsuarioActual));
        //        infoReporte.AddCell("");
        //        doc.Add(infoReporte);
        //        doc.Add(Chunk.NEWLINE);

        //        //Añadir informacion especifica
        //        PdfPTable table = new PdfPTable(2);
        //        table.WidthPercentage = 100;
        //        table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
        //        PdfPCell cell2 = new PdfPCell();
        //        cell2.Colspan = 2;
        //        table.AddCell(cell2);
        //        table.AddCell("Cantidad de productos: " + cantidadProductos);
        //        table.AddCell("Productos mostrados: " + productosMostrados);
        //        table.AddCell("");
        //        table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
        //        doc.Add(table);
        //        doc.Add(Chunk.NEWLINE);

        //        //Añadir datos del DataGridView
        //        PdfPTable pdfTable = new PdfPTable(datos.ColumnCount - 1);
        //        pdfTable.DefaultCell.Padding = 3;
        //        pdfTable.WidthPercentage = 100;
        //        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
        //        pdfTable.DefaultCell.BorderWidth = .5f;
        //        var colWidthPercentages = new[] { 4f, 5f, 6f, 7f, 4f, 7f };
        //        pdfTable.SetWidths(colWidthPercentages);

        //        foreach (DataGridViewColumn column in datos.Columns)
        //        {
        //            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
        //            cell.Column.Alignment = Element.ALIGN_CENTER;
        //            cell.BackgroundColor = new iTextSharp.text.BaseColor(230, 230, 240);
        //            if (column.Index != 0)
        //            {
        //                pdfTable.AddCell(cell);
        //            }

        //        }

        //        foreach (DataGridViewRow row in datos.Rows)
        //        {
        //            foreach (DataGridViewCell cell in row.Cells)
        //            {
        //                if (cell.ColumnIndex != 0)
        //                {
        //                    pdfTable.AddCell(cell.Value.ToString());
        //                }
        //            }
        //        }
        //        doc.Add(pdfTable);
        //        doc.Close();
        //        writer.Close();

        //        doc.Dispose();
        //        Process.Start(ruta);
                            
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
    
    }
}





