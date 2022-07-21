using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EierfarmDal
{
    public class Ei
    {
        public Ei()
        {

        }

        public Ei(Huhn mutter)
        {
            Random random = new();
            this.Gewicht = random.Next(45, 81);
            this.Farbe = (EiFarbe)random.Next(Enum.GetNames(typeof(EiFarbe)).Length);
            this.Mutter = mutter;
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("Eier")]
        public Huhn Mutter { get; set; }

        public int MutterId { get; set; }
        public double Gewicht { get; set; }
        public EiFarbe Farbe { get; set; }
    }

    public enum EiFarbe
    {
        Hell,
        Dunkel,
        Gruen
    }
}