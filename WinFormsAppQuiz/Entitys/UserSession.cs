﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppQuiz.Entitys
{
    public  class UserSession
    {
        public  int Id { get; set; }
        public  string Login { get; set; }
        public  string Full_Name { get; set; }
        public int? worth { get; set; }
        public string PassOrFail { get; set; }
        public DateTime LoginTime { get; set; }

    }

}
