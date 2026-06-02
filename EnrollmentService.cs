public class EnrollmentService
{
    public EnrollmentRecord ProcessRegistration(Student? student, Course? course)
    {
// TODO 1: Add guard clauses fail fast if student is null, course is null,
        if (student is null)
            throw new ArgumentNullException(nameof(student));

        if (course is null)
            throw new ArgumentNullException(nameof(course));

        if (course.Capacity <= 0)
            throw new InvalidOperationException("Course is full.");

// TODO 2: Use a switch expression on student.GPA to classify academic standing:
        string standing = student.GPA switch
        {
            >= 3.5m => "Honors",
            >= 2.5m => "Good Standing",
            _ => "Academic Warning"
        };
        
        Console.WriteLine($"{student.Name} is in {standing}.");

// TODO 3: Return a new EnrollmentRecord with student.Id, course.Code,and DateTime.UtcNow
        return new EnrollmentRecord(
            student.Id,
            course.Code,
            DateTime.UtcNow
        );
    }
}