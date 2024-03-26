using LAP.Models;

namespace LAP.Repository
{
    public interface IDepartmentRepository
    {
        ///CRUD ==>

        //1) CREATE ==>
        void Insert(Department item);

        //2) READ ==>
        Department GetById(int id, string include = "");
        List<Department> GetAll(string include = "");

        //3) UPDATE ==> 
        void Edit(int id, Department item);

        //4) DELETE ==>
        void Delete(int id);


        void Save();

    }
}