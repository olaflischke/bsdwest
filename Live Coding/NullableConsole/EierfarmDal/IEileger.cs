using System.Collections.Generic;

namespace EierfarmDal
{
    public interface IEileger
    {
        List<Ei> Eier { get; set; }
        double Gewicht { get; set; }
        string Name { get; set; }

        Ei EiLegen();
    }
}