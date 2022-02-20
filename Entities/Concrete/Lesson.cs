using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Lesson:IEntity
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }  
    }
}
