using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWebService_SystemeExpert
{
    public class Question
    {
        public string Id { get; set; }
        public string QuestionContenu { get; set; }
        public Reponse ReponseString { get; set; }
        public string LienRessource { get; set; }
        public string LienRessourceNext { get; set; }
    }
}
