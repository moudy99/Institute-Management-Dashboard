using LAP.Models;

namespace LAP.ViewModel
{
    public class Trainee_courses_name_viewModel
    {
        public List<Trainee> trainees { get; set; }
        public List<Course> courses { get; set; }
        public Func<int, List<Course>> CourseSelector { get; set; }
        public Func<string, int> getById { get; set; }



        public Trainee_courses_name_viewModel(Func<int, List<Course>> courseSelector, Func<string, int> getById)
        {
            CourseSelector = courseSelector;
            this.getById = getById;
        }
    }
}
