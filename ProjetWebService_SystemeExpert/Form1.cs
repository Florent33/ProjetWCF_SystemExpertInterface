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
        protected string _urlServer;
        public string UrlServerInit { get { return string.Format("{0}/{1}", _urlServer, "Question?question_id=0"); } }

        private void question_textBox1_TextChanged(object sender, EventArgs e) { }
        private void reponse_textBox2_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) {
            _urlServer = Properties.Settings.Default.urlServer;
            InitialiserQuestionDepartFictive();
        }

        private void InitialiserQuestionDepartFictive()
        {
            StringBuilder monBuilderParams = new StringBuilder();

            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("Content-Type", "text/html");
                client.Headers.Add("Accept", "text/json");
                client.Encoding = UTF8Encoding.UTF8;
                Uri monUri;

                try
                {
                    monUri = new Uri(UrlServerInit);
                }
                catch (Exception)
                {
                    ConfigServerQuestion uneFormConfigServ = new ConfigServerQuestion();
                    uneFormConfigServ.UrlServiceWeb = UrlServerInit;
                    uneFormConfigServ.ShowDialog();
                    _urlServer = uneFormConfigServ.UrlServiceWeb;
                    monUri = new Uri(UrlServerInit);
                }

                

                if (WebRequest.DefaultWebProxy.IsBypassed(monUri))
                {
                    client.Proxy = WebRequest.GetSystemWebProxy();
                }


                try
                {
                    monBuilderParams.Append(client.DownloadString(UrlServerInit));
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("Mauvaise url server : \nDétail : {0}", e.Message));
                    ConfigServerQuestion uneFormConfigServ = new ConfigServerQuestion();
                    uneFormConfigServ.UrlServiceWeb = UrlServerInit;
                    uneFormConfigServ.ShowDialog();
                    _urlServer = uneFormConfigServ.UrlServiceWeb;
                    monUri = new Uri(UrlServerInit);

                    client.Proxy = WebRequest.GetSystemWebProxy();
                    monBuilderParams.Append(client.DownloadString(UrlServerInit));
                }

                

                maQuestion = Newtonsoft.Json.JsonConvert.DeserializeObject<Question>(monBuilderParams.ToString());
            }

            txt_question.Text = "";
            txt_reponse.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void prochaineQuestion_button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maQuestion.LienRessourceNext) || maQuestion.LienRessourceNext.EndsWith("="))
            {
                MessageBox.Show("Il n'y a plus de question");
            }
            else
            {
                StringBuilder monBuilderParams = new StringBuilder();

                using (var client = new System.Net.WebClient())
                {
                    client.Headers.Add("Content-Type", "text/html");
                    client.Headers.Add("Accept", "text/json");
                    client.Encoding = UTF8Encoding.UTF8;

                    Uri monUri = new Uri(maQuestion.LienRessourceNext);

                    if (WebRequest.DefaultWebProxy.IsBypassed(monUri))
                    {
                        client.Proxy = WebRequest.GetSystemWebProxy();
                    }
                    
                    monBuilderParams.Append(client.DownloadString(maQuestion.LienRessourceNext));

                    maQuestion = Newtonsoft.Json.JsonConvert.DeserializeObject<Question>(monBuilderParams.ToString());
                }

                if (string.IsNullOrEmpty(maQuestion.LienRessourceNext))
                {
                    MessageBox.Show("Il n'y a plus de question");
                    InitialiserQuestionDepartFictive();
                }
                else
                {
                    txt_question.Text = maQuestion.QuestionContenu;
                    txt_reponse.Text = "";
                }
            }
        }


        private void envoyerReponse_button2_Click(object sender, EventArgs e)
        {
            NameValueCollection parametres = new NameValueCollection();

            parametres.Add("question_id", maQuestion.Id);
            parametres.Add("question_contenu", maQuestion.QuestionContenu);
            parametres.Add("reponse_contenu", txt_reponse.Text);

            byte[] encodageBytesParams;
            StringBuilder monBuilderParams = new StringBuilder();
            bool premierParamPasse = true;

            foreach (var item in parametres.AllKeys)
            {
                if (premierParamPasse)
                {
                    monBuilderParams.Append(string.Format("{0}={1}", item, parametres[item]));
                    premierParamPasse = false;
                }
                else
                {
                    monBuilderParams.Append(string.Format("&{0}={1}", item, parametres[item]));
                }
            }

            UTF8Encoding utf8 = new UTF8Encoding();
            encodageBytesParams = utf8.GetBytes(monBuilderParams.ToString());
            byte[] repReq;

            using (var client = new System.Net.WebClient())
            {
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                client.Headers.Add("Accept", "text/json");
                Uri monUri = new Uri(maQuestion.LienRessource);

                if (WebRequest.DefaultWebProxy.IsBypassed(monUri))
                {
                    client.Proxy = WebRequest.GetSystemWebProxy();
                }

                repReq = client.UploadData(maQuestion.LienRessource, "PUT", encodageBytesParams);
            }

            monBuilderParams = new StringBuilder(utf8.GetString(repReq));

            maQuestion = Newtonsoft.Json.JsonConvert.DeserializeObject<Question>(monBuilderParams.ToString());

            if (string.IsNullOrEmpty(maQuestion.LienRessourceNext))
            {
                MessageBox.Show("Il n'y a plus de question");
                InitialiserQuestionDepartFictive();
            }
            else
            {
                txt_question.Text = maQuestion.QuestionContenu;
                txt_reponse.Text = "";
            }
        }

        private void adtresseServeurQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigServerQuestion maFormConfig = new ConfigServerQuestion();
            maFormConfig.UrlServiceWeb = _urlServer;

            maFormConfig.ShowDialog();

            _urlServer = maFormConfig.UrlServiceWeb;
        }
    }
}
