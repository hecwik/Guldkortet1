using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Guldkortet1
{
    public class Kort
    {
        public string Kortnummer;
        public string Typ;

        public Kort(string kortNummer, string typ)
        {
            Kortnummer = kortNummer;
            Typ = typ;
        }

        public override string ToString()
        {
            return Kortnummer + "" + Typ;
        }
        public void AddKort(string kortNummer, string typ)
        {
            Listor.KortTillLista(kortNummer, typ);
        }
        
    }

    // subklasser för Kort-klassen, alla olika superdjur med ärvda och ändrad Typ samt ToString()-metoder
    public class DunderKatt : Kort
    {
        public DunderKatt(string kortNummer, string typ) : base(kortNummer, typ)
        {
            Typ = "Dunderkatt";
        }

        public override string ToString()
        {
            return Kortnummer + "" + Typ;
        }
    }
    public class KristallHäst : Kort
    {
        public KristallHäst(string kortNummer, string typ) : base(kortNummer, typ)
        {
            Typ = "Kristallhäst";
        }

        public override string ToString()
        {
            return Kortnummer + "" + Typ;
        }
    }
    public class ÖverPanda : Kort
    {
        public ÖverPanda(string kortNummer, string typ) : base(kortNummer, typ)
        {
            Typ = "Överpanda";
        }

        public override string ToString()
        {
            return Kortnummer + "" + Typ;
        }
    }
    public class EldTomat : Kort
    {
        public EldTomat(string kortNummer, string typ) : base(kortNummer, typ)
        {
            Typ = "Eldtomat";
        }

        public override string ToString()
        {
            return Kortnummer + "" + Typ;
        }
    }
}
