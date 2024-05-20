Console.WriteLine("****************** - Arrays - *******************");

// Declare Fixed Size Array
int[] grades = new int[5];

for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The Grades you have entered are: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

// Declare Variable Sized Array
string[] studentNames = { "Newton", "Joshua", "etc..." };

// Add values to Fixed Size Array
for (int i = 0; i < studentNames.Length; i++) 
{
    Console.Write("Enter Student Name: ");
    studentNames[i] = Console.ReadLine();
}

// Print values in Fixed Size Array
Console.WriteLine("The student names you have entered are: ");

// Print values in Variable Sized Array
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}
