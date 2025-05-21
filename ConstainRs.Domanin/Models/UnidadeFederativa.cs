using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainRs.Domain.Models
{   
    public static class  UFStringConverter{
        public static UnidadeFederativa? From(string? uf)
        {
            if (uf is null) return null;
            return Enum.TryParse<UnidadeFederativa>(uf, true, out var unidadeFederativa) ? unidadeFederativa : null;
        }
    }
    public enum UnidadeFederativa
    {
        AC,
        AL,
        AP,
        AM,
        BA,
        CE,
        DF,
        ES,
        GO,
        MA,
        MG,
        MS,
        MT,
        PA,
        PB,
        PE,
        PI,
        PR,
        RJ,
        RN,
        RO,
        RR,
        RS,
        SC,
        SE,
        SP,
        TO
    }
}