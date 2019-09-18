using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Eksamen
{
    class Client
    {
        
          public string Navn { get; set; }
        public string EfterNavn { get; set; }
        public string Telefon { get; set; }
        public string Adresse { get; set; }
        public int PostNummer { get; set; }

       



        public string Full_Info
        {
            get
            {
                return $"{Navn} {EfterNavn} {Telefon} {Adresse} {PostNummer}";
            }
        }






    }
}
