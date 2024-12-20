using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndDesignPatterns.SOLIDPrinciples.SingleResponsibility
{
    internal class User
    {
        public string? Username { get; set; }
        public required string Email { get; set; }
    }
}
