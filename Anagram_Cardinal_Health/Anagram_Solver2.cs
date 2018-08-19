using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSpell.SpellChecker;
using System.Diagnostics;

namespace Anagram_Cardinal_Health
{
    public class Anagram_Solver2
    {
        public static void Main2()
        {

            string word_to_anagram = "documenting";

            int number_of_words = 2;

            for (int loop_incriment = 1; loop_incriment < number_of_words; loop_incriment++)
            {
                word_to_anagram += " ";
            }

            List<string> list_of_anagrams = Permutation_Method(word_to_anagram);

            foreach (string anagram in list_of_anagrams)
            {
                Console.WriteLine(anagram);
            }
        }

        public static List<string> Permutation_Method(string word_to_permute)
        {
            List<string> permutations = new List<string>();

            string word_arranged_by_letter = string.Concat(word_to_permute.ToLower().OrderBy(character => character));

            List<char> letters_to_search_by = new List<char>();

            foreach (char character in word_arranged_by_letter)
            {
                letters_to_search_by.Add(character);
            }

            var matched_word = new StringBuilder();

            string master_list_of_words_file_location = Environment.CurrentDirectory + "\\testfile.txt";
            using (StreamReader file_reader = new StreamReader(master_list_of_words_file_location))
            {
                while (!file_reader.EndOfStream)
                {
                    bool next_word = false;

                    string possible_word = file_reader.ReadLine().ToLower();

                    List<char> temp_search_list = new List<char>(letters_to_search_by);

                    char loop_control = temp_search_list[0];

                    foreach (char character in possible_word)
                    {
                        bool next_letter = false;

                        while ((temp_search_list.Any() || !possible_word.EndsWith(character.ToString())) && !next_letter)
                        {

                            char c = temp_search_list.First();

                            if (temp_search_list.First() != character)
                            {
                                var first = temp_search_list.First();
                                temp_search_list.Add(first);
                                temp_search_list.RemoveAt(0);
                                if (temp_search_list[0] == loop_control && temp_search_list[1] == loop_control)
                                {
                                    next_letter = true;
                                }
                                continue;
                            }

                            if (character == temp_search_list.First())
                            {
                                matched_word.Append(temp_search_list.First());

                                temp_search_list.Remove(temp_search_list.First());
                                if (temp_search_list.Any())
                                {
                                    loop_control = temp_search_list.First();

                                }
                                next_letter = true;
                            }

                        }
                    }
                    if (matched_word.ToString() == possible_word)
                    {
                        permutations.Add(matched_word.ToString());
                        matched_word.Clear();
                        Console.WriteLine(matched_word.ToString());

                    }

                    else if (matched_word.ToString() != possible_word)
                    {
                        matched_word.Clear();

                    }
                }
            }
            return permutations;
        }



        //private static void Compare_Characters(List<char> temp_search_list, string possible_word)
        //{

        //}

        //private static void Compare_Words()
        //{

        //}

    }
}
