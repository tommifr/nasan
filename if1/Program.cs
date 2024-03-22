// if(6>=3)
// {
//     Console.WriteLine("Hello, World!");
//     Console.ReadLine();
// }

//------------------------------------------------------------------------------------------------------

// Console.WriteLine("what is your username?");
// string username = Console.ReadLine();
// Console.WriteLine("What is your password?");
// string password = Console.ReadLine();

// if(username != "noname" || password != "nopass")
// {
//     Console.WriteLine("Wrong username or password");
// }

// Console.ReadLine(); ~


//---------------------------------------------------------------------------------------------------------

// int i=0;
// while(i<32)
// {
//     i++;
//     Console.WriteLine("Hello world");
// }
// Console.ReadLine();

// for(int i=0; i < 32; i++)
// {
//      Console.WriteLine("hellow world");
// }
// Console.ReadLine();

// -------------------------------------------------------------------------------------------------------

// Console.WriteLine("Skriv ditt lösenord");
// string password = Console.ReadLine();
// while (password!="nopass")
// {
//     Console.WriteLine("fel lösenord skriv rätt");
//     password = Console.ReadLine();
// }
//  Console.ReadLine();

// -------------------------------------------------------------------------------------------------------


// Console.WriteLine("skriv ett tal");


// for (int i = 0; i < 5; i++)
// {
//     string tal= Console.ReadLine();
//     int resultat;

//     bool lyckad = int.TryParse(tal, out resultat);
//     if ( resultat >= 5)
//     {
//         Console.WriteLine("Högre än 5!");
//     }

// }

// Console.ReadLine();
// -----------------------------------------------------------------------------------------------------

// Console.WriteLine("skriv ett tal");

// string input = Console.ReadLine();

/*
int i
string s
(while ! tryparse s out i)
    s = readline
*/

// while (!IsNumeric(input))
// {
//     Console.WriteLine("Skriv ett tal ..");
//     input = Console.ReadLine();
// }
// if (IsNumeric(input))
// {
//     Console.WriteLine("holy shit");
// }


// bool IsNumeric(string input)
// {   
//     int s;
//     if (int.TryParse(input, out s))
//         return true;

//     return false;
// }

//----------------------------------------------------------------------
// Console.WriteLine("skriv ett tal");
// int i;
// string s = "";
// while(!int.TryParse (s, out i))
// {
// s = Console.ReadLine();
// Console.WriteLine("jag sa skriv ett tal");
// }

// --------------------------------------------------------------------

// string guess;
// int i = -1;
// Console.WriteLine("skriv ett tal");

// Random randomiser = new Random();
// int tal = randomiser.Next(20);
// Console.WriteLine(tal);

// while (i != tal)
// {
//  guess = Console.ReadLine();

//     while (!int.TryParse(guess, out i))
//     {
//         Console.WriteLine("Jag sa skriv ett tal");
//         guess = Console.ReadLine();
//     }


//     if (i < tal)
//     {
//         Console.WriteLine("need bigger tal");

//     }

//     else if (i > tal)
//     {
//         Console.WriteLine("Need lower tal");
//     }



// }
 
//  Console.WriteLine("same tal");
//  Console.ReadLine();