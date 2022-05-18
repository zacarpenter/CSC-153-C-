using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_PigLatin
{

    /* 
        Create an application that accepts a sentence as input and converts each work to "Pig Latin."
        To convert a word to Pig Latin you remove the first letter and place the letter at the end of the word.
        Then you append the string "ay" to the word.
        
        English: I SLEPT MOST OF THE NIGHT
        Pig Latin: IAY LEPTSAY OSTMAY FOAY HETAY IGHTNAY

    
        Also add these functionalities to your program:

        ** Your program should also display the number of words in the original sentence **

        ** Your program should count and display the number of vowels (a,e,i,o,u) in the original sentence **

        ** If your original sentence has any numeric digits, replace the number with an asterisk (*).

        MAKE SURE THAT THESE 3 FUNCTIONALITIES ABOVE ARE IN THEIR OWN METHODS!!
     */

    public partial class PigLatin : Form
    {
        public PigLatin()
        {
            InitializeComponent();
        }

        // variable to hold our vowel count
        private int vowelCounter;

        // variable to hold our word count
        private int wordCount;

        // varible for our output sentence to the text box
        private string output;


        private void convertBtn_Click(object sender, EventArgs e)
        {

            // grab the string from the text box
            string input = inputText.Text;

            // initialize output as empty
            output = "";

            // initialize a variable to hold our sentence
            string pigLatinWord = "";

            // initialize our varible to hold the modified text from method EditText
            string modified = EditText(input);

            // create an array to split the text
            string[] pigLatin = modified.Split(null);

            
            // foreach to grab the first letter a
            foreach (string str in pigLatin)
            {
                // checks if the string does not contain the * character
                if (!str.Contains('*'))
                {
                    // grab the first letter
                    string firstLetter = str.Substring(0, 1);

                    // remove the first letter
                    string word = str.Substring(1, str.Length - 1);

                    // create the Pig Latin output
                    word += firstLetter + "ay" + " ";

                    // add the variable word to our sentence
                    pigLatinWord += word;
                } // end if

                // if the string contains the * character it skips the pig latin assignment
                else if (str.Contains('*'))
                {
                    // add the modified sentence (from EditText) to our output
                    pigLatinWord += str + " ";

                } // end else if

            } // end foreach

            // output the sentence to the text box
            pigLatinText.Text = output + pigLatinWord;

            // call the method to count the vowels
            CountVowels();
            // output the vowel count to the text box
            vowelCountText.Text = vowelCounter.ToString();

            // call the method to count the words
            WordCounter();
            // output the word count to the text box
            wordCountText.Text = wordCount.ToString();


        } // end method


        private string EditText(string modifiedText)
        {
            // loop to move through each iteration of the string
            for (int i = 0; i < modifiedText.Length; i++)
            {
                // if the character of the string index is a digit
                if (char.IsDigit(modifiedText, i))
                {
                    // then the string removes the digit
                    modifiedText = modifiedText.Remove(i, 1);

                    // and the string adds an asteriks 
                    modifiedText = modifiedText.Insert(i, "*");
                } // end if
            } // end for

            // method returns the string modifiedText
            return modifiedText;

         } // end method


        private void CountVowels()
        {
            // initialize the counter
            vowelCounter = 0;

            // grab the original text
            string originalText = inputText.Text;

            //vowelCounter = originalText.Count("aeiouAEIOU".Contains);


            // make a list to store the vowel characters
            List<char> vowels = new List<char> { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };


            // createa  loop to iterate through the length of the string
            for (int i = 0; i < originalText.Length; i++)
            {
                // check if the list contains a vowel at each index
                if (vowels.Contains(originalText[i]))
                {
                    // iterate the counter
                    vowelCounter++;
                } // end if
            } //end for

        } // end method


        private void WordCounter()
        {
            // initialize the variable
            wordCount = 0;

            // grab the original text
            string originalText = inputText.Text;


            /*  this actually counts each letter
            for (int i = 0; i < originalText.Length; i++)
            {
                
                if (char.IsLetter(originalText[i]))
                {
                    wordCount++;
                }
            }
            */


            // tokenize the original text
            string[] count = originalText.Split(null);

            // move through each index in the token
            foreach (string word in count)
            {
                // if the word starts with a letter it's included in the count
                if (char.IsLetter(word[0])) 
                {
                    // iterate wordCount
                    wordCount++;
                } // end if
            } // end foreach
            

        } // end method


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        } // end method

    } // end class
} // end namespace
