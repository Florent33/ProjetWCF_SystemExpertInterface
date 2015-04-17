using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft;

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

        public static HttpWebRequest ExecuterReqHttp(string url, string metode = null, string contentType = null, string acceptRepresentation = null)
        {
            HttpWebRequest monReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            ChargerParametresRequete(ref monReq, metode, contentType, acceptRepresentation);

            return monReq;
        }

        public static HttpWebRequest ExecuterReqHttp(string url, out int codeStatut, string metode = null, string contentType = null, string acceptRepresentation = null, NameValueCollection parametres = null)
        {
            HttpWebRequest monReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            ChargerParametresRequete(ref monReq, metode, contentType, acceptRepresentation, parametres);

            HttpWebResponse uneReponse = (HttpWebResponse) monReq.GetResponse();

            codeStatut = uneReponse.StatusCode.GetHashCode();

            return monReq;
        }



        private static void ChargerParametresRequete(ref HttpWebRequest monReq, string metode, string contentType, string acceptRepresentation, NameValueCollection parametres = null)
        {
            DefinirMetodeRequete(metode, ref monReq);
            DefinirContentType(contentType, ref monReq);
            DefinirRepresentationAcceptee(monReq, acceptRepresentation);
            if (metode != "GET")
            {
                DefinirParametresCache(monReq, parametres); 
            }
            
        }

        private static void DefinirParametresCache(HttpWebRequest monReq, NameValueCollection parametres)
        {
            monReq.AllowWriteStreamBuffering = true;
            //monReq.AllowReadStreamBuffering = true;
            using (Stream mesDatas = monReq.GetRequestStream())
            {

                byte[] encodageBytesParams = GenererParametresEncodeBytes(monReq, parametres);

                mesDatas.Write(encodageBytesParams, 0, encodageBytesParams.Length);
            }
        }

        private static byte[] GenererParametresEncodeBytes(HttpWebRequest monReq, NameValueCollection parametres)
        {
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

            ASCIIEncoding ascii = new ASCIIEncoding();
            encodageBytesParams = ascii.GetBytes(monBuilderParams.ToString());

            return encodageBytesParams;
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

        public static Question GetQuestion(int idQuestion, string metodeRequete = null, string contentType = null, string representationTexte = null)
        {
            HttpWebRequest monReq = ExecuterReqHttp(string.Format("http://localhost:2441/Quest/Question?question_id={0}", idQuestion), metodeRequete, contentType, representationTexte);

            StringBuilder chaineReponseBuilded = new StringBuilder();
            XmlSerializer xs;

            xs = new XmlSerializer(typeof(Question));

            Question uneQuestion;

            uneQuestion = Newtonsoft.Json.JsonConvert.DeserializeObject<Question>(ExtraireReponseBrut(monReq));
            

            //Question maQuestion = (Question)xs.Deserialize(monTextReader);

            return uneQuestion;
        }

        public static Question GetQuestion(string url, string metodeRequete = null, string contentType = null, string representationTexte = null)
        {
            HttpWebRequest monReq = ExecuterReqHttp(url, metodeRequete, contentType, representationTexte);

            StringBuilder chaineReponseBuilded = new StringBuilder();
            XmlSerializer xs;

            xs = new XmlSerializer(typeof(Question));

            Question maQuestion;

            using (Stream maStream = monReq.GetResponse().GetResponseStream())
            {
                TextReader monTextReader = new StreamReader(maStream);
                maQuestion = (Question)xs.Deserialize(monTextReader);
            }
            

            

            return maQuestion;
        }

        public static Reponse GetReponse(string ip, string secret, string numeroQuestion, string token)
        {
            //string urlPath = "http://localhost:8002/Question?question_id=1";
            //string request = urlPath + "indexTest.html/org/put_org_form";
            //XmlSerializer xs1;
            //xs1 = new XmlSerializer(typeof(Reponse));
            //Reponse maReponse = (Reponse)xs1.Serialize(
            //WebRequest webRequest = WebRequest.Create(request);
            //webRequest.Method = "PUT";
            //webRequest.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
            //webRequest.ContentLength = 65;
            //WebResponse webResponse = webRequest.GetResponse();

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
            //    var response = wb.UploadValues(string.Format("http://{0}:8080/api/parties/{1}/reponses", ip, secret), data);
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

        //public static string GetBookDetail(string ip, string secret, string numeroQuestion, string token)
        //{
        //    System.Net.HttpWebRequest monReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(string.Format("http://{0}:8080/api/parties/[votre_secret]/questions/[numéro_question]?token=[token_réponse_précédente]", ip, secret, numeroQuestion, token));

        //    monReq.Method = "GET";
        //    monReq.ContentType = "application/x-www-form-urlencoded";

        //    System.IO.StreamReader monReader = new System.IO.StreamReader(monReq.GetResponse().GetResponseStream());

        //    string reponseString = monReader.ReadToEnd();

        //    monReader.Close();

        //    return reponseString;
        //}

        public static object[] secret { get; set; }

        public static object numeroQuestion { get; set; }

        public static object token { get; set; }

        public static string ip { get; set; }
    }
}