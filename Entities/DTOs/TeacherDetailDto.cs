using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class TeacherDetailDto:IDto
    {
        public int TeacherId { get; set; }
        public string TFirstName { get; set; }
        public string TLastName { get; set; }
        public string LessonName { get; set; }
        public string SFirstName { get; set; }

    }
}
