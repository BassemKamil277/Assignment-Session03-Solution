using System.Reflection.Metadata;

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1-Write a program that allows the user to enter a number then print it.

            //#region Q1 - Write a program that allows the user to enter a number then print it.
            //Console.Write("enter your number : ");
            //string number = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine($"your number is : {number}");

            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //string name = "bassem";
            //int number = Convert.ToInt32(name);
            //Console.WriteLine(number);
            // make exeption beacause can't covert digit top intger  

            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float a = 0.1f;
            //float b = 0.2f;
            //float result = a + b;

            //Console.WriteLine("Result of a + b = " + result);   


            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.
            //string A = "Hello world!";
            //string B = A.Substring(0,5);

            //Console.WriteLine(A);
            //Console.WriteLine(B);


            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int A = 10;
            //long B = A; // implicit casting will happen 
            //A = 20; // B don't change to new A value 
            //Console.WriteLine("A = "A);
            //Console.WriteLine("B = "B);

            //long c = 10;
            //int d = (int) c; // explicitt casting will happen 
            //c = 20; // d don't change to new c value 
            //Console.WriteLine("c = "c);
            //Console.WriteLine("d = " d);



            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //string s1 = "Hello";
            //string s2 = s1;  // s2 points to the same string as s1


            //Console.WriteLine("s1 = " + s1);  // Hello
            //Console.WriteLine("s2 = " + s2);  // Hello

            //s2 = "World";

            //Console.WriteLine("s1 = " + s1);  // Hello
            //Console.WriteLine("s2 = " + s2);  // World

            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 
            //string s1 = "bassem";
            //string s2 = "kamil";
            //string s3 = s1 +' '+ s2;
            //Console.WriteLine(s3);

            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.
            //Console.Write("Enter the principal amount: ");
            //double P = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the rate of interest: ");
            //double R = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the time (in years): ");
            //double T = Convert.ToDouble(Console.ReadLine());

            //double interest = (P * R * T) / 100;
            //Console.WriteLine(interest);

            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            //Console.Write("enter your weight : ");
            //float weight = float.Parse(Console.ReadLine());

            //Console.Write("enter your height : ");
            //float height = float.Parse(Console.ReadLine());

            //float BMI = (weight) / (height * height);
            //Console.WriteLine("BMI = " + BMI);
            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"
            //Console.Write("enter the temperature : ");
            //int temperature = int.Parse(Console.ReadLine());

            //string Message = temperature < 10 ? "Just Cold" :
            //                 temperature > 30 ? "Just Hot" :
            //                  "Just Good";
            //Console.WriteLine(Message);
            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001
            ///

            // 1
            //Console.WriteLine("enter tha date");
            //string input = Console.ReadLine();
            //DateTime date;
            //bool T =  DateTime.TryParse(input, out date);

            //if (T)
            //{
            //    int D = date.Day;
            //    int M = date.Month;
            //    int Y = date.Year;
            //    Console.WriteLine($"\nToday's date : {D} , {M} , {Y}");
            //    Console.WriteLine($"Today's date : {D} / {M} / {Y}");
            //    Console.WriteLine($"Today's date : {D} – {M} – {Y}");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}



            //2
            //Console.Write("enter the day: ");
            //int D = int.Parse(Console.ReadLine());

            //Console.Write("enter the month : ");
            //int M = int.Parse(Console.ReadLine());

            //Console.Write("enter the year : ");
            //int Y  = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\nToday's date : {D} , {M} , {Y}");
            //Console.WriteLine($"Today's date : {D} / {M} / {Y}");
            //Console.WriteLine($"Today's date : {D} – {M} – {Y}");


            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No

            //    Console.Write("inter your number : ");
            //    int num = int.Parse(Console.ReadLine());

            //if(num%3 == 0 && num % 4 ==0 ) 
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //else
            //    {
            //        Console.WriteLine("No");
            //    }

            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive
            ///

            //Console.Write("inter your number : ");
            //int num = int.Parse(Console.ReadLine());

            //if(num > 0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else
            //{
            //    Console.WriteLine("negative");
            //}




            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3

            //Console.Write("inter your number 1 : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("inter your number 2 : ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("inter your number 3 : ");
            //int c = int.Parse(Console.ReadLine());

            //int max = Math.Max(a, Math.Max(b, c));  //self learning 
            //int min = Math.Min(a, Math.Min(b, c));


            //Console.WriteLine($"max element = {max}");
            //Console.WriteLine($"min element = {min}");

            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("inter your number  : ");
            //int a = int.Parse(Console.ReadLine());

            //if (a %2 == 0)
            //{
            //    Console.WriteLine("the number is even");
            //}
            //else
            //{
            //    Console.WriteLine("the number is odd");
            //}

            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant

            //Console.Write("inter your char : ");
            //char ch = char.Parse(Console.ReadLine());

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}
            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31

            //Console.Write("enter month number : ");
            //int num = int.Parse(Console.ReadLine());

            //switch (num)
            //{
            //    case 1: Console.WriteLine("31");
            //        break;
            //    case 2:
            //        Console.WriteLine("28");
            //        break;
            //    case 3:
            //        Console.WriteLine("31");
            //        break;
            //    case 4:
            //        Console.WriteLine("30");
            //        break;
            //    case 5:
            //        Console.WriteLine("31");
            //        break;
            //    case 6:
            //        Console.WriteLine("30");
            //        break;
            //    case 7:
            //        Console.WriteLine("31");
            //        break;
            //    case 8:
            //        Console.WriteLine("31");
            //        break;
            //    case 9:
            //        Console.WriteLine("30");
            //        break;
            //    case 10:
            //        Console.WriteLine("31");
            //        break;
            //    case 11:
            //        Console.WriteLine("30");
            //        break;
            //    case 12:
            //        Console.WriteLine("31");
            //        break;
            //    default : Console.WriteLine("invalid number");
            //        break;
            //}

                #endregion

        }
    }
}

