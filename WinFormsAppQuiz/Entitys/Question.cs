using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppQuiz.Entitys
{
    public class Question
    {

        public int Id { get; set; }
        public string Text { get; set; }
        public double Score { get; set; }
        public string CorrectAnswer { get; set; }
        public string WrongAnswerOne { get; set; }
        public string WrongAnswerTwo { get; set; }
        public string WrongAnswerThree { get; set; }


    }
}
