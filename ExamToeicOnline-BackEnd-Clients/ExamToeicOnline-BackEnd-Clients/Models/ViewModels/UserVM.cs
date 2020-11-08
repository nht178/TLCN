﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Converters;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamToeicOnline_BackEnd_Clients.Models.ViewModels
{
    public class UserVM
    {
        public Guid Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int Phonenumber { get; set; }
        public DateTime Birthday { get; set; }
        public Byte Image { get; set; }
    }
}