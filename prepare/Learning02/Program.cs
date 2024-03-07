using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Legal Assistant";
        job1._company = "Arizona Consumer Law Group";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Graphic Designer";
        job2._company = "Cerifi";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Kohler Pratt";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}