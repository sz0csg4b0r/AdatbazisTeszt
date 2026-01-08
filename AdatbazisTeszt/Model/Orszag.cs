using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatbazisTeszt.Model
{
    internal class Orszag
    {
        public int id { get; set; }
        public string orszag { get; set; }
        public string fovaros { get; set; }
        public string foldr_hely { get; set; }
        public double terulet { get; set; }
        public string allamforma { get; set; }
        public int nepesseg { get; set; }
        public int nep_fovaros { get; set; }
        public string autojel { get; set; }
        public string country { get; set; }
        public string capital { get; set; }
        public string penznem { get; set; }
        public string penzjel { get; set; }
        public string valtopenz { get; set; }
        public int telefon { get; set; }
        public int gdp { get; set; }
        public int kat { get; set; }

        public Orszag()
        {
        }

        public Orszag(int id, string orszag, string fovaros, string foldr_hely, double terulet, string allamforma, int nepesseg, int nep_fovaros, string autojel, string country, string capital, string penznem, string penzjel, string valtopenz, int telefon, int gdp, int kat)
        {
            this.id = id;
            this.orszag = orszag;
            this.fovaros = fovaros;
            this.foldr_hely = foldr_hely;
            this.terulet = terulet;
            this.allamforma = allamforma;
            this.nepesseg = nepesseg;
            this.nep_fovaros = nep_fovaros;
            this.autojel = autojel;
            this.country = country;
            this.capital = capital;
            this.penznem = penznem;
            this.penzjel = penzjel;
            this.valtopenz = valtopenz;
            this.telefon = telefon;
            this.gdp = gdp;
            this.kat = kat;
        }
    }
}
