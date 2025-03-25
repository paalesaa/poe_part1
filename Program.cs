using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poe_part1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create an instance for the class design-prompt
            new design_prompt() { };

            //create instance for greeting class
            new playNow() { };

            //create instance for ascii art class
            new asciiArt() { }; 
        }
    }
}
