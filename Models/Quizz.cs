using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompanyApp.MauiBlazor.Models
{
    public class Quiz
    {
        public string? Nom { get; set; }
        public string? Type { get; set; }
        public string? Difficulte { get; set; }
        public List<Question>? Questions { get; set; }
    }

    public class Question
    {
        public string? Texte { get; set; }
        public List<Reponse>? Reponses { get; set; }
    }

    public class Reponse
    {
        public string? Valeur { get; set; }
        public bool EstCorrecte { get; set; }
    }
}