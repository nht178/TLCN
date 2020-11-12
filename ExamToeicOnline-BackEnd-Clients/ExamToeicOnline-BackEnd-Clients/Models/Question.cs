﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamToeicOnline_BackEnd_Clients.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public int PartId { get; set; }
        public Part Part { get; set; }
        public ICollection<Anwser> Anwsers { get; set; }
    }
}
