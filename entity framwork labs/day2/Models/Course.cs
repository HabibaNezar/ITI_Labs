using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace day2.Models
{
	internal class Course
	{
		[Key]
		public int Crs_Id { get; set; }
		public string Crs_Name { get; set; }
		public int Crs_Duration { get; set; }

		/*--------------------------------------------------*/
		// relation
		/*--------------------------------------------------*/
		[ForeignKey("Topic")]
        public int Top_Id { get; set; }
		public Topic Topic { get; set; }
    }
}