using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menadzer_finansow.Class
{
    
    public class BazaDanych
    {
     
        public List<Dochod> ListaDochodow { get; set; } = new List<Dochod>();
        public List<Wydatek> ListaWydatkow { get; set; } = new List<Wydatek>();
    }
}
