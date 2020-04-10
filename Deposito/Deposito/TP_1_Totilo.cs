using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito
{
    public class Deposito
    {
        public int IDdeposito { get; set; }
        public string Denominacion { get; set; }
        public string Ubicacion { get; set; }
        public float Capacidad { get; set; }
        public Pasillo pasillo { get; set; }
    }

    public class Pasillo
    {
        public int IDpasillo { get; set; }
        public string Denominacion { get; set; }
        public Lado lado { get; set; }
        public Cliente cliente { get; set; }
    }

    public class Lado
    {
        public int IDlado { get; set; }
        public string Denominacion { get; set; }
        public Compartimiento compartimento { get; set; }
        public Cliente cliente { get; set; }
    }

    public class Compartimiento
    {
        public int IDcompartimiento { get; set; }
        public string TipoProducto { get; set; }
        public float Capacidad { get; set; }
        public Lote lote { get; set; }
    }

    public class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public Contacto contacto { get; set; }

    }

    public class Empleado : Persona
    {
        public int Legajo { get; set; }
        public string Categoria { get; set; }

    }

    public class Cliente : Persona
    {
        public int IDcliente { get; set; }
        public Empleado empresa { get; set; }
    }

    public class Empresa
    {
        public int IDempresa { get; set; }
        public string RazonSocial { get; set; }
        public Contacto contacto { get; set; }
    }

    public class Lote
    {
        public string Denominacion { get; set; }
        public int NumeroLote { get; set; }
        public Remito remito { get; set; }
    }

    public class Contacto
    {
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
    }

    public class Remito
    {
        public int IDremito { get; set; }
        public Cliente cliente { get; set; }
        public DateTime FechaEmision { get; set; }
        public float Cantidad { get; set; }
        public float Precio { get; set; }
    }
}


