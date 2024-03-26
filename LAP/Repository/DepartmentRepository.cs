using LAP.Models;
using Microsoft.EntityFrameworkCore;

namespace LAP.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        Context context;

        public DepartmentRepository(Context con)
        {
            context = con;
        }

        public void Delete(int id)
        {
            Department department = GetById(id);
            context.Remove(department);
        }

        public void Edit(int id, Department item)
        {
            Department department = GetById(id);
            department.Name = item.Name;
            department.Courses = item.Courses;
            department.Trainees = item.Trainees;
            department.instructors = item.instructors;
            department.Manger = item.Manger;

            context.Update(department);
        }

        public List<Department> GetAll(string include = "")
        {
            if (!string.IsNullOrEmpty(include))
            {
                return context.Departments.Include(d => d.Courses).ToList();
            }
            return context.Departments.ToList();
        }


        public Department GetById(int id, string include = "")
        {

            return context.Departments.FirstOrDefault(D => D.ID == id);
        }

        public void Insert(Department item)
        {
            context.Add(item);

        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
