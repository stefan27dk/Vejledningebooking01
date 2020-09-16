using System;
using System.Collections.Generic;
using System.Text;

namespace Vejledningebooking01.Domain.Model
{
   public class Calendar
    {
        public int Id { get; set; }
        public ICollection<Hold> Holds { get; set; }

    }
}
