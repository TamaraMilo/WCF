using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Algorithms
{
     class RailfenceCipher
    {
        public byte[] Encrypt(byte[] data, int rails)
        {
            string text = Encoding.ASCII.GetString(data);
            text = text.ToUpper();
            text = Regex.Replace(text, @"[^A-Z0-9]", string.Empty);

            var lines = new List<StringBuilder>();

            for (int i = 0; i < rails; i++)
                lines.Add(new StringBuilder());

            int currentLine = 0;
            int direction = 1;

            for (int i = 0; i < text.Length; i++)
            {
                lines[currentLine].Append(text[i]);

                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == rails - 1)
                    direction = -1;

                currentLine += direction;
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rails; i++)
                result.Append(lines[i].ToString());

            string res =  result.ToString();
            byte[] resBytes = Encoding.ASCII.GetBytes(res);
            return resBytes;
        }

        public byte[] Decrypt(byte[] data, int rails)
        {
            string text = Encoding.ASCII.GetString(data);
            text = text.ToUpper();
            text = Regex.Replace(text, @"[^A-Z0-9]", string.Empty);

            var lines = new List<StringBuilder>();

            for (int i = 0; i < rails; i++)
            {
                lines.Add(new StringBuilder());
            }

            int[] linesLenght = Enumerable.Repeat(0, rails).ToArray();

            int currentLine = 0;
            int direction = 1;

            for (int i = 0; i < text.Length; i++)
            {
                linesLenght[currentLine]++;

                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == rails - 1)
                    direction = -1;

                currentLine += direction;
            }

            int currentChar = 0;

            for (int line = 0; line < rails; line++)
            {
                for (int c = 0; c < linesLenght[line]; c++)
                {
                    lines[line].Append(text[currentChar]);
                    currentChar++;
                }
            }

            StringBuilder result = new StringBuilder();

            currentLine = 0;
            direction = 1;

            int[] currentReadLine = Enumerable.Repeat(0, rails).ToArray();

            for (int i = 0; i < text.Length; i++)
            {

                result.Append(lines[currentLine][currentReadLine[currentLine]]);
                currentReadLine[currentLine]++;

                if (currentLine == 0)
                {
                    direction = 1;
                }
                else if (currentLine == rails - 1)
                {
                    direction = -1;
                }

                currentLine += direction;
            }

            string res = result.ToString();
            byte[] resBytes = Encoding.ASCII.GetBytes(res);
            return resBytes;

        }
        public string EncryptString(string text, int rails)
        {
          
            text = text.ToUpper();
            text = Regex.Replace(text, @"[^A-Z0-9]", string.Empty);

            var lines = new List<StringBuilder>();

            for (int i = 0; i < rails; i++)
                lines.Add(new StringBuilder());

            int currentLine = 0;
            int direction = 1;

            for (int i = 0; i < text.Length; i++)
            {
                lines[currentLine].Append(text[i]);

                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == rails - 1)
                    direction = -1;

                currentLine += direction;
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rails; i++)
                result.Append(lines[i].ToString());

            string res = result.ToString();
           
            return res;
        }

        public string DecryptString(string text, int rails)
        {
            
            text = text.ToUpper();
            text = Regex.Replace(text, @"[^A-Z0-9]", string.Empty);

            var lines = new List<StringBuilder>();

            for (int i = 0; i < rails; i++)
            {
                lines.Add(new StringBuilder());
            }

            int[] linesLenght = Enumerable.Repeat(0, rails).ToArray();

            int currentLine = 0;
            int direction = 1;

            for (int i = 0; i < text.Length; i++)
            {
                linesLenght[currentLine]++;

                if (currentLine == 0)
                    direction = 1;
                else if (currentLine == rails - 1)
                    direction = -1;

                currentLine += direction;
            }

            int currentChar = 0;

            for (int line = 0; line < rails; line++)
            {
                for (int c = 0; c < linesLenght[line]; c++)
                {
                    lines[line].Append(text[currentChar]);
                    currentChar++;
                }
            }

            StringBuilder result = new StringBuilder();

            currentLine = 0;
            direction = 1;

            int[] currentReadLine = Enumerable.Repeat(0, rails).ToArray();

            for (int i = 0; i < text.Length; i++)
            {

                result.Append(lines[currentLine][currentReadLine[currentLine]]);
                currentReadLine[currentLine]++;

                if (currentLine == 0)
                {
                    direction = 1;
                }
                else if (currentLine == rails - 1)
                {
                    direction = -1;
                }

                currentLine += direction;
            }

            string res = result.ToString();
            return res;

        }
    }
}
