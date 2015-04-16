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
        protected Question maQuestion;
        protected Reponse maReponse;

        private void question_textBox1_TextChanged(object sender, EventArgs e) { }
        private void reponse_textBox2_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        public Form1()
        {
            InitializeComponent();
        }

        private void prochaineQuestion_button1_Click(object sender, EventArgs e)
        {
            this.txt_question.Text = "Récupérer la réponse...";

            maQuestion = HttpServiceWeb.GetQuestion(1, "GET", null, "text/xml");
            txt_question.Text = maQuestion.QuestionContenu;
            txt_reponse.Text = maQuestion.ReponseString.ReponseContenu;
        }

        private void envoyerReponse_button2_Click(object sender, EventArgs e)
        {
            txt_reponse.Text = "Envoyer la réponse...";

            //maQuestion = HttpServiceWeb.
            //txt_question.Text = maQuestion.QuestionContenu;
            //txt_reponse.Text = maQuestion.ReponseString.ReponseContenu;

            //maReponse = HttpServiceWeb.GetReponse("1", "PUT", null, "text/xml");
            //txt_reponse.Text = maReponse.ReponseContenu;

            //string urlPath = "http://localhost:8002/Question?question_id=1";
            //string request = urlPath + "indexTest.html/org/put_org_form";
            //WebRequest webRequest = WebRequest.Create(request);
            //webRequest.Method = "PUT";
            //webRequest.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
            //webRequest.ContentLength = 65;
            ////WebResponse webResponse = webRequest.GetReponse();
            ////reponse_textBox2.Text

            NameValueCollection lesParametres = new NameValueCollection();

            lesParametres.Add("question_id", maQuestion.Id);
            lesParametres.Add("question_contenu", maQuestion.QuestionContenu);
            lesParametres.Add("reponse_contenu", txt_reponse.Text);

            int CodeRetour = 200;
            HttpWebRequest uneReq = HttpServiceWeb.ExecuterReqHttp(maQuestion.LienRessource, out CodeRetour, "PUT", "text/xml", "text/xml", lesParametres);

            if (!(CodeRetour >= 200 && CodeRetour < 200))
            {
                MessageBox.Show(((HttpWebResponse)uneReq.GetResponse()).StatusDescription);
            }

            this.txt_question.Text = "Récupérer la réponse...";

            maQuestion = HttpServiceWeb.GetQuestion(maQuestion.LienRessourceNext, "GET", null, "text/xml");
            txt_question.Text = maQuestion.QuestionContenu;
            txt_reponse.Text = maQuestion.ReponseString.ReponseContenu;
        }
    }
}
