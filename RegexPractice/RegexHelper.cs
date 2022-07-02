using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    public class RegexHelper
    {
        public bool LessonOne(string input)
        {
            // Create Pattern
            var pattern = "abc";

            // Create Instance of Regex using Pattern
            var reg = new Regex(pattern);

            // Use IsMatch Method to return true/false if pattern finds a match.
            return reg.IsMatch(input);
        }

        // \d will match any number
        public bool LessonOneAndAHalf(string input) => 
            new Regex(@"\d").IsMatch(input);

        // . is a wildcard and will match any character
        public bool LessonTwo(string input) =>  
            new Regex(@"...\.").IsMatch(input);

        // [ ] is used to look at multiple possible characters in one index
        public bool LessonThree(string input) =>
            new Regex("[cmf]").IsMatch(input);

        public bool LessonFour(string input)
        {
            return new Regex("[^bog]").IsMatch(input);
        }

        public bool LessonFive(string input)
        {
            return new Regex("[n-p]").IsMatch(input);
        }

        public bool LessonSix(string input)
        {
            return new Regex("z{3}").IsMatch(input);
        }

        public bool LessonSeven(string input)
        {
            return new Regex("aa+b*c+").IsMatch(input);
        }
    }
}
