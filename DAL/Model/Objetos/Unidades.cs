using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class Unidades : IEquatable<Unidades>
    {
        public string Nome { get; set; }
        public string idFilial { get; set; }

        public Unidades(string nome, string idFilial)
        {
            Nome = nome;
            this.idFilial = idFilial;
        }
        public bool Equals(Unidades u)
        {
            return this.Nome == u.Nome && this.idFilial == u.idFilial;
        }
    }
}
