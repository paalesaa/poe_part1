using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace poe_part1
{
    public class asciiArt
    {
        public asciiArt()
        {
            //getting the full location of project

            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            //replace bin/Debug
            string new_location = full_location.Replace("bin\\Debug\\", "");

            
            string full_path = Path.Combine(new_location, "logo2.jpg");
        

            //creating the BitMap class
            Bitmap image = new Bitmap(full_path);
            //then set the size
            image = new Bitmap(image, new Size(110,110) );
           
            //outer and inner loop
            for (int height = 0; height<image.Height; height++)
            {
                //inner loop
                for (int width=0;width<image.Width; width++) {
                Color pixelColor = image.GetPixel(width, height);
                    int gray = (pixelColor.R + pixelColor.B) / 3;
                    char asciiChar = gray > 200 ? '-':gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '@';
                    Console.Write(asciiChar);

                   

                }
               Console.WriteLine();

            }//end of outer loop
            


        }//end of constructor
    }//end of class
}//end of namespace