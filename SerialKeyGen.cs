using System.Net; //Create File
using System.Xml.Linq;
using System.Text;
using System;

namespace DarkiyusSerialKey
{
    public class SerialKey
    {
        public static string Gen(int groups, int inGroupPieces)
        {
            var thing = new SerialKey();


            string random = SerialCodeGen(inGroupPieces, groups);


            return random;
        }

        private static string Codex(int position)
        {
            string[] codex = new string[36]
            {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"

            };
            string letter = codex[position];
            return letter;

        }

        private static string SerialCodeGen(int groups, int inGroupPieces)
        {

            string result = "";


            for (int i = 0; i < inGroupPieces; i++)
            {

                for (int j = 0; j < groups; j++)
                {
                    Random rnd = new Random();
                    result = result + Codex(rnd.Next(0, 36));
                    System.Threading.Thread.Sleep(10); //Bugfix for timebased random
                }

                if (i == inGroupPieces - 1)
                {
                    //Last group gets no hyphen
                }
                else
                {
                    result = result + "-"; //End of a group gets hyphen
                }

            }

            return result;
        }
    }



}
