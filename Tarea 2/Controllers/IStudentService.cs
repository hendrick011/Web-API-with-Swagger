using Model;

namespace Tarea_2.Controllers
{
    public interface IStudentService
    {
        object GetAll();
        object Get(int id);
        object Delete(int id);
        object Add(Student model);
    }
}