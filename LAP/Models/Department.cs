namespace LAP.Models
{
    public class Department
    {
        public int ID { get; set; }


        public string Name { get; set; }

        public string Manger { get; set; }


        /// <summary>
        /// Navigation Property ==> 
        /// </summary>
        public virtual ICollection<Instructor> instructors { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
