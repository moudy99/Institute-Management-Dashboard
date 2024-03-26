using LAP.Models;
using LAP.Repository;
using LAP.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LAP.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        //Context context = new Context();

        IcourseRepository courseRepository;
        IinstructorRepository instructorRepository;
        IDepartmentRepository departmentRepository;

        public CourseController(IcourseRepository courseRep, IinstructorRepository instRep, IDepartmentRepository deptRep)
        {
            courseRepository = courseRep;
            instructorRepository = instRep;
            departmentRepository = deptRep;
        }

        public IActionResult Check_minDegree(int Degree, int MinDegree)
        {
            if (Degree < MinDegree)
                return Json(false);
            else return Json(true);
        }

        public IActionResult Check_hours(int CrsHours)
        {
            if (CrsHours % 3 == 0)
                return Json(true);
            else return Json(false);
        }


        public IActionResult Index([FromServices] IcourseRepository _crs, int page = 1, string search = "")
        {
            List<Course> courses = courseRepository.GetAll("Department");

            /// Search
            if (!string.IsNullOrEmpty(search))
            {
                courses = courses.Where(c => c.Name.Contains(search)).ToList();
                ViewData["search"] = search;
            }

            ////// Pagination
            int pageSize = 9;
            int total = courses.Count();

            var PaginatedList = new PaginatedList(total, page, pageSize);

            int skiped_data = (page - 1) * pageSize;

            courses = courses.Skip(skiped_data).Take(pageSize).ToList();

            ViewBag.Pager = PaginatedList;
            ViewBag.unID = courseRepository.ID;
            ViewBag.unID_2 = _crs.ID;
            return View("Index", courses);
        }



        public IActionResult Details(int id)
        {
            All_courses_viewModel all_Courses_ViewModel = new All_courses_viewModel();

            all_Courses_ViewModel.course = courseRepository.GetById(id, "Department");



            all_Courses_ViewModel.instructors = instructorRepository.GetAll().Where(I => I.CourseID == id).ToList();



            return View("details", all_Courses_ViewModel);
        }


        ///// Add ==>
        [Authorize(Roles = "Admin")]
        public IActionResult Add()
        {
            Add_new_Course_viewModel addNewCourseViewModel = new Add_new_Course_viewModel();
            addNewCourseViewModel.departments = departmentRepository.GetAll();



            return View("Add", addNewCourseViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]

        public IActionResult SaveNew(Course course)
        {
            if (ModelState.IsValid == true)
            {
                if (course.DepartmentId != 0)
                {
                    try
                    {
                        courseRepository.Insert(course);
                        courseRepository.Save();

                        return RedirectToAction("Index");
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("error", ex.InnerException.Message);

                    }


                }
            }
            Add_new_Course_viewModel addNewCourseViewModel = new Add_new_Course_viewModel();
            addNewCourseViewModel.departments = departmentRepository.GetAll();

            addNewCourseViewModel.CrsHours = course.CrsHours;
            addNewCourseViewModel.MinDegree = course.MinDegree;
            addNewCourseViewModel.Degree = course.Degree;
            addNewCourseViewModel.DepartmentId = course.DepartmentId;
            addNewCourseViewModel.Name = course.Name;
            addNewCourseViewModel.ID = course.ID;


            return View("Add", addNewCourseViewModel);




        }


        ///Edit ==>
        [Authorize(Roles = "Admin")]

        public IActionResult Edit(int id)
        {
            var course = courseRepository.GetById(id);


            ViewBag.Departments = new SelectList(departmentRepository.GetAll(), "ID", "Name");

            return View(course);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]

        public IActionResult SaveEdite(Course model)
        {
            if (ModelState.IsValid)
            {
                var courseToUpdate = courseRepository.GetById(model.ID);
                if (courseToUpdate != null)
                {
                    courseRepository.Edit(model.ID, courseToUpdate);
                    courseRepository.Save();
                }

                return RedirectToAction("Index");
            }

            // If ModelState is not valid, return the view with validation errors
            ViewBag.Departments = new SelectList(departmentRepository.GetAll(), "ID", "Name");
            return View("Edit", model);
        }




        ///Delete ==>
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            Course course = courseRepository.GetById(id);
            if (course != null)
            {
                try
                {
                    courseRepository.Delete(id);
                    courseRepository.Save();
                }
                catch (Exception ex)
                {
                    return View("ErrorView");
                }

            }
            return RedirectToAction("index");

        }
    }



}
