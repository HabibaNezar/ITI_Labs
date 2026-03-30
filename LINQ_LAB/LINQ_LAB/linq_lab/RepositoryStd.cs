using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_lab
{
    internal class RepositoryStd
    {
        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1,  FirstName = "Ahmed",   LastName = "Ali",     Age = 26, Salary = 3000,  TrackId = 1  },
                new Student { Id = 2,  FirstName = "Mohamed", LastName = "Hassan",  Age = 32, Salary = 6000,  TrackId = 1  },
                new Student { Id = 3,  FirstName = "Sara",    LastName = "Khaled",  Age = 28, Salary = 4500,  TrackId = 2  },
                new Student { Id = 4,  FirstName = "Omar",    LastName = "Mostafa", Age = 35, Salary = 7000,  TrackId = 3  },
                new Student { Id = 5,  FirstName = "Mona",    LastName = "Sayed",   Age = 26, Salary = 2500,  TrackId = 1  },
                new Student { Id = 6,  FirstName = "Amr",     LastName = "Fawzy",   Age = 40, Salary = 9000,  TrackId = 4  },
                new Student { Id = 7,  FirstName = "Nada",    LastName = "Ibrahim", Age = 27, Salary = 4000,  TrackId = 2  },
                new Student { Id = 8,  FirstName = "Karim",   LastName = "Tarek",   Age = 31, Salary = 5500,  TrackId = 5  },
                new Student { Id = 9,  FirstName = "Layla",   LastName = "Adel",    Age = 26, Salary = 3800,  TrackId = 8  },
                new Student { Id = 10, FirstName = "Hassan",  LastName = "Walid",   Age = 29, Salary = 5000,  TrackId = 10 },
                new Student { Id = 11, FirstName = "Samira",  LastName = "Nour",    Age = 33, Salary = 6500,  TrackId = 8  },
                new Student { Id = 12, FirstName = "Mahmoud", LastName = "Saad",    Age = 25, Salary = 4200,  TrackId = 1  },
            };
        }
        
        public static List<Track> GetTracks()
        {
            return new List<Track>
            {
                new Track { TrackId = 1,  TrackName = "Full Stack .NET"    },
                new Track { TrackId = 2,  TrackName = "Front End"          },
                new Track { TrackId = 3,  TrackName = "Back End Java"      },
                new Track { TrackId = 4,  TrackName = "Data Science"       },
                new Track { TrackId = 5,  TrackName = "Cyber Security"     },
                new Track { TrackId = 8,  TrackName = "Mobile Development" },
                new Track { TrackId = 10, TrackName = "DevOps"             }

            };
        }
    }
}
