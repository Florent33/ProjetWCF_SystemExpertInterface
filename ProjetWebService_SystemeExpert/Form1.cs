using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWebService_SystemeExpert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Appel service web
         * récupérer question
         * objet question, reponse
        */
        // Faire la requête pour demander la question
        // Stocker les valeurs en html ou en xml
        // Reponse: http reponse avec id

        private void question_textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void reponse_textBox2_TextChanged(object sender, EventArgs e)
        {
            StringBuilder data = new StringBuilder();
            Uri uri;
            byte[] byteData;

            uri = new Uri("http://localhost:8002/i2037");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

            request.Method = "POST";
            request.ContentType = "text/xml";
            data.Append("method=glpi.status");

            byteData = UTF8Encoding.UTF8.GetBytes(data.ToString());
            request.ContentLength = byteData.Length;

            using (Stream postStream = request.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);
            }

            using (Stream postStream = request.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream postStream = request.GetRequestStream())
                {
                    using (StreamReader responseStream = new StreamReader())
                    {
                        Console.WriteLine("Réponse reçue.");
                        Console.WriteLine(responseStream.ReadToEnd());
                    }
                }
            }
            else
            {
                Console.WriteLine("Une erreur est survenue.");
            }

            Console.Read();
        }

        private void prochaineQuestion_button1_Click(object sender, EventArgs e)
        {
            this.question_textBox1.Text = "Récupérer réponse...";
        }

        private void envoyerReponse_button2_Click(object sender, EventArgs e)
        {
            this.reponse_textBox2.Text = "Envoyer la réponse...";
        }
    }
}
