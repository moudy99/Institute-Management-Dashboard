namespace LAP.Models
{
    public class CrsResult
    {
        public int ID { get; set; }
        public int degree { get; set; }


        ///// Navigation prop -->

        public Course Course { get; set; }
        public Trainee Trainee { get; set; }

    }
}
