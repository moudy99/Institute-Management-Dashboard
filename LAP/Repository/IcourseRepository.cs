using LAP.Models;

namespace LAP.Repository
{
    public interface IcourseRepository
    {

        string ID { get; set; }
        ///CRUD ==>

        //1) CREATE ==>
        void Insert(Course item);

        //2) READ ==>
        Course GetById(int id, string include = "");
        List<Course> GetAll(string include = "");

        //3) UPDATE ==> 
        void Edit(int id, Course item);

        //4) DELETE ==>
        void Delete(int id);


        /////////////////////////////////////////  Adding Methods ==> 
        // Search => 

        void Save();

    }
}
