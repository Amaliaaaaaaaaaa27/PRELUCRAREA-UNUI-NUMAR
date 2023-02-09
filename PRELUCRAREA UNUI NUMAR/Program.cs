//using System;

//namespace prima_cifra_a_unui_numar;

//class math
//{

//    static void Main(string[] args )
//    {
//        int number;

//        TextPrintUsers();

//        number = int.Parse(Console.ReadLine());

//        first_digit_of_a_number(number);


//    } 
//    static void TextPrintUsers()
//    {

//        Console.WriteLine(" Type the number ");

//    }

//    static void first_digit_of_a_number(int number)
//    {

//        while(number > 9)
//        {
//            number = number / 10;

//        }
//        Console.WriteLine(number);


//    }




//}


using System;
using System.Security.Cryptography.X509Certificates;

namespace cea_mai_mare_cifra_a_unui_numar;

class math
{


    static void Main(string[] args )
    {

        int number;

        TextPrintUsers();


        number = int.Parse(Console.ReadLine());


        biggest_digit_of_a_number(number);



    }
    static void TextPrintUsers()
    {

        Console.WriteLine("Type the number");

       
    }

    static void biggest_digit_of_a_number(int number )
    {

        int x;
        int max = 0;


        while (number != 0 ) //  574  // 57 
        {

            x = number % 10; // x =  4  // 7 

            if (x >  max) // 4 >  max   // 7 > 4
            {

                max = x; //  =>  max =  4  // max =  7

                number = number / 10; // 54 / 10 =  5  // number =  57/10 = 5  
            }
            Console.WriteLine(max); // 4  // 7 


        }
    


    }
















}