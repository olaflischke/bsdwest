using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EierfarmDal
{
    public class Huhn : IEileger
    {
        public string Name { get; set; }

        [Key]
        public int Id { get; set; }
        public double Gewicht { get; set; }

        [InverseProperty("Mutter")]
        public List<Ei> Eier { get; set; } = new();

        public Ei EiLegen()
        {
            if (this.Gewicht > 1000)
            {
                Ei ei = new Ei(this);
                this.Eier.Add(ei);
                this.Gewicht -= ei.Gewicht;
                return ei;
            }

            return null;
        }
    }
}
