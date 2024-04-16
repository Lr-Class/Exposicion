using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancariosParaClientes
{
    public class Cliente
    {
        private string nombre { get; set; }



        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }



        public string ObtenerNombre()
        {
            return this.nombre;
        }

        public void EstablecerNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }
    }
}
