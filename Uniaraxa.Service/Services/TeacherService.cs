using System;
using System.Collections.Generic;
using System.Text;
using Uniaraxa.Domain.Entities;

namespace Uniaraxa.Service.Services
{
    public class TeacherService : ITeacherService 
    {
        private readonly ITeacherService _teacherRepository;

        public TeacherService(ITeacherService teacherRepository)
        {
            _teacherRepository = _teacherRepository;
        }
        public void AddTeache(Teacher teacher)
        {
            _teacherRepository.AddTeacher(teacher);
        }

        public void DeleteTeacher(int id)
        {
            _teacherRepository.DeleteTeacher(id);
        }

        public List<Teacher> GetAllTeacher()
        {
            return _teacherRepository.GetAllTeacher();
        }

        public Student GetTeacherById(int id)
        {
            return _teachertRepository.GetTeacherById(id);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepository.UpdateTeacher(teacher);
        }
    }
}
