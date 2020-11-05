using System;
using System.Collections.Generic;
using System.Linq;

namespace StringExtensionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------RemoveLastOccurranceOf---------------");
            string firstTest = "This is a test string, we will remove everything after the comma.";
            string secondTest = "This string has no comma so trying to remove it will do nothing.";
            //We want to remove the comma
            Console.WriteLine(firstTest.RemoveLastOccuranceOf(','));
            Console.WriteLine(secondTest.RemoveLastOccuranceOf(','));

            Console.WriteLine("---------------------ToDelimtedList--------------------");
            List<string> names = new List<string> { "Adam", "Bertie", "Carlissa", "Donovan", "Evie", "Franchesca" };
            var result = names.ToDelimitedList();
            Console.WriteLine(result);

            List<string> emptyList = new List<string>();
            var emptyResult = emptyList.ToDelimitedList('|');
            Console.WriteLine(emptyResult);

            Console.WriteLine("----------------------ToCollection---------------------");
            var collection = result.ToCollection();
            Console.WriteLine(collection);

            Console.WriteLine("--------------------RemoveCharacters-------------------");
            string test2 = "This; is, a badly! formatted :sentence.";
            Console.WriteLine(test2.RemoveCharacters(new List<char> { ';', ':', ',', '!' }));

            Console.WriteLine("------------------------Excerpt------------------------");
            string longText = "This is some long text. Here is a story I can tell about how I lived another day.";
            Console.WriteLine(longText.Excerpt(20));
            Console.WriteLine(longText.Excerpt(200));
            Console.WriteLine(longText.Excerpt(80)); //This one will cut the period off an add the ellipsis (...)
        }
    }
}
