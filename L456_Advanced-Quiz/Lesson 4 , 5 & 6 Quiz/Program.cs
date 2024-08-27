
/*
Question 1:
BMI Calculation

The Body Mass Index (BMI) of a person is calculated based on the following formula: 
BMI = weight / (height x height)

Note:
- weight is in kilograms (e.g. 65.0)
- height is in metres (e.g. 1.70)

Write a C# program to:
- prompt the user to enter his/her weight and height
- calculate the BMI (body mass index)
- display the BMI and the health category according to the table below:

BMI Health category
Below 18.5    Underweight
18.5 - 23     Normal weight
23 - 27.5     Overweight
Above 27.5    Obese
*/

/*
Question 2:
Discount Calculation [using if..else]

The discount rate given by a shopping mall is shown below:
----------------------------------------------
| Amount spent ($)      |  Discount Rate (%) |
| 100 and below         |        0           |
| 100 < amount <= 500   |        5           |
| 500 < amount <= 1000  |       10           |
| Above 1000            |       20           |
----------------------------------------------
Write a C# program to:
- prompt the user to enter the amount spent 
- calculate and display the discount given (in percentage)
- calculate and display the discount amount
*/

/*
Question 3:
Multiplication Table [using repetition structure]

Write a C# program to display the multiplication table for a given number from 1 to 12.

Example:
Enter a number : 8
1  8
2  16
3  24
4  32
5  40
6  48
7  56
8  64
9  72
10 80
11 88
12 96
*/

/*
Question 4:
Admin Menu [using methods, loop & nested if]

Write a C# program that displays the main menu and allows the user to select options to perform BMI calculation, discount calculation, or display a multiplication table. The program should repeatedly display the menu until the user chooses to exit.

Example:
------------- MENU --------------
[1] Calculate Body Mass Index
[2] Calculate Discount
[3] Display Multiplication Table
[0] Exit
---------------------------------
*/


// class Program
// {

//     static void CalculateBMI(){
//         Console.Write("Enter your weight(kg): ");
//         float weight = float.Parse(Console.ReadLine());
//         Console.Write("Enter your height(m): ");
//         float height = float.Parse(Console.ReadLine());

//         float BMI = weight / (height * height);

//         Console.WriteLine($"Your BMI is: {Math.Round(BMI, 2)}");


//         if(BMI < 18.5){
//             Console.WriteLine("Underweight");

//         }else if(BMI >= 18.5 && BMI <= 23){
//             Console.WriteLine("Normal weight");


//         }else if(BMI >= 23 && BMI <= 27.5){
//             Console.WriteLine("Overweight");



//         }else{
//             Console.WriteLine("Obese");

//         }


//     }


//     static void DiscountCalculation()
//     {
//         Console.Write("Enter the amount spent: ");
//         float amountSpent = float.Parse(Console.ReadLine());

//         float discountRate = 0;


//         if (amountSpent > 1000)
//         {
//             discountRate = 20;

//         }
//         else if (amountSpent > 100 && amountSpent <= 500)
//         {
//             discountRate = 5;
//         }
//         else if (amountSpent > 500 && amountSpent <= 1000)
//         {
//             discountRate = 10;
//         }

//         float discountAmount = amountSpent * (1 - (discountRate / 100));
//         Console.WriteLine($"The discount given: {discountRate}");
//         Console.WriteLine($"The discount amount: {discountAmount}");

//     }


//     static void MultiplicationTable()
//     {
//         Console.Write("Enter a number: ");
//         int terms = int.Parse(Console.ReadLine());

//         for(int i = 1; i <= 12; i++){
//             Console.WriteLine($"{terms} x {i} = {terms * i}");
//         }
//     }

//     static void Main()
//     {
//         Console.WriteLine("------------- MENU --------------");
//         Console.WriteLine("[1] Calculate Body Mass Index");
//         Console.WriteLine("[2] Calculate Discount");
//         Console.WriteLine("[3] Display Multiplication Table");
//         Console.WriteLine("[0] Exit");
//         Console.WriteLine("---------------------------------");
//         Console.Write("Choose your option: ");
//         int option = int.Parse(Console.ReadLine());

//         switch (option)
//         {
//             case 1:
//             CalculateBMI();
//             break;
//             case 2:
//             DiscountCalculation();
//             break;
//             case 3:
//             MultiplicationTable();
//             break;
//             case 0:
//             Environment.Exit(0);
//             break;
//             default:
//             Console.WriteLine("Sorry! It is not part of the program's functionality.");
//             break;
//         }
//     }
// }


/*
Question 5:
Write a program that adds up to 5 unique words to a list. 
The user can enter ‘x’ to stop adding words. 
Once either 5 words are added or the user stops the program early, 
the words are listed and the total number of letters in the words are displayed.

Example:
Enter a word (or 'x' to stop): apple
Enter a word (or 'x' to stop): banana
Enter a word (or 'x' to stop): orange
Enter a word (or 'x' to stop): x

List of words:
- apple
- banana
- orange

Total number of letters: 16
*/

// class Program{

//     static void Main(){

//             Console.WriteLine("Enter a word (or enter 'x' to stop): ");

//             List<string> wordList = new List<string>();

//             int totalLetter = 0;

//             while (wordList.Count < 5)
//             {
//                 string input = Console.ReadLine().Trim();

//                 if(input.ToLower() == "x"){
//                     break;
//                 }
//                 if(!wordList.Contains(input)){
//                     wordList.Add(input);
//                     totalLetter += input.Length;
//                 }else{
//                     Console.WriteLine("The word already exits! Enter a different word!");
//                 }
//             }
//             Console.WriteLine("---------------------------------");
//             Console.WriteLine("List of words:");
//             foreach(string word in wordList){
//                 Console.WriteLine($"- {word}");
//             }
//             Console.WriteLine($"Total number of letters: {totalLetter}");

//     }

// }



/*
Question 6:
Write a program that simulates a number guessing game. 
It first generates a random number between 1 and 100. 
It then prompts the user to guess the correct number. 
The user can enter -1 to end the game, or the game will end after 5 tries.


Example:
Guess the number (between 1 and 100, or enter -1 to quit): 50
Too high!
Guess the number (between 1 and 100, or enter -1 to quit): 25
Too low!
Guess the number (between 1 and 100, or enter -1 to quit): 37
Too high!
Guess the number (between 1 and 100, or enter -1 to quit): 30
Congratulations! You guessed the correct number in 4 tries.

*/

class Program
{

    static void Main()
    {

        Console.WriteLine("Guess the number (between 1 and 100, or enter -1 to quit): ");

        int attempts = 0;

        Random random = new Random();

        int randomNumber = random.Next(1, 100);

        bool exact = false;

        while (attempts < 5)
        {
            int guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber == -1)
            {
                break;
            }

            if (guessNumber != randomNumber)
            {
                attempts++;
                if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("Too low!");
                }
            }
            else
            {
                exact = true;
                Console.WriteLine($"Congratulations! You guessed the correct number in {attempts} tries.");
                break;
            }
        }

        Console.WriteLine("---------------------------------");
        if (exact == false)
        {
            Console.WriteLine("You just lack a little luck!");
        }


    }

}

