using System;

class GradeCalc
{
    static void Main()
    {
        double studentGrade;
        string letterGrade;
        while (true)
        {
            Console.WriteLine("Please enter your grade as a percentage between 0 and 100: ");
            string numberGrade = Console.ReadLine();

            if (double.TryParse(numberGrade, out studentGrade) && studentGrade >= 0 && studentGrade <= 100)
            {

                if (studentGrade >= 90)
                {
                    letterGrade = "A";
                }
                else if (studentGrade >= 80)
                {
                    letterGrade = "B";
                }
                else if (studentGrade >= 70)
                {
                    letterGrade = "C";
                }
                else if (studentGrade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }
                {
                    Console.WriteLine("The grade you entered is " + studentGrade + "%, which is a letter grade of " + letterGrade + ".");
                }
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid grade between 0 and 100.");
            }
        }
    }
}