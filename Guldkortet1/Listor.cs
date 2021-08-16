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
    public class Listor
    {
        // fick göra listorna till readonly, annars blev det problem med åtkomstnivåer
        public List<Kort> KortLista = new List<Kort>();
        public List<Kunder> KundLista = new List<Kunder>();
        // metod som sparar kundobjekt i kundlista

        public void KundTillLista(string kundnummer, string namn, string ort)
        {
            KundLista.Add(new Kunder(kundnummer, namn, ort));
        }
        // metod som sparar kortobjekt i kortlista
        public void KortTillLista(string kortnummer, string typ)
        {
            KortLista.Add(new Kort(kortnummer, typ));
        }

        // loopar genom kundlistan tills en post med identiskt kundnummer hittas
        public bool KundExisterar(string kundNummer, bool kundExisterar)
        {
            for (int i = 0; i < KundLista.Count; i++)
            {
                if (kundNummer == KundLista[i].Kundnummer)
                {
                    kundExisterar = true;
                }
            }
            return kundExisterar;
        }
        public void CompareLista()
        {
            List<string> compareLista = new List<string>();

            foreach (var item in KundLista)
            {
                string temp = Convert.ToString(item);
                compareLista.Add(temp);
            }

            return;
        }

        public void KundLoader()
        {
            //insåg att det behövdes en arraylista, eftersom listan ska spara array-element
            List<string[]> kunderImport = new List<string[]>();

            // kör felhantering med try/catch
            try
            {
                List<string> itemSaver = new List<string>();
                // filestream strömmar data från angivna filen
                FileStream filStröm = new FileStream("kundlista.txt", FileMode.Open, FileAccess.Read);

                // streamreader läser karaktärerna från dataströmmen
                using (StreamReader sr = new StreamReader("kundlista.txt", Encoding.UTF8))
                {
                    // temp-variabel för varje element i listan
                    string item = "";

                    //medan streamreader läser något, spara item till itemSaver-listan
                    while ((item = sr.ReadLine()) != null)
                    {
                        itemSaver.Add(item);
                    }
                }
                // för varje sträng i itemSaver, använd split() för att dela upp text där ### förekommer
                // stringsplitoptions avgör att det ska returneras tomma platser
                foreach (string b in itemSaver)
                {
                    string[] vektor = b.Split(new string[] { "###" }, StringSplitOptions.None);
                    kunderImport.Add(vektor);
                }
                // här gör jag en till foreach för att spara till som kundklass-objekt
                foreach (string[] vektor in kunderImport)
                {
                    // här kunde jag inte använda .Add insåg jag, så istället gjorde jag en metod för att lägga till kundkonto
                    KundLista.Add(new Kunder(vektor[0], vektor[1], vektor[2]));
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
        }
        public void KortLoader()
        {
            List<string[]> kortImport = new List<string[]>();

            try
            {
                List<string> itemSaver = new List<string>();
                FileStream filStröm = new FileStream("kortlista.txt", FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader("kortlista.txt", Encoding.UTF8))
                {
                    string item = "";
                    while ((item = sr.ReadLine()) != null)
                    {
                        itemSaver.Add(item);
                    }
                }

                foreach (string b in itemSaver)
                {
                    string[] vektor = b.Split(new string[] { "###" }, StringSplitOptions.None);
                    kortImport.Add(vektor);
                }

                foreach (string[] vektor in kortImport)
                {
                    KortLista.Add(new Kort(vektor[0], vektor[1]));
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
        }
    }
}
