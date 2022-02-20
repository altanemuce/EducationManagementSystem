using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public int StudentId { get; set; }
        public string TeacherName { get; set; }
        public string LessonName { get; set; }
        public int Day { get; set; }
        public decimal OrderPrice { get; set; }


    }
}
