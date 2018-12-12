namespace GYM
{
        public enum Duracion
        {
            Semanal = 0,
            Mensual = 1,
            Trimestral = 2,
            CuatroMeses = 3,
            Transferencia = 4,
            Mixto = 5,
            Deposito = 6,
            Boveda = 7,

        }

    public enum TipoPago
    {
        Efectivo = 0,
        Cheque = 1,
        Crédito = 2,
        Débito = 3,
        Transferencia = 4,
        Mixto = 5,
        Deposito = 6,
        Boveda = 7
    }

    public enum TipoCuenta
    {
        Sucursal = 0,
        Cliente = 1,
        Proveedor = 2
    }

    public enum Mensajes
        {
            Exito = 0,
            Informativo = 1,
            Alerta = 2,
            Error = 3,
            Pregunta = 4
        }

        public enum TipoReporte
        {
            Caja=0,
        }

}
