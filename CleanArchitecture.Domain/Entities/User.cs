﻿using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string username { get; set; }
        public string password_salt { get; set; }
        public string password_hash { get; set; }
        public string email { get; set; }
        public string full_name { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
    }
}