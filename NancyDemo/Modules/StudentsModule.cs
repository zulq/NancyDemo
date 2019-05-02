using Microsoft.EntityFrameworkCore;
using Nancy;
using NancyDemo.Data;

namespace NancyDemo.Modules
{
    public class StudentsModule : NancyModule
    {
        public StudentsModule(DemoDbContext context) : base("/students")
        {
            Get("/", async (_, ct) =>
            {
                var students = await context.Students.ToListAsync();
                return Response.AsJson(students);
            });
        } 
    }
}