using System;
using System.Collections.Generic;
using System.Text;

namespace Vejledningebooking01.Domain.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Hold> Holds { get; set; }

    }
}
