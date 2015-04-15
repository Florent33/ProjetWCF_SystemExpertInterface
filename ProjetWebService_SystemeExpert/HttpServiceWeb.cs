using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ProjetWebService_SystemeExpert
{
    public static class HttpServiceWeb
    {
        private static void DefinirMetodeRequete(string metodeRequete, ref HttpWebRequest laRequete)
        {
            if (metodeRequete == null)
            {
                laRequete.Method = "GET";
            }
            else
            {
                laRequete.Method = metodeRequete;
            }
        }

        private static void DefinirContentType(string contentType, ref HttpWebRequest laRequete)
        {
            if (contentType == null)
            {
                laRequete.ContentType = "application/x-www-form-urlencoded";
            }
            else
            {
                laRequete.ContentType = contentType;
            }
        }

        private static HttpWebRequest ExecuterReqHttp(string url, string metode = null, string contentType = null, string acceptRepresentation = null)
        {
            HttpWebRequest monReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);

            ChargerParametresRequete(ref monReq, metode, contentType, acceptRepresentation);

            return monReq;
        }

        private static void ChargerParametresRequete(ref HttpWebRequest monReq, string metode, string contentType, string acceptRepresentation)
        {
            DefinirMetodeRequete(metode, ref monReq);
            DefinirContentType(contentType, ref monReq);
            DefinirRepresentationAcceptee(monReq, acceptRepresentation);
        }

        private static void DefinirRepresentationAcceptee(HttpWebRequest monReq, string acceptRepresentation)
        {
            if (acceptRepresentation == null)
            {
                monReq.Accept = "";
            }
            else
            {
                monReq.Accept = acceptRepresentation;
            }
        }

        public static Question GetQuestion(string idQuestion, string metodeRequete = null, string contentType = null, string representationTexte = null)
        {
            HttpWebRequest monReq = ExecuterReqHttp(string.Format("http://localhost:8002/i2037/Question?question_id={0}", idQuestion), metodeRequete, contentType, representationTexte);

            StringBuilder chaineReponseBuilded = new StringBuilder();
            XmlSerializer xs;

            xs = new XmlSerializer(typeof(Question));
            
            TextReader monTextReader = new StreamReader(monReq.GetResponse().GetResponseStream());

            Question maQuestion = (Question)xs.Deserialize(monTextReader);

            return maQuestion;
        }

        public static Reponse GetReponse(string ip, string secret, string numeroQuestion, string token)
        {
            //HttpWebRequest monReq = ExecuterReqHttp(string.Format("http://{0}:8080/api/parties/{1}/questions/{2}?token={3}", ip, secret, numeroQuestion, token));           
            //string reponseString = ExtraireReponseBrut(monReq);
            //Reponse reponseQuestion = JsonConvert.DeserializeObject<Reponse>(reponseString);
            //ReponseScore maReponse = new ReponseScore();
            //maReponse.reponse = reponseQuestion.ScoreTotal().ToString();  
            //HttpWebRequest envoi = ExecuterReqHttp(string.Format("http://{0}:8080/api/parties/{1}/reponses", ip, secret), "post", "application/json");
            //HttpWebRequest envoi = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(string.Format("http://{0}:8080/api/parties/{1}/reponses", ip, secret));
            //envoi.Headers.Add(
            //using (WebClient wb = new WebClient())
            //{
            //    var data = new NameValueCollection();
            //    data["reponse"] = JsonConvert.SerializeObject(maReponse);
            //    var response = wb.UploadValues(string.Format("http://{0}:8080/api/parties/{1}/reponses", ip, secret), "POST", data);
            //}
            //DefinirMetodeRequete("post", ref monReq);
            //DefinirContentType("application/json", ref monReq);
            return new Reponse();
        }

        private static string ExtraireReponseBrut(HttpWebRequest monReq)
        {
            System.IO.StreamReader monReader = new System.IO.StreamReader(monReq.GetResponse().GetResponseStream());

            string reponseString = monReader.ReadToEnd();

            monReader.Close();
            return reponseString;
        }

        public static string GetBookDetail(string ip, string secret, string numeroQuestion, string token)
        {
            System.Net.HttpWebRequest monReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(string.Format("http://{0}:8080/api/parties/[votre_secret]/questions/[numéro_question]?token=[token_réponse_précédente]", ip, secret, numeroQuestion, token));

            monReq.Method = "GET";
            monReq.ContentType = "application/x-www-form-urlencoded";

            System.IO.StreamReader monReader = new System.IO.StreamReader(monReq.GetResponse().GetResponseStream());

            string reponseString = monReader.ReadToEnd();

            monReader.Close();

            return reponseString;
        }

        public static object[] secret { get; set; }

        public static object numeroQuestion { get; set; }

        public static object token { get; set; }

        public static string ip { get; set; }
    }
}
