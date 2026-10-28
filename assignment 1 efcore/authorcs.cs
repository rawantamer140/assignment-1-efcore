using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_1_efcore
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Biography { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }
    }

}

