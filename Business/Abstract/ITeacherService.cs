using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        IDataResult<List<Teacher>> GetAll();
        IDataResult<List<Teacher>> GetAllByLessonId(int id);
        IResult Add(Teacher teacher);
        IResult Update(Teacher teacher);
        IDataResult<List<TeacherDetailDto>> GetTeacherDetail();
    }
}
