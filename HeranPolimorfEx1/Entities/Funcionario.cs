using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeranPolimorfEx1.Entities
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; protected set; }
        public List<Funcionario> funcionarios { get; set; } = new List<Funcionario>();

        public Funcionario() { } 
        public Funcionario(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento() {
            return Horas * ValorPorHora;
        }

        public override string ToString()
        {
            return Nome + " - $ " + Pagamento().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
