using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class StudentService
    {
        private StudentContext dbContext;

        public StudentService(StudentContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Student>> GetAllStudentAsync()
        {
            return await dbContext.Student.ToListAsync();
        }


        public async Task<Student> AddStudentAsync(Student student)
        {

            dbContext.Student.Add(student);
            await dbContext.SaveChangesAsync();

            return student;
        }
        public async Task<Student> GetStudentAsync(int id)
        {
            var student = await dbContext.Student.FirstOrDefaultAsync(c => c.Id == id);
            await dbContext.SaveChangesAsync();

            return student;
        }


        public async Task<bool> UpdateStudentAsync(Student student)
        {
            dbContext.Student.Update(student);
            await dbContext.SaveChangesAsync();
            
            return true;
        }


        public async Task<bool> DeleteStudentAsync(Student student)
        {

            dbContext.Student.Remove(student);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
