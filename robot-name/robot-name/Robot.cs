using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot_name
{
    public class Robot
    {
        public string Name;

        public Robot()
        {
            Name = GenerateName();
        }

        private string GenerateName()
        {
            var random = new Random();
            int randomNum;
            char randomCharacter;
            string nameString=null;

            for (int i = 0; i < 2; i++) //Create 2 random letters
            {
                randomNum = random.Next(0, 26);
                randomCharacter = (char) ('A' + randomNum);
                nameString += randomCharacter;
            }
             
            for (int i = 0; i < 3; i++) //Create 3 random numbers
            {
                randomNum = random.Next(0, 9);
                nameString += randomNum;
            }

            return nameString;
        }

        public void Reset()
        {
            
        }
    }
}
