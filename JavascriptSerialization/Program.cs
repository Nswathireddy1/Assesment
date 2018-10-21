using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JavascriptSerialization
{
    public class Dictionary
    {
        //public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            Dictionary d1 = new Dictionary();
            Dictionary<string,int> points = new Dictionary<string,int>
            {
                { "swathi", 9001 },
                { "kanna", 3474 },
                { "chinna", 11926 }
            };

            string json = JsonConvert.SerializeObject(points, Formatting.Indented);

            Console.WriteLine(json);
        }
    }
}//Serialization to dictionary
