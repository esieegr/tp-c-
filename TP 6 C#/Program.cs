using Microsoft.EntityFrameworkCore;
using TP_6_C_;

using var db = new SchoolContext();


/*
// Initialisation
db.Students.Add(new TP_6_C_.Models.Student { FirstName = "Alice", LastName = "Dupont", Age = 21 });
db.Students.Add(new TP_6_C_.Models.Student { FirstName = "Raoule", LastName = "Maboule", Age = 47 });
*/

db.SaveChanges();

var students = db.Students.ToList();



foreach (var student in students)
{
    Console.WriteLine($"{student.Id} - {student.FirstName} {student.LastName}, {student.Age} ans");
}

/*
// Modifier un âge
var user = db.Students.First();

user.Age = 18;

db.SaveChanges();
*/

/*
// Supprimer la bdd
db.Students.RemoveRange(db.Students);
db.SaveChanges();
*/


//db.Courses.Add(new TP_6_C_.Models.Course { Title = "Mathématique", Credits = "36" });
//db.Courses.Add(new TP_6_C_.Models.Course { Title = "Histoire", Credits = "48" });

var courses = db.Courses.ToList();

foreach (var course in courses)
{
    Console.WriteLine($"{course.Id} - {course.Title} Credits : {course.Credits}");
}

//db.Database.EnsureCreated();
db.SaveChanges();





