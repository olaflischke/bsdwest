using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmDal
{
    public class Ente:IEileger
    {
        public string Name { get; set; }
        public double Gewicht { get; set; }
        public List<Ei> Eier { get; set; }

        public Ei EiLegen()
        {
            Ei ei = new Ei(this);
            return ei;
        }
    }
}
