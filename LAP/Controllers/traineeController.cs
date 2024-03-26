using LAP.Models;
using LAP.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static LAP.ViewModel.All_Trainee_results_viewModel;
namespace LAP.Controllers
{
    [Authorize]
    public class traineeController : Controller
    {
        private Context context;
        public traineeController([FromServices] Context con)
        {
            context = con;
        }
        public IActionResult Index(string search = "", int page = 1)
        {
            List<Trainee> trainees = context.Trainees.ToList();


            /// Search
            if (!string.IsNullOrEmpty(search))
            {
                trainees = trainees.Where(c => c.Name.Contains(search)).ToList();
                ViewData["search"] = search;

            }

            ////// Pagination
            int pageSize = 6;
            int total = trainees.Count();

            var PaginatedList = new PaginatedList(total, page, pageSize);

            int skiped_data = (page - 1) * pageSize;

            trainees = trainees.Skip(skiped_data).Take(pageSize).ToList();

            ViewBag.Pager = PaginatedList;





            Trainee_courses_name_viewModel index_viewModel = new Trainee_courses_name_viewModel(query, byID);



            index_viewModel.trainees = trainees;

            return View("Index", index_viewModel);
        }

        public IActionResult Details(int train_id, int crs_id)
        {

            //int crs_id_int = byID(crs_id);
            Trainee_Course_Result_viewModel course_result = new Trainee_Course_Result_viewModel();
            var data = context.CrsResults
                .Include(crsResult => crsResult.Trainee)
                .Include(crsResult => crsResult.Course)
                .Where(crsResult => crsResult.Trainee.ID == train_id && crsResult.Course.ID == crs_id)
                .Select(crsResult => new
                {
                    TraineeName = crsResult.Trainee.Name,
                    CourseName = crsResult.Course.Name,
                    TraineeDegree = crsResult.degree,
                    CourseMinDegree = crsResult.Course.MinDegree
                })
                .FirstOrDefault();



            course_result.couresMinDrgree = data.CourseMinDegree;
            course_result.TraineeDegree = (int)data.TraineeDegree;
            course_result.TraineeName = data.TraineeName;
            course_result.CourseName = data.CourseName;

            if (data.TraineeDegree >= data.CourseMinDegree)
            {
                course_result.color = "Green";
                course_result.image = "right.jpg";
            }
            else
            {
                course_result.color = "Red";
                course_result.image = "wrong.jpg";

            }



            return View("Details", course_result);
        }

        public IActionResult TraineeResults(int id)
        {
            All_Trainee_results_viewModel resultViewModel = new All_Trainee_results_viewModel();

            var trainee = context.Trainees.FirstOrDefault(t => t.ID == id);

            resultViewModel.TraineeName = trainee.Name;

            resultViewModel.Courses = context.CrsResults
                                     .Where(crsResult => crsResult.Trainee.ID == id)
                                     .Select(crsResult => new course_info
                                     {
                                         CourseName = crsResult.Course.Name,
                                         TraineeDegree = crsResult.degree,
                                         CourseMinDegree = crsResult.Course.MinDegree,
                                         Color = crsResult.Course.MinDegree > crsResult.degree ? "Red" : "Green",
                                         Image = crsResult.Course.MinDegree > crsResult.degree ? "Wrong.jpg" : "right.jpg"
                                     })
                                     .GroupBy(course => course.CourseName)
                                     .Select(group => group.First())
                                     .ToList();



            return View(resultViewModel);
        }



        public List<Course> query(int id)
        {
            List<Course> courses = (from crs in context.CrsResults
                                    where crs.Trainee.ID == id
                                    join c in context.Course on crs.Course.ID equals c.ID
                                    select c).Distinct().ToList();

            return courses;
        }

        public int byID(string name)
        {
            int id = 0;

            id = context.Course.Where(c => c.Name == name).FirstOrDefault().ID;


            return id;
        }



    }
}
