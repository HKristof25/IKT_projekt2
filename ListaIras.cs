using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Alkatreszek
{
    internal class ListaIras
    {
        object elso;
        object masodik;
        object harmadik;
        object negyedik;
        object otodik;

        public ListaIras(object elso, object masodik, object harmadik, object negyedik, object otodik )
        {
            this.elso = elso;
            this.masodik = masodik;
            this.harmadik = harmadik;
            this.negyedik = negyedik; 
            this.otodik = otodik;
        }
        public object Elso { get => elso; }
        public object  Masodik { get => masodik; }
        public object Harmadik { get => harmadik; }
        public object Negyedik { get => negyedik; set => negyedik = value; }
        public object Otodik{ get => otodik; set => otodik = value; }

    }
}
