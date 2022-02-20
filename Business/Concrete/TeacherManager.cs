using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        ITeacherDal _teacherDal;
        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        [SecuredOperation("teacher.add,admin")]
        public IResult Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);
            return new SuccessResult();
        }

        [SecuredOperation("teacher.getall,admin")]
        public IDataResult<List<Teacher>> GetAll()
        {
            return new SuccessDataResult<List<Teacher>>(_teacherDal.GetAll(),"Listelendi");
        }

        public IDataResult<List<Teacher>> GetAllByLessonId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TeacherDetailDto>> GetTeacherDetail()
        {
            return new SuccessDataResult<List<TeacherDetailDto>>(_teacherDal.GetTeacherDetail(),"Detaylar Listelendi");
        }

        public IResult Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
