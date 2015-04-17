using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWebService_SystemeExpert
{
    public partial class ConfigServerQuestion : Form
    {
        protected string _urlServiceWeb;

        public ConfigServerQuestion()
        {
            InitializeComponent();
        }

        public string UrlServiceWeb
        { get { return _urlServiceWeb; } set { _urlServiceWeb = value; } }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_urlServiceWeb.Text))
            {
                MessageBox.Show("Merci de saisir l'adresse url du service web");
            }
            else
            {
                UrlServiceWeb = txt_urlServiceWeb.Text;
            }
        }

        private void ConfigServerQuestion_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_urlServiceWeb.Text))
            {
                MessageBox.Show("Merci de saisir l'adresse url du service web");
            }
            else
            {
                UrlServiceWeb = txt_urlServiceWeb.Text;
            }
        }
    }
}
