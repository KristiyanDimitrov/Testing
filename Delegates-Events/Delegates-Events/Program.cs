using System;

namespace Delegates_Events
{
    class Program
    {
        #region basic delegates
        // BASIC DELEGATES
        public delegate double PerformCalculation(double x, double y);

        public static double Addition (double a, double b)
        {
            Console.WriteLine("a + b = " + (a+b));
            return a + b;
        }

        public static double Division(double a, double b)
        {
            Console.WriteLine("a / b = " + (a / b));
            return a / b;
        }

        public static double Substraction (double a, double b)
        {
            Console.WriteLine("a - b = " + (a - b));
            return a - b;
        }
        #endregion

        #region anonymos method delegates
        // ANONYMOS METHODS
        public delegate string sayHi(string name);
        #endregion

        static void Main(string[] args)
        {
            #region basic
            // BASIC DELEGATES
            Console.WriteLine("Additon only");
            PerformCalculation getsum = Addition;
            getsum(5.5, 5.5);

            Console.WriteLine("Division only");
            PerformCalculation getDivison = Division;
            getsum(3.5, 3.5);
             
            Console.WriteLine("Combined");
            PerformCalculation multicalc = getsum + getDivison;
            multicalc += Substraction;
            multicalc(4.5, 4.5);
            #endregion

            #region anonymos method
            // ANONYMOS METHODS 
            string testAccess = "test";
            sayHi SayHi = delegate (string name)
            {
                return "Hello " + name + "This is a " + testAccess; // Can access outside variables, doesn't run under its own scope? 
            };
            
            Console.WriteLine(SayHi("Kris"));

            // passing as a parameter
            Display(SayHi);

            /* ?????
             * An anonymous method does not contain jump statements like goto, break, or continue.
             * An anonymous method does not access unsafe code.
             * An anonymous method does not access in, ref, and out parameter of the outer scope.
             * You can not use an anonymous method to the left side of the is operator.
             * The anonymous-method-block means the scope of the parameters in the anonymous method.
             */

            // can't contain go-to, break or contionue ?
            sayHi SayHiFirstName = delegate (string name)
            {
                string firstName = String.Empty;
                char tmp;

                for (int i = 0; i < name.Length; i++)
                {
                    tmp = name[i];
                    if (tmp != ' ')
                        firstName += tmp;
                    else
                        break;
                }

                return "Hello " + firstName;
            };

            DisplayFirstName(SayHiFirstName);
            #endregion

            #region labda

            // LAMBDA EXPRESSIONS
            sayHi SayHiCasual = (string name) => { return "Hey " + name; };

            //shorter version. Doesn't work with more than one variable..... 
            sayHi SayHiVeryCasual = name => "Sup " + name;

            #endregion

            Console.ReadKey();
        }

        #region basic method delegate
        // passing as a parameter
        static void Display(sayHi SayHiDel)
        {
            Console.WriteLine(SayHiDel("World"));
        }
        #endregion

        #region anonymos methods delegates
        // passing as a parameter
        static void DisplayFirstName(sayHi SayHiDel)
        {
            Console.WriteLine(SayHiDel("Kristiyan Dimitrov"));
        }
        #endregion


    }
}
