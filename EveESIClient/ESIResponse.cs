﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient
{
    public class ESIResponse<T>
    {
        public bool IsSuccessful { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }
}
