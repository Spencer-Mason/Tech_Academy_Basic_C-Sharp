using CodeFirstNewDatabaseSample;

using (var ctx = new SchoolContext())
{
    var student = new Student() { StudentName = "New Student" };
    ctx.Students.Add(student);
    ctx.SaveChanges();
}