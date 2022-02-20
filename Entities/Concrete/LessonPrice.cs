using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class LessonPrice
    {
        public int LessonPriceId { get; set; }
        public int TeacherId { get; set; }
        public int LessonId { get; set; }
        public double Price { get; set; }
    }
}
