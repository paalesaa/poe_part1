using System.IO;
using System.Media;
using System;

namespace poe_part1
{
    public class playNow
    {
        public playNow()
        {

            //getting the full location of the project
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            Console.WriteLine(full_location);

            //replace the bin\debug\folder in the full-location
            string new_path = full_location.Replace("bin\\Debug\\", "");

            //combine wav name with the updated path
            string full_path = Path.Combine(new_path, "greetingai.wav");

            //passing method playSync
            PlaySync(full_path);


        }//end of constructor

        //method to play the sound

        private void PlaySync(string full_path)
        {
            //try and catch
            try
            {
                using (SoundPlayer play = new SoundPlayer(full_path))
                {
                    //playing sound
                    play.PlaySync();


                }//end of using
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);

            }//end of try and catch
        }//end of method
    }
}