using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Teacher : IEntity
    {
        public int TeacherId { get; set; }
        public int LessonId { get; set; }
        public int StudentId { get; set; }
        public string TFirstName { get; set; }
        public string TLastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; } 
        public string Photo { get; set; }
        public int OffDay { get; set; }

    }
}
