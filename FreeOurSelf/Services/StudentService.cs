using FreeOurSelf.Models;
using Microsoft.EntityFrameworkCore;

namespace FreeOurSelf.Services
{
    public class StudentService : IStudent
    {
        private readonly AppDbContext _context;
        public StudentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StudentModel>> GetAll()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<StudentModel?> Get(int id)
        {
            var student = await _context.Students.FindAsync(id);
            return student;
        }

        // POST: api/student
        public async Task<StudentModel> Create(StudentModel student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        // PUT: api/student/1
        public async Task Update(int id, StudentModel student)
        {
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // DELETE: api/student/1
        public async Task Delete(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if(student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
        }
    }
}
