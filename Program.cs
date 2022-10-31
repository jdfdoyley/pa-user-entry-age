/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: October 30, 2022
* Assignment CIS214 Performance Assessment - User Entry of Age
*
* Main application (program) class
* Print a line that states "Your Name - Week 4 PA User Entry of Age"
* Ask the user to enter their age
* If the age is between 1 and 100
*   print a message stating the age the user entered
*   exit the program
* If the age is less than 1 or greater than 100
*   generate an ArgumentOutOfRangeException
*   print the exception information
*   print an error message
* If the value is not an integer
*   handle the FormatException
*   print the exception information
*   print an error message
* Continue asking the user to enter their age until a valid age is entered
\******************************************************************************/
public class Program
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "\nJason D'Oyley - Week 4 PA - User Entry of Age\n"
        );

        do
        {
            try
            {
                Console.Write("Please enter your age: ");
                string? val = Console.ReadLine();
                int age = Convert.ToInt32(val);

                // If the age is less than 1 or greater than 100 generate an
                // ArgumentOutOfRangeException
                if (age < 1 || age > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine($"\nThe age you entered is: {age}");

                break; // Break out of the look if the program make it this far
            }
            catch (FormatException e)
            {
                // If the value is not an integer handle the FormatException
                // Print the exception information and an error message
                Console.WriteLine(e);
                Console.WriteLine(
                    "Please enter an integer in range 1 - 100.\n"
                );
            }
            catch (ArgumentOutOfRangeException e)
            {
                // Print the exception information and an error message
                Console.WriteLine(e);
                Console.WriteLine(
                    "Please enter an integer in range 1 - 100.\n"
                );
            }
        } while (true);
    }
}