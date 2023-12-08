namespace validSentenceProgram
{
     public class validSentence
    {
        public static void Main()
        {
            Console.WriteLine("Enter a valid sentence: ");          // ask the user for a valid sentence 
            string input = Console.ReadLine();                      // save user input as string "input"
            bool is_valid  = is_sentence_valid (input); 
            Console.WriteLine($"The sentence is valid : {is_valid}");
        }

        public static bool is_sentence_valid(string input)       //set up boolean method which takes user input as a parameter 
        {
            if (input == "")    //sentence cannot be valid if its empty 
                return false;
            
            if (!char.IsUpper(input[0]))    //Task 1: the char at index [0] must be a capital 
                return false;

            int quotation_count = 0;    //Task 2: using the modulus function, an even number of quotation marks can be determined as even or odd
            if (quotation_count % 2 !=0)
                return false;   

            char lastChar = input[input.Length - 1];   
            if (lastChar != '.' && lastChar!= '?' && lastChar!= '!')       //Task 3: The last character of the string must be a '.' , '!' or a '?'
                return false;

            if (input.IndexOf('.') != input.LastIndexOf('.'))         //Task 4: the strings only period character(if any) must be the last character 
                return false;
                
            string [] numbers = {"1", "2" ,"3", "4", "5", "6", "7", "8", "9" , "10", "11", "12", "13"};       //Task 5: The numbers 1-12 cannot be written as numbers 
            bool containsNumber = false;       // create a boolean variable called containsNumber 

            foreach (string number in numbers)     //foreach loop to loop through all the numbers in the array 
            {
                if (input.Contains(number))     //.Contains function helps find a match between the input and the array 
                {
                    containsNumber = true;
                    break;          // Break out of the loop early if a match is found.
                }
            }
            if (containsNumber)
                return false;      // if a number is found in the string the sentence will be declared invalid 
         

            return true;



        }
    }
  }
