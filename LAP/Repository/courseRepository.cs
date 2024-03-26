using LAP.Models;
using Microsoft.EntityFrameworkCore;

namespace LAP.Repository
{
    public class courseRepository : IcourseRepository
    {
        public string ID { get; set; }
        Context context;

        public courseRepository(Context contx)
        {
            context = contx;
            ID = Guid.NewGuid().ToString();

        }


        public void Delete(int id)
        {
            Course course = GetById(id);
            context.Remove(course);

        }

        public void Edit(int id, Course item)
        {
            Course course = GetById(id);
            course.CrsHours = item.CrsHours;
            course.Instructors = item.Instructors;
            course.CrsResults = item.CrsResults;
            course.Degree = item.Degree;
            course.DepartmentId = item.DepartmentId;
            course.Department = item.Department;
            course.MinDegree = item.MinDegree;
            course.Name = item.Name;

            context.Update(course);
        }

        public List<Course> GetAll(string include = "")
        {
            if (!string.IsNullOrEmpty(include))
            {
                if (include == "Department")
                    return context.Course.Include(c => c.Department).ToList();
            }
            return context.Course.ToList();
        }

        public Course GetById(int id, string include = "")
        {
            if (!string.IsNullOrEmpty(include))
            {
                return context.Course.Include(c => c.Department).FirstOrDefault(c => c.ID == id);
            }
            return context.Course.FirstOrDefault(c => c.ID == id);
        }

        public void Insert(Course item)
        {
            context.Add(item);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
