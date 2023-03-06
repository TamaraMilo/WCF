using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class XTEA
    {
        protected void code(uint[] v, uint[] k)
        {
            uint y = v[0];
            uint z = v[1];
            uint sum = 0;
            uint delta = 0x9e3779b9;
            uint n = 32;

            while (n-- > 0)
            {
                y += (z << 4 ^ z >> 5) + z ^ sum + k[sum & 3];
                sum += delta;
                z += (y << 4 ^ y >> 5) + y ^ sum + k[sum >> 11 & 3];
            }

            v[0] = y;
            v[1] = z;
        }
        protected void decode(uint[] v, uint[] k)
        {
            uint n = 32;
            uint sum;
            uint y = v[0];
            uint z = v[1];
            uint delta = 0x9e3779b9;

            sum = delta << 5;

            while (n-- > 0)
            {
                z -= (y << 4 ^ y >> 5) + y ^ sum + k[sum >> 11 & 3];
                sum -= delta;
                y -= (z << 4 ^ z >> 5) + z ^ sum + k[sum & 3];
            }

            v[0] = y;
            v[1] = z;
        }
        protected string ConvertUIntToString(uint input)
        {
            StringBuilder output = new StringBuilder();
            output.Append((char)((input & 0xFF)));
            output.Append((char)((input >> 8) & 0xFF));
            output.Append((char)((input >> 16) & 0xFF));
            output.Append((char)((input >> 24) & 0xFF));
            return output.ToString();
        }

        protected uint ConvertStringToUInt(string input)
        {
            uint output;
            output = ((uint)input[0]);
            output += ((uint)input[1] << 8);
            output += ((uint)input[2] << 16);
            output += ((uint)input[3] << 24);
            return output;
        }

        protected uint[] FormatKey(string key)
        {
            uint[] formattedKey = new uint[4];
            for (int i = 0; i < 4; i++)
            {
                formattedKey[i] = ((uint)key[4 * i + 0]<<(32*i));
                formattedKey[i] += ((uint)key[4 * i + 1]<< (32 * i + 8));
                formattedKey[i] += ((uint)key[4 * i + 2] << (32 * i + 16));
                formattedKey[i] += ((uint)key[4 * i + 3] << (32 * i + 24));
            }
            return formattedKey;
        }
        public string Encrypt(string data, string Key)
        {
            uint[] formattedKey = FormatKey(Key);

            if (data.Length % 2 != 0) 
                   data += '\0'; 
            byte[] dataBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(data);

            string cipher = string.Empty;
            uint[] tempData = new uint[2];
            for (int i = 0; i < dataBytes.Length; i += 2)
            {
                tempData[0] = dataBytes[i];
                tempData[1] = dataBytes[i + 1];
                code(tempData, formattedKey);
                cipher += ConvertUIntToString(tempData[0]) +
                                  ConvertUIntToString(tempData[1]);
            }

            return cipher;
        }



        public string Decrypt(string data, string Key)
        {
            uint[] formattedKey = FormatKey(Key);

            int x = 0;
            uint[] tempData = new uint[2];

            byte[] dataBytes = new byte[data.Length / 8 * 2];
            for (int i = 0; i < data.Length; i += 8)
            {
                tempData[0] = ConvertStringToUInt(data.Substring(i, 4));
                tempData[1] = ConvertStringToUInt(data.Substring(i + 4, 4));
                decode(tempData, formattedKey);
                dataBytes[x++] = (byte)tempData[0];
                dataBytes[x++] = (byte)tempData[1];
            }

            string decipheredString =
                    System.Text.ASCIIEncoding.ASCII.GetString(dataBytes,
                                                              0, dataBytes.Length);

            if (decipheredString[decipheredString.Length - 1] == '\0')
                decipheredString = decipheredString.Substring(0,
                                                        decipheredString.Length - 1);
            return decipheredString;
        }
    }
}
