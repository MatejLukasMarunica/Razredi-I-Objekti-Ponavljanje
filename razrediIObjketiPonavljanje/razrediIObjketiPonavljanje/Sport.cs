using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razrediIObjketiPonavljanje
{
    internal class Sport
    {
        string naziv;
        bool IgraLiSeLoptom;
        int brojIgraca;

        public void setnaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public void setIgraLiSeLoptom(bool IgraLiSeLoptom)
        {
            this.IgraLiSeLoptom = IgraLiSeLoptom;
        }
        public void setbrojIgraca(int brojIgraca)
        {
            this.brojIgraca = brojIgraca;
        }

        public string getnaziv()
        {
            return this.naziv;
        }
        public bool getIgraLiSeLoptom()
        {
            return this.IgraLiSeLoptom;
        }
        public int getbrojIgraca()
        {
            return this.brojIgraca;
        }

        public Sport(string naziv, bool IgraLiSeLoptom, int brojIgraca)
        {
            this.naziv = naziv;
            this.IgraLiSeLoptom = IgraLiSeLoptom;
            this.brojIgraca = brojIgraca;
        }

        public Sport()
        {
        }

        public override string ToString()
        {
            string ispis = "Naziv: " + this.getnaziv() + Environment.NewLine + " Dali se igra: " + this.getIgraLiSeLoptom() + Environment.NewLine + " Broj Igraca iznosi: " + this.getbrojIgraca();
            return ispis;
        }
    }
}
