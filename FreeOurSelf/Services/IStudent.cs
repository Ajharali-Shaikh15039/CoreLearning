using FreeOurSelf.Models;      

namespace FreeOurSelf.Services
{
    public interface IStudent
    {
        Task<IEnumerable<StudentModel>> GetAll();
        Task<StudentModel?> Get(int id);
        Task<StudentModel> Create(StudentModel student);
        Task Update(int id, StudentModel student);
        Task Delete(int id);
    }
}
