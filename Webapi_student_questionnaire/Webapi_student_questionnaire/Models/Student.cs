using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using Webapi_student_questionnaire.Models;

namespace Webapi_student_questionnaire.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? StudentNumber { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<Response> Responses { get; set; } = new List<Response>();

    public virtual ICollection<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
}


public static class StudentEndpoints
{
	public static void MapStudentEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Student").WithTags(nameof(Student));

        group.MapGet("/", async (AnketContext db) =>
        {
            return await db.Students.ToListAsync();
        })
        .WithName("GetAllStudents")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Student>, NotFound>> (int studentid, AnketContext db) =>
        {
            return await db.Students.AsNoTracking()
                .FirstOrDefaultAsync(model => model.StudentId == studentid)
                is Student model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetStudentById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int studentid, Student student, AnketContext db) =>
        {
            var affected = await db.Students
                .Where(model => model.StudentId == studentid)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.StudentId, student.StudentId)
                  .SetProperty(m => m.FirstName, student.FirstName)
                  .SetProperty(m => m.LastName, student.LastName)
                  .SetProperty(m => m.StudentNumber, student.StudentNumber)
                  );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateStudent")
        .WithOpenApi();

        group.MapPost("/", async (Student student, AnketContext db) =>
        {
            db.Students.Add(student);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Student/{student.StudentId}",student);
        })
        .WithName("CreateStudent")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int studentid, AnketContext db) =>
        {
            var affected = await db.Students
                .Where(model => model.StudentId == studentid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteStudent")
        .WithOpenApi();
    }
}