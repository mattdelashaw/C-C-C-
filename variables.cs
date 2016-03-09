using System;
namespace VariableDefinition 
{
   class Program 
   {
      static void Main(string[] args) 
      {
         short a = 10;
         int b = 20;
         double c;
		 int d = 3, f = 5;    /* initializing d and f. */
		 byte z = 22;         /* initializes z. */
		 double pi = 3.14159; /* declares an approximation of pi. */
		 char x = 'x';        /* the variable x has the value 'x'. */
		 

         /* actual initialization 
         a = 10;
         b = 20;*/
         c = a + b;
         Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
         Console.ReadLine();
      }
   }
}
