﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamToeicOnline_BackEnd_Clients.Models
{
    public class Anwser
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Boolean Correct { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }

    }
}
