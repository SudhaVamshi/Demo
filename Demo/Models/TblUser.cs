using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Dob { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Contactno { get; set; }
        public string Gender { get; set; }
    }
}
