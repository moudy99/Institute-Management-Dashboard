namespace LAP.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int salary { get; set; }
        public string Address { get; set; }


        public int DepartmentID { get; set; }
        public int CourseID { get; set; }


        /// <summary>
        /// Navigation Prop -->
        /// </summary>

        public virtual Course Course { get; set; }
        public virtual Department Department { get; set; }
    }
}
