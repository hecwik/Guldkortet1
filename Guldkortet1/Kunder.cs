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
    public class Kunder
    {
        // varje post i kundlista.txt-filen är separerad i tre delar, som ska sparas till dessa egenskaper
        // med split()
        public string Kundnummer;
        public string Namn;
        public string Ort;

        public Kunder(string kundNummer, string namn, string ort)
        {
            Kundnummer = kundNummer;
            Namn = namn;
            Ort = ort;
        }
        public override string ToString()
        {
            return Kundnummer + "" + Namn + "" + Ort;
        }
        // metod som sparar nya Kunder-objekt i kundlista
        public void AddKonto(string kundnummer, string namn, string ort)
        {
            KundTillLista(kundnummer, namn, ort);
        }
    }
}
