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
List<Grade> courses = new List<Grade>();

try
{
    
    Console.WriteLine("How many semesters have you complete?");
    String semesterInput = Console.ReadLine();
    
    while (semesterInput != "1" && semesterInput != "2" && semesterInput != "3" && 
           semesterInput != "4" && semesterInput != "5" && semesterInput != "6" && 
           semesterInput != "7" && semesterInput != "8" && semesterInput != "9")
    {
        Console.WriteLine("Invalid Input, please enter the number of semesters.");
        semesterInput = Console.ReadLine();
    }
    int semesters = int.Parse(semesterInput);



    for (int i = 1; i <= semesters; i++)
    {
        Console.WriteLine("How many classes did you take in semester " + i + "?");
        String classInput = Console.ReadLine();

        while(classInput != "1" && classInput != "2" && classInput != "3" && 
              classInput != "4" && classInput != "5" && classInput != "6" && 
              classInput != "7" && classInput != "8" && classInput != "9")
        {
            Console.WriteLine("Invalid input, please enter the number of classes for semester " + i);
            classInput = Console.ReadLine();
        }
        int classes = int.Parse(classInput);
        for (int j = 1; j <= classes; j++)
        {
            Grade grade = new Grade();
            Console.WriteLine("How many credit hours was class " + j + "?");
            String creditInput = Console.ReadLine();

            while(creditInput != "1" && creditInput != "2" && creditInput != "3" && creditInput != "4" && creditInput != "5")
            {
                Console.WriteLine("Invalid input, please enter the credit hours associated with class " + j);
                creditInput = Console.ReadLine();
            }

            int credits = int.Parse(creditInput);
            grade.setCreditHours(credits);

            Console.WriteLine("What was the letter grade for class " + j + "?");
            String letterGradeInput = Console.ReadLine();

            while(letterGradeInput != "A" && letterGradeInput != "B" && letterGradeInput != "C" && letterGradeInput != "D" && 
                  letterGradeInput != "F" && letterGradeInput != "a" && letterGradeInput != "b" && letterGradeInput != "c" && 
                  letterGradeInput != "d" && letterGradeInput != "f")
            {
                Console.WriteLine("Invalid input please enter the letter grade associated with class " + j);
                letterGradeInput = Console.ReadLine();
            }

            grade.setLetterGrade(letterGradeInput);

            courses.Add(grade);
        }
    }
}
catch(Exception e)
{
    Console.WriteLine("Error: " + e);
}




float creditHours = 0;
float gradePoints = 0;

for(int i = 0; i < courses.Count; i++)
{
    if (courses[i].getLetterGrade() == "A" || courses[i].getLetterGrade() == "a")
    {
        gradePoints += (courses[i].getCreditHours() * 4);
        creditHours += courses[i].getCreditHours();
    }
    else if(courses[i].getLetterGrade() == "B" || courses[i].getLetterGrade() == "b")
    {
        gradePoints += (courses[i].getCreditHours() * 3);
        creditHours += courses[i].getCreditHours();
    }
    else if (courses[i].getLetterGrade() == "C" || courses[i].getLetterGrade() == "c")
    {
        gradePoints += (courses[i].getCreditHours() * 2);
        creditHours += courses[i].getCreditHours();
    }
    else if (courses[i].getLetterGrade() == "D" || courses[i].getLetterGrade() == "d")
    {
        gradePoints += (courses[i].getCreditHours() * 1);
        creditHours += courses[i].getCreditHours();
    }
    else if (courses[i].getLetterGrade() == "F" || courses[i].getLetterGrade() == "f")
    {
        gradePoints += (courses[i].getCreditHours() * 0);
        creditHours += courses[i].getCreditHours();
    }
    else {}
}

Console.WriteLine("\nGPA: " + (gradePoints / creditHours));
