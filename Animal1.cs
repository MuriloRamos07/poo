using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Animal1
    {
        public string nome;
        public string especie;

        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal está emitindo SOM!");
        }
    }
}
