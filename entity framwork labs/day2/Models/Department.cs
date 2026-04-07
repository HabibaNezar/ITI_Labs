using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace day2.Models
{
	internal class Department
	{
		[key]
        public int Dept_Id { get; set; }
		public string Dept_Name { get; set; }
		public string Dept_Desc { get; set; }
		public string Dept_Location { get; set; }
		public Date Manager_hiredate { get; set; }

		/*--------------------------------------------------*/
		// relation
		/*--------------------------------------------------*/

	}
}