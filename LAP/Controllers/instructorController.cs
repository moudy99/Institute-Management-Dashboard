using LAP.HUBS;
using LAP.Models;
using LAP.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace LAP.Controllers
{
    [Authorize]

    public class instructorController : Controller
    {
        public instructorController(IHubContext<Add_Instructor_Hub> add_inst_hub)
        {
            this.add_Inst_Hub = add_inst_hub;
        }

        private static int counter = 0;

        Context context = new Context();
        private readonly IHubContext<Add_Instructor_Hub> add_Inst_Hub;



        public IActionResult Index(string search = "", int page = 1)
        {

            List<Instructor> instructors = context.Instructors.Include(d => d.Department).ToList();



            /// Search
            if (!string.IsNullOrEmpty(search))
            {
                instructors = instructors.Where(c => c.Name.Contains(search)).ToList();
                ViewData["search"] = search;

            }

            ////// Pagination
            int pageSize = 6;
            int total = instructors.Count();

            var PaginatedList = new PaginatedList(total, page, pageSize);

            int skiped_data = (page - 1) * pageSize;

            instructors = instructors.Skip(skiped_data).Take(pageSize).ToList();

            ViewBag.Pager = PaginatedList;




            return View("Index", instructors);
        }

        public IActionResult details(int id)
        {
            Instructor inst = context.Instructors.Include(d => d.Department).FirstOrDefault(x => x.Id == id);
            ViewBag.courseName = (from i in context.Instructors
                                  join c in context.Course
                                  on i.Course.ID equals c.ID
                                  where i.Id == id
                                  select c.Name).FirstOrDefault();


            return View("details", inst);
        }



        /// Adding New Instructor==> 

        public IActionResult Add()
        {
            Add_new_instructor_viewModel add_New_Instructor = new Add_new_instructor_viewModel();

            add_New_Instructor.courses = context.Course.Distinct().ToList();
            add_New_Instructor.departments = context.Departments.Distinct().ToList();

            return View("Add", add_New_Instructor);
        }


        public IActionResult ALl_Department_Courses(int id)
        {
            return Json(context.Course.Where(c => c.DepartmentId == id).Select(c => new { c.Name, c.ID }).ToList());
        }

        [HttpPost]
        public async Task<IActionResult> saveNew(Instructor instructor)
        {

            Instructor inst = new Instructor();

            if (instructor != null)
            {
                inst.Name = instructor.Name;
                inst.Address = instructor.Address;
                inst.salary = instructor.salary;
                inst.Image = instructor.Image;
                inst.CourseID = instructor.CourseID;
                inst.DepartmentID = instructor.DepartmentID;


                context.Instructors.Add(instructor);
                context.SaveChanges();

                await add_Inst_Hub.Clients.All.SendAsync("new-instructor-added", instructor);

                return RedirectToAction("Index");
            }
            return View("Add");

        }

        /// Edit Instructor

        public IActionResult Edit(int id)
        {

            Edit_instructor_viewModel edit_Instructor_ViewModel = new Edit_instructor_viewModel();


            edit_Instructor_ViewModel.courses = context.Course.Distinct().ToList();
            edit_Instructor_ViewModel.departments = context.Departments.Distinct().ToList();
            edit_Instructor_ViewModel.instructor = context.Instructors.Include(d => d.Department).FirstOrDefault(x => x.Id == id);
            return View("edit", edit_Instructor_ViewModel);
        }

        [HttpPost]
        public IActionResult SaveEdit(Instructor instructor)
        {
            if (instructor.Name != null && instructor.Address != null)
            {

                if (instructor != null)
                {
                    var inst = context.Instructors.FirstOrDefault(i => i.Id == instructor.Id);

                    if (inst != null)
                    {
                        inst.Name = instructor.Name;
                        inst.Address = instructor.Address;
                        inst.salary = instructor.salary;
                        inst.CourseID = instructor.CourseID;
                        inst.DepartmentID = instructor.DepartmentID;
                        inst.Image = instructor.Image;

                        context.Update(inst);
                        context.SaveChanges();

                        return RedirectToAction("Index");
                    }
                }
            }
            Edit_instructor_viewModel edit_Instructor_ViewModel = new Edit_instructor_viewModel();

            Instructor instructor1 = context.Instructors.FirstOrDefault(i => i.Id == instructor.Id);


            edit_Instructor_ViewModel.courses = context.Course.Distinct().ToList();
            edit_Instructor_ViewModel.departments = context.Departments.Distinct().ToList();
            edit_Instructor_ViewModel.instructor = new Instructor()
            {
                Id = instructor.Id,
                Name = instructor.Name,
                Address = instructor.Address,
                CourseID = instructor.CourseID,
                DepartmentID = instructor.DepartmentID,
                Course = instructor1.Course,
                Department = instructor1.Department,
                Image = instructor.Image,
                salary = instructor.salary
            };
            return View("edit", edit_Instructor_ViewModel);
        }





        ///// Delete 
        public IActionResult delete(int id)
        {

            Instructor inst = context.Instructors.Where(i => i.Id == id).FirstOrDefault();

            context.Remove(inst);

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
