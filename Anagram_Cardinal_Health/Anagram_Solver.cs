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
    class Anagram_Solver
    {
        static void Main(string[] array_Of_Words)
        {
            Anagram_Solver2.Main2();
            //if (array_Of_Words.Count() == 0)
            //{
            //    array_Of_Words = new string[] { "documenting" };
            //}
            //string master_List_Of_Words = Environment.CurrentDirectory + "\\words.txt";

            //foreach (string word in array_Of_Words)
            //{
            //    string word_Arranged_By_Letter = string.Concat(word.ToLower().Replace(" ", "").OrderBy(character => character));

            //    Console.WriteLine(word_Arranged_By_Letter);

            //    List<string> list_Of_Words = new List<string>();

            //    using (StreamReader file_Reader = new StreamReader(master_List_Of_Words))
            //    {
            //        while (!file_Reader.EndOfStream)
            //        {
            //            list_Of_Words.Add(file_Reader.ReadLine());
            //        }
            //    }

            //    foreach (string possible_First_Word in list_Of_Words)
            //    {

            //        foreach (var possible_Second_Word in list_Of_Words)
            //        {
            //            string both_Words = possible_First_Word + possible_Second_Word;
            //            string possible_Anagram_Words = string.Concat(both_Words.ToLower().Replace(" ", "").OrderBy(character => character));

            //            if (word_Arranged_By_Letter == possible_Anagram_Words)
            //            {

            //                Console.WriteLine($"{possible_First_Word} {possible_Second_Word}");
            //            }
            //        }
            //    }
            //}


        }
    }
}
