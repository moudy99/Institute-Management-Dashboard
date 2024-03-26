namespace LAP.Models
{

    public class Trainee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }


        /// <summary>
        /// Navigation Prop -->
        /// </summary>
        public virtual Department Department { get; set; }
        public virtual ICollection<CrsResult> CrsResults { get; set; }
    }
}