Console.WriteLine("****************** - Arrays - *******************");

// Tell me how many students and grades are to be entered 
Console.WriteLine("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

// Declare Fixed Size Array
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];

for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter Student Name: ");
    students[i] = Console.ReadLine();

    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Declare Variable Sized Array
//string[] studentNames = { "Newton", "Joshua", "etc..." };

// Print values in Fixed Size Array
Console.WriteLine("The student names you have entered are: ");

// Print values in Variable Sized Array
for (int i = 0; i < numberOfGrades; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

// Print values in list - Foreach
// foreach (int g in grades){
//      Console.WriteLine(g);
// }