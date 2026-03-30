namespace part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Setup the Department and Club
            Department itDept = new Department { DeptID = 1, DeptName = "IT & Sales" };
            Club companyClub = new Club { ClubID = 100, ClubName = "Tech Titans Club" };

            // 2. Create Employees
            Employee standardEmp1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1955, 5, 10), VacationStock = 10 }; // Will test Age > 60
            Employee standardEmp2 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1990, 8, 15), VacationStock = 5 };  // Will test Vacation < 0

            SalesPerson salesEmp = new SalesPerson { EmployeeID = 3, BirthDate = new DateTime(1985, 11, 20), AchievedTarget = 5000 };

            BoardMember boardEmp = new BoardMember { EmployeeID = 4, BirthDate = new DateTime(1945, 2, 28) }; // Age is over 60

            // 3. Add to Department and Club (This registers the events)
            itDept.AddStaff(standardEmp1);
            companyClub.AddMember(standardEmp1);

            itDept.AddStaff(standardEmp2);
            companyClub.AddMember(standardEmp2);

            itDept.AddStaff(salesEmp);
            companyClub.AddMember(salesEmp);

            itDept.AddStaff(boardEmp);
            companyClub.AddMember(boardEmp);

            Console.WriteLine("=============================================");
            Console.WriteLine("       LAYOFF SYSTEM SIMULATION START        ");
            Console.WriteLine("=============================================\n");

            // --- Test Case 1: Standard Employee turns 60 ---
            Console.WriteLine(">>> Test 1: Standard Employee End of Year (Age > 60)");
            // Expected: Removed from Department, but NOT removed from Club
            standardEmp1.EndOfYearOperation();
            Console.WriteLine();

            // --- Test Case 2: Standard Employee requests too much vacation ---
            Console.WriteLine(">>> Test 2: Standard Employee Vacation Request (Stock < 0)");
            // Expected: Removed from BOTH Department and Club
            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddDays(10); // Requests 10 days, only has 5
            standardEmp2.RequestVacation(startDate, endDate);
            Console.WriteLine();

            // --- Test Case 3: SalesPerson misses target ---
            Console.WriteLine(">>> Test 3: SalesPerson Checks Target (Failed Target)");
            // Expected: Removed from BOTH Department and Club
            salesEmp.CheckTarget(10000); // Quota is 10000, achieved only 5000
            Console.WriteLine();

            // --- Test Case 4: SalesPerson requests vacation ---
            Console.WriteLine(">>> Test 4: SalesPerson requests vacation (Should be ignored)");
            // Expected: Nothing happens (Vacation doesn't apply to sales)
            salesEmp.RequestVacation(startDate, endDate);
            Console.WriteLine("No layoff triggered for SalesPerson vacation.\n");

            // --- Test Case 5: Board Member End of Year ---
            Console.WriteLine(">>> Test 5: Board Member End of Year (Age > 60, Should be ignored)");
            // Expected: Nothing happens (No retiring age for board members)
            boardEmp.EndOfYearOperation();
            Console.WriteLine("No layoff triggered for Board Member age.\n");

            // --- Test Case 6: Board Member Resigns ---
            Console.WriteLine(">>> Test 6: Board Member Resigns");
            // Expected: Removed from Department, but NOT removed from Club (Board members stay in club forever)
            boardEmp.Resign();

            Console.WriteLine("\n=============================================");
            Console.WriteLine("                SIMULATION END               ");
            Console.WriteLine("=============================================");
        }
    }
}
