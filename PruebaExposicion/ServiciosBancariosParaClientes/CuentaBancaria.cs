using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancariosParaClientes
{
    public class CuentaBancaria
    {
        private double balance { get; set; }

        public CuentaBancaria(double balanceInicial)
        {
            this.balance = balanceInicial;
        }

        public void Depositar(double cantidad)
        {
            this.balance += cantidad;
        }

        public bool Retirar(double cantidad)
        {
            if (this.balance >= cantidad)
            {
                this.balance -= cantidad;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double ObtenerBalance()
        {
            return this.balance;
        }
    }
}
