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
    public partial class Form1 : Form
    {
        
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartaServer_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void btnStängServer_Click(object sender, EventArgs e)
        {
            StängServer();
        }

        // metod för att börja lyssna efter anslutning
        public void StartServer()
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
                lyssnare.Start();
                btnStartaServer.Text = "Väntar på anslutning...";
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            StartReceive();
        }
        // asynkron metod för att starta mottagning från klient
        public async void StartReceive()
        {
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            
            btnStartaServer.Text = "Ansluten!";
            btnStartaServer.BackColor = Color.Green;
            StartReading(klient);
        }
        // asynkron metod för att läsa dataström från klient
        public async void StartReading(TcpClient k)
        {
            byte[] buffert = new byte[1024];
            int n = 0;
            
            try
            {
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }

            StartReading(k);
        }
        // metod för att stänga ner servern
        public void StängServer()
        {
            try
            {
                klient.Close();
                lyssnare.Stop();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
        }

        // metod som hämtar och sparar data som strängar från kundlista.txt
        
        // metod för att läsa in kort från kortlista.txt, principiellt samma som för kundkonton
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckWin_Click(object sender, EventArgs e)
        {
            string userIDText = textBox1.Text;
            string cardIDText = textBox2.Text;

            foreach (Kunder item in KundLista)
            {

            }
        }
        // när Windows-forms formen laddar läses textfilerna in med respektive metod
        private void Form1_Load(object sender, EventArgs e)
        {
            // nu får jag inte åtkomst till dessa metoder som ligger i Listor-klassen...

            Listor.KundLoader();
            Listor.KortLoader();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


