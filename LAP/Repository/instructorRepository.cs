using LAP.Models;

namespace LAP.Repository
{
    public class instructorRepository : IinstructorRepository
    {

        Context context = new Context();

        ///CRUD ==>

        //1) CREATE ==>
        public void Insert(Instructor item)
        {
            context.Add(item);
        }

        //2) READ ==>
        public Instructor GetById(int id)
        {

            return context.Instructors.FirstOrDefault(i => i.Id == id);
        }
        public List<Instructor> GetAll()
        {
            return context.Instructors.ToList();
        }

        //3) UPDATE ==> 
        public void Edit(int id, Instructor item)
        {
            Instructor instructor = context.Instructors.FirstOrDefault(i => i.Id == id);

            instructor.Address = item.Address;
            instructor.Name = item.Name;
            instructor.CourseID = item.CourseID;
            instructor.DepartmentID = item.DepartmentID;

            context.Update(instructor);

        }

        //4) DELETE ==>
        public void Delete(int id)
        {
            Instructor instructor = GetById(id);
            context.Remove(instructor);
        }

        ///SAVE ==>
        public void Save()
        {
            context.SaveChanges();
        }

    }
}
