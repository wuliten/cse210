using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "CEO";
        job2._company = "Apple";
        job2._startYear = 2026;
        job2._endYear = 2050;


        Resume bryanBorst = new Resume();
        bryanBorst._personName = "Bryan Borst";
        bryanBorst._jobs.Add(job1);
        bryanBorst._jobs.Add(job2);

        bryanBorst.DisplayResume();
    }
}