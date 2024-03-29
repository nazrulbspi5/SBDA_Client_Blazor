﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SBDA.Shared
{
    public class UserManagerResponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Dictionary<string, string> UserInfo { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
