using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace robot_name
{
    public class Robot
    {
        public string Name;
        public static Random rand = new Random();

        public Robot()
        {
            Name = GenerateName();
        }

        private string GenerateName()
        {
            int randomNum;
            char randomCharacter;
            string nameString=null;

            for (int i = 0; i < 2; i++) //Create 2 random letters
            {
                randomNum = rand.Next(0, 26);
                randomCharacter = (char) ('A' + randomNum);
                nameString += randomCharacter;
            }
             
            for (int i = 0; i < 3; i++) //Create 3 random numbers
            {
                randomNum = rand.Next(0, 9);
                nameString += randomNum;
            }

            return nameString;
        }

        public void Reset()
        {
            Name = GenerateName();
        }
    }
}
