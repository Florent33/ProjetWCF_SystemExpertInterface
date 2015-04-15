using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace ProjetWebService_SystemeExpert
{
    public partial class Form1 : Form
    {
        Question maQuestion;

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
           
        }

       
        private void prochaineQuestion_button1_Click(object sender, EventArgs e)
        {
            this.question_textBox1.Text = "Récupérer la réponse...";

            maQuestion = HttpServiceWeb.GetQuestion("1", "GET", null, "text/xml");
            question_textBox1.Text = maQuestion.QuestionContenu;
        }

        private void envoyerReponse_button2_Click(object sender, EventArgs e)
        {
            this.reponse_textBox2.Text = "Envoyer la réponse...";
            maQuestion.

        }
    }
}
