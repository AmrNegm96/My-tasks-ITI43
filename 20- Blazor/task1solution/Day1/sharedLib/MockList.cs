using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedLib
{
    public class MockList
    {
        public static List<Trainee> trainees = new List<Trainee>
        {
            new Trainee
            {
                Id = 1,
                Name = "Alice Lee",
                Gender = Gender.Female,
                Email = "alice.lee@example.com",
                MobileNo = "+1 (123) 456-7890",
                Birthdate = new DateTime(1995, 6, 15),
                IsGraduated = true,
                TrackId = 1 
            },
            new Trainee
            {
                Id = 2,
                Name = "Bob Johnson",
                Gender = Gender.Male,
                Email = "bob.johnson@example.com",
                MobileNo = "+1 (234) 567-8901",
                Birthdate = new DateTime(1993, 3, 8),
                IsGraduated = false,
                TrackId = 1
            },
            new Trainee
            {
                Id = 3,
                Name = "Catherine Kim",
                Gender = Gender.Female,
                Email = "catherine.kim@example.com",
                MobileNo = "+1 (345) 678-9012",
                Birthdate = new DateTime(1992, 11, 25),
                IsGraduated = true,
                TrackId = 2
            },
            new Trainee
            {
                Id = 4,
                Name = "David Chen",
                Gender = Gender.Male,
                Email = "david.chen@example.com",
                MobileNo = "+1 (456) 789-0123",
                Birthdate = new DateTime(1994, 4, 16),
                IsGraduated = false,
                TrackId = 2
            },
            new Trainee
            {
                Id = 5,
                Name = "Emma Brown",
                Gender = Gender.Female,
                Email = "emma.brown@example.com",
                MobileNo = "+1 (567) 890-1234",
                Birthdate = new DateTime(1991, 8, 3),
                IsGraduated = true,
                TrackId = 3
            },
            new Trainee
            {
                Id = 6,
                Name = "Frank Lee",
                Gender = Gender.Male,
                Email = "frank.lee@example.com",
                MobileNo = "+1 (678) 901-2345",
                Birthdate = new DateTime(1997, 1, 12),
                IsGraduated = false,
                TrackId = 3
            },
            new Trainee
            {
                Id = 7,
                Name = "Grace Wang",
                Gender = Gender.Female,
                Email = "grace.wang@example.com",
                MobileNo = "+1 (789) 012-3456",
                Birthdate = new DateTime(1996, 9, 7),
                IsGraduated = true,
                TrackId = 4
            },
            new Trainee
            {
                Id = 8,
                Name = "Henry Zhang",
                Gender = Gender.Male,
                Email = "henry.zhang@example.com",
                MobileNo = "+1 (890) 123-4567",
                Birthdate = new DateTime(1993, 12, 28),
                IsGraduated = false,
                TrackId = 4
            },
            new Trainee
            {
                Id = 9,
                Name = "Isabella Davis",
                Gender = Gender.Female,
                Email = "isabella.davis@example.com",
                MobileNo = "+1 (901) 234-5678",
                Birthdate = new DateTime(1990, 7, 19),
                IsGraduated = true,
                TrackId = 1
            }
        };

        public static List<Track> Tracks = new List<Track>
        {
            new Track { Id = 1, Name = "Web Development", Description = "Learn how to build web applications." },
            new Track { Id = 2, Name = "Mobile Development", Description = "Learn how to build mobile applications." },
            new Track { Id = 3, Name = "Data Science", Description = "Learn how to analyze and visualize data." },
            new Track { Id = 4, Name = "Cloud Computing", Description = "Learn how to deploy and manage applications in the cloud." }
        };
    }
}
