﻿using System;
namespace LibraryTestApi.Model.Httpbin.Auth
{
    public class DigestAuthResponseModel
    {
        public string authenticated { get; set; }
        public string user { get; set; }
    }
}
