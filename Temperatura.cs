using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperaturasNacional
{
    class Temperatura
    {
        int idDep;
        decimal temp;

        public int IdDep { get => idDep; set => idDep = value; }
        public decimal Temp { get => temp; set => temp = value; }
    }
}
