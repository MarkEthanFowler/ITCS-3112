// See https://aka.ms/new-console-template for more information
using GPACalculator;

int looper = 0;
while(looper == 0)
{
    Console.WriteLine("Welcome to your GPA Calcualtor app!");
    Console.WriteLine("Please enter y to continue");
    String menuChoice = Console.ReadLine();
    if(menuChoice == "y")
    {
        break;
    }
    else
    {
        Console.WriteLine("Please enter y to continue.");
    }
}

Console.WriteLine("How many semesters have you complete?");
String semesterInput = Console.ReadLine();

List<Grade> courses = new List<Grade>();

int semesters = int.Parse(semesterInput);
for(int i = 1; i <= semesters; i++)
{
    Console.WriteLine("How many classes did you take in semester " + i + "?");
    String classInput = Console.ReadLine();
    int classes = int.Parse(classInput);
    for(int j = 1; j <= classes; j++)
    {
        Grade grade = new Grade();
        Console.WriteLine("How many credit hours was class " + j + "?");
        String creditInput = Console.ReadLine();
        int credits = int.Parse(creditInput);
        grade.setCreditHours(credits);

        Console.WriteLine("What was the letter grade for class " + j + "?");
        String letterGradeInput = Console.ReadLine();
        grade.setLetterGrade(letterGradeInput);

        courses.Add(grade);
    }
}

Console.WriteLine(courses.Capacity);
