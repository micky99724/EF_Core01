
using EF_Core.Context;
using EF_Core.Entities;
using Microsoft.EntityFrameworkCore;

ITIDbContext context = new ITIDbContext();

// iTIDbContext.Database.Migrate();
#region Create &Update Operations

var department = new Department
{
    Name = "Computer Science"
};
context.Department.Add(department);
context.SaveChanges();


var instructor = new Instructor
{
    Name = "Dr.Mina",
    Bouns = 5000,
    Salary = 80000,
    Address = "22B Agoza St",
    HourRate = 50,
    Dep_ID = department.ID
};
context.Instructor.Add(instructor);
context.SaveChanges();
Console.WriteLine("Instructor added.");


department.Ins_ID = instructor.ID;
context.Department.Update(department);
context.SaveChanges();
Console.WriteLine("Department head set.");


var course = new Course
{
    Name = "Introduction to C#",
    Duration = 3 * 30 * 24 * 60 * 60 // as for 3 months
};
context.Course.Add(course);
context.SaveChanges();
Console.WriteLine("Course added.");


var courseInst = new Course_Inst
{
    Course_ID = course.ID,
    Inst_ID = instructor.ID
};
context.Course_Inst.Add(courseInst);
context.SaveChanges();

var student = new Student
{
    FName = "Michael",
    LName = "Raafat",
    Address = "13 Dokki St",
    Age = 24,
    Dep_Id = department.ID
};
context.Student.Add(student);
context.SaveChanges();

var studCourse = new Stud_course
{
    Stud_ID = student.ID,
    Course_ID = course.ID
};
context.Stud_Course.Add(studCourse);
context.SaveChanges();


#endregion

#region Retrive Or select Operations

department = context.Department
                       .Include(d => d.Students)
                       .Include(d => d.Instructor)
                       .FirstOrDefault();
if (department != null)
{
    Console.WriteLine($"Department: {department.Name}");
    Console.WriteLine("Students:");
    foreach (var stud in department.Students)
    {
        Console.WriteLine($"- {stud.FName} {stud.LName}");
    }
    Console.WriteLine("Instructors:");
    foreach (var inst in department.Instructor)
    {
        Console.WriteLine($"- {inst.Name}");
    }
}
#endregion

#region Delete Operations

context.Student.Remove(student);
context.SaveChanges();

context.Course.Remove(course);
context.SaveChanges();

context.Instructor.Remove(instructor);
context.SaveChanges();

context.Department.Remove(department);
context.SaveChanges();

#endregion