using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job {
            _jobTitle = "Application Developer",
            _company = "Nellis Auction",
            _startYear = 2023,
            _endYear = 2025
        };

        Job job2 = new Job {
            _jobTitle = "Construction Worker",
            _company = "Orange Street Mechanical",
            _startYear = 2022,
            _endYear = 2023
        };

        Resume myResume = new Resume {
            _name = "Denton Flake",
            _jobs = {
                job1,
                job2
            }
        };

        myResume.Display();
    }
}