using LAP.Models;

namespace LAP.Repository
{
    public interface IinstructorRepository
    {

        ///CRUD ==>

        //1) CREATE ==>
        void Insert(Instructor item);

        //2) READ ==>
        Instructor GetById(int id);
        List<Instructor> GetAll();

        //3) UPDATE ==> 
        void Edit(int id, Instructor item);

        //4) DELETE ==>
        void Delete(int id);

        void Save();




    }
}
