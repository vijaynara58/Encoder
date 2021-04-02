using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encoder
{
    public class cEncoderDecoder : cOriginal
    {
        //Global
        public List<string> lstOriginal = new List<string>();

        public List<string> lst1EvenLineOddLetter = new List<string>();
        public List<string> lst2EvenLineEvenLetter = new List<string>();
        public List<string> lst3OddLineEvenLetter = new List<string>();
        public List<string> lst4OddLineOddLetter = new List<string>();
        public static Random rnd = new Random();
        //End Global

        //Fill lstOriginal with each character from cOriginal(strOriginal)
        public void fillOriginal()
        {
            lstOriginal.AddRange(strOriginal.Select(c => c.ToString()));
        }

        //Filling all 4 lists with randomly generated characters coming from lstOriginal
        public void fillAllListsWithShuffle()
        {
            //empty all lists by calling the method clearAllLists()
            clearAllLists();

            //copy the elements from strOriginal in each list with shuffle
            lst1EvenLineOddLetter = lstOriginal.OrderBy(x => rnd.Next()).ToList();
            lst2EvenLineEvenLetter = lstOriginal.OrderBy(x => rnd.Next()).ToList();
            lst3OddLineEvenLetter = lstOriginal.OrderBy(x => rnd.Next()).ToList();
            lst4OddLineOddLetter = lstOriginal.OrderBy(x => rnd.Next()).ToList();
        }
        //
        public List<string> listReverser(List<string> theList)
        {
            
            theList.Reverse();

            return theList;
        }

        //Key Builder
        public string keyStringBuilder()
        {
            

            //Build the key

            //reverse list 2 and 4
            listReverser(lst2EvenLineEvenLetter);
            listReverser(lst4OddLineOddLetter);

            string theKey = "";


            foreach (string letter in lst1EvenLineOddLetter)
            {
                theKey += letter;
            }
            theKey += Environment.NewLine;

            foreach (string letter in lst2EvenLineEvenLetter)
            {
                theKey += letter;
            }
            theKey += Environment.NewLine;
            foreach (string letter in lst3OddLineEvenLetter)
            {
                theKey += letter;
            }
            theKey += Environment.NewLine;
            foreach (string letter in lst4OddLineOddLetter)
            {
                theKey += letter;
            }
            //reverse list 2 and 4 again
            listReverser(lst2EvenLineEvenLetter);
            listReverser(lst4OddLineOddLetter);
            
            return theKey;
        }
        
        public string Encoding(string theKey, string theInput)
        {
            bool verifOk = verifKey(theKey);
            if(verifOk == false)
            {
                return theInput;
            }
            char[] splitter = { '\r', '\n' };

            //separate each line 
            string[] key = (theKey.Split(splitter)).ToArray();

            clearAllLists();

            lst1EvenLineOddLetter.AddRange(key[0].Select(c => c.ToString()));
            lst2EvenLineEvenLetter.AddRange(key[1].Select(c => c.ToString()));
            lst3OddLineEvenLetter.AddRange(key[2].Select(c => c.ToString()));
            lst4OddLineOddLetter.AddRange(key[3].Select(c => c.ToString()));

            //reverse list 2 and 4
            listReverser(lst2EvenLineEvenLetter);
            listReverser(lst4OddLineOddLetter);

            //Start Encoding the word
            string encodedText = "";

            //spearate the string line per line
            string[] words = (theInput.Split(splitter, StringSplitOptions.RemoveEmptyEntries)).ToArray();

            for(int j=0; j<words.Count();j++)
            {
                //even lines
                if(j%2==0)
                {
                    string theWord = words[j].ToString();
                    encodedText += encodingEvenLine(theWord);
                    encodedText += Environment.NewLine;
                }
                //odd lines
                else
                {
                    string theWord = words[j].ToString();
                    string temp = encodingOddLine(theWord);
                    encodedText += reverseString(temp);
                    encodedText += Environment.NewLine;


                }           
            }



            //return the encoded text
            return encodedText;
        }

        //Encoding EVEN LINE
        private string encodingEvenLine(string word)
        {
            string encodedWord = "";
            char[] letters = word.ToArray();
            for(int i=0;i<letters.Count();i++)
            {
                //even letter
                if(i%2==0)
                {
                    int theRnd = rnd.Next(0, lstOriginal.Count - 1);
                    encodedWord += lstOriginal[theRnd];
                    string theLetter = letters[i].ToString();
                    if(lstOriginal.Contains(theLetter))
                    {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                        //finding the index of theLetter in the orignal list 
                        int ind = lstOriginal.IndexOf(theLetter);
                        //add the corresponding letter at the index of lstOriginal
                        encodedWord += lst2EvenLineEvenLetter[ind].ToString();

                    }
                    //if corresponding letter not found
                    else
                    {
                        encodedWord += theLetter;

                    }
                }
                //odd letter
                else
                {
                    int aRnd = rnd.Next(0, lstOriginal.Count - 1);
                    encodedWord += lstOriginal[aRnd];
                    string aLetter = letters[i].ToString();
                    if(lstOriginal.Contains(aLetter))
                    {
                        //finding the index of theLetter in the orignal list 
                        int ind = lstOriginal.IndexOf(aLetter);
                        //add the corresponding letter at the index of lstOriginal
                        encodedWord += lst1EvenLineOddLetter[ind].ToString();
                    }
                    else
                    {
                        encodedWord += aLetter;
                    }
                }
            }
            return encodedWord;
        }

        //Reverse a string
        private string reverseString(string theWord)
        {
            string reverseWord = "";
            int theLength = 0;
            theLength = theWord.Length - 1;

            while(theLength >= 0)
            {
                reverseWord += theWord[theLength];
                theLength--;
            }
            return reverseWord;
        }

        //Encoding ODD LINE
        private string encodingOddLine(string word)
        {
            string encodedWord = "";
            char[] letters = word.ToArray();
            for (int i = 0; i < letters.Count(); i++)
            {
                //even letter
                if (i % 2 == 0)
                {
                    int theRnd = rnd.Next(0, lstOriginal.Count - 1);
                    encodedWord += lstOriginal[theRnd];
                    string theLetter = letters[i].ToString();
                    if (lstOriginal.Contains(theLetter))
                    {
                        //finding the index of theLetter in the orignal list 
                        int ind = lstOriginal.IndexOf(theLetter);
                        //add the corresponding letter at the index of lstOriginal
                        encodedWord += lst3OddLineEvenLetter[ind].ToString();

                    }
                    //if corresponding letter not found
                    else
                    {
                        encodedWord += theLetter;

                    }
                }
                //
                else
                {
                    int aRnd = rnd.Next(0, lstOriginal.Count - 1);
                    encodedWord += lstOriginal[aRnd];
                    string aLetter = letters[i].ToString();
                    if (lstOriginal.Contains(aLetter))
                    {
                        //finding the index of theLetter in the orignal list 
                        int ind = lstOriginal.IndexOf(aLetter);
                        //add the corresponding letter at the index of lstOriginal
                        encodedWord += lst4OddLineOddLetter[ind].ToString();
                    }
                    else
                    {
                        encodedWord += aLetter;
                    }
                }
            }
            return encodedWord;
        }

        public string Decoding(string theKey, string theText)
        {
            //////*****************/////////////////
            /////Crypto method for Encryption
            //byte[] theKey = { 0x01, 0x02, 0x03 };
            //Aes vg = Aes.Create();
            //vg.Key = theKey;
            
            char[] splitter = { '\r', '\n' };

            //separate each line 
            string[] key = (theKey.Split(splitter)).ToArray();

            clearAllLists();

            lst1EvenLineOddLetter.AddRange(key[0].Select(c => c.ToString()));
            lst2EvenLineEvenLetter.AddRange(key[1].Select(c => c.ToString()));
            lst3OddLineEvenLetter.AddRange(key[2].Select(c => c.ToString()));
            lst4OddLineOddLetter.AddRange(key[3].Select(c => c.ToString()));


            //reverse list 2 and 4
            listReverser(lst2EvenLineEvenLetter);
            listReverser(lst4OddLineOddLetter);

            string decodedText = "";
            string[] Words = (theText.Split(splitter, StringSplitOptions.RemoveEmptyEntries)).ToArray();

            for (int j = 0; j < Words.Count(); j++)
            {
                //even lines
                if (j % 2 == 0)
                {
                    Words[j] = removeExtraLetter(Words[j]);
                }
                //odd lines
                else
                {
                    Words[j] = reverseString(Words[j]);

                    Words[j] = removeExtraLetter(Words[j]);

                }
            }
            for (int z = 0; z < Words.Count(); z++)
            {
                if((z%2)==0)
                {
                    string theWord = Words[z].ToString();
                    decodedText += DecodingEvenLine(theWord);
                    decodedText += Environment.NewLine;
                }
                else
                {
                    string cWord = Words[z].ToString();
                    decodedText += DecodingOddLine(cWord);
                }
            }
            return decodedText;
        }

        private string removeExtraLetter(string theWord)
        {
            char[] aWord = theWord.ToArray();

            string extrasRemoved = "";
            for(int i =0; i < aWord.Count(); i++)
            {
                if((i%2)==1)
                {
                    extrasRemoved += aWord[i].ToString();
                }
            }
            return extrasRemoved;
        }

        //EVEN LINE
        private string DecodingEvenLine(string vWord)
        {
            string decodedWord = "";
            char[] letters = vWord.ToArray();
           
            for (int i = 0; i < letters.Count(); i++)
            {
                
                //even letter
                if (i % 2 == 0)
                {
                    
                    string theLetter = letters[i].ToString();

                    if (lstOriginal.Contains(theLetter))
                    {
                        //finding the index of theLetter in the orignal list 
                        int ing = lst2EvenLineEvenLetter.IndexOf(theLetter);
             
                        //add the corresponding letter at the index of lstOriginal
                        decodedWord += lstOriginal[ing].ToString();
                    }
                    //if corresponding letter not found
                    else
                    {
                        decodedWord += theLetter;

                    }
                }

                //odd letter
                else
                {
                    string aLetter = letters[i].ToString();

                    if (lstOriginal.Contains(aLetter))
                    {
                        int ine = lst1EvenLineOddLetter.IndexOf(aLetter);
                        decodedWord += lstOriginal[ine].ToString();
                        //decodedWord.Remove(i, 1);
                    }
                    else
                    {
                        decodedWord += aLetter;
                    }
                }
            }
            return decodedWord;
        }

        private string DecodingOddLine(string vWord)
        {
            string decodedWord = "";
            char[] letters = vWord.ToArray();

            for (int i = 0; i < letters.Count(); i++)
            {

                //even letter
                if (i % 2 == 0)
                {

                    string theLetter = letters[i].ToString();

                    if (lstOriginal.Contains(theLetter))
                    {
                        //finding the index of theLetter in the orignal list 
                        int ing = lst3OddLineEvenLetter.IndexOf(theLetter);

                        //add the corresponding letter at the index of lstOriginal
                        decodedWord += lstOriginal[ing].ToString();
                    }
                    //if corresponding letter not found
                    else
                    {
                        
                        decodedWord += theLetter;

                    }
                }

                //odd letter
                else
                {
                    string aLetter = letters[i].ToString();

                    if (lstOriginal.Contains(aLetter))
                    {
                        int ine = lst4OddLineOddLetter.IndexOf(aLetter);
                        decodedWord += lstOriginal[ine].ToString();
                        //decodedWord.Remove(i, 1);
                    }
                    else
                    {
                        decodedWord += aLetter;
                    }
                }
            }
            return decodedWord;
        }
        //Method to generate a new key
        public string generateNewKey()
        {
            fillAllListsWithShuffle();
            string temp = keyStringBuilder();

            return temp;
        }

        //Comapring the number of characters in the rtxtKey with original key
        public bool verifKey(string aKey)
        {
            bool verif = false;
            int theCount = aKey.Count();

            if(theCount == 459)
            {
                verif = true;
            }
            else
            {
                verif = false;
            }
            return verif;
        }


        //Clear all Lists to be shuffled
        public void clearAllLists()
        {
            lst1EvenLineOddLetter.Clear();
            lst2EvenLineEvenLetter.Clear();
            lst3OddLineEvenLetter.Clear();
            lst4OddLineOddLetter.Clear();
        }
    }
}

