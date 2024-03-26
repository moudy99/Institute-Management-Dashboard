namespace LAP.ViewModel
{
	public class All_Trainee_results_viewModel
	{
		public string TraineeName { get; set; }
		public List<course_info> Courses { get; set; }


		public class course_info
		{
			public string CourseName { get; set; }
			public int TraineeDegree { get; set; }
			public int CourseMinDegree { get; set; }
			public string Color { get; set; }
			public string Image { get; set; }
		}

	}
}

