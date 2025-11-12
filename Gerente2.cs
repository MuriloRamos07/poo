using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Gerente2 : Empregado
    {
        private string area;
        public string Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
    }
}

