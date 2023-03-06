using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Algorithms
{
    class PCBC
    {
        private A52 a52Coder;
        private byte[] initializationVector;

        public PCBC(byte[] initVector)
        {
            a52Coder = new A52();
            initializationVector = initVector;
        }


        public byte[] Encrypt(byte[] data, uint publicKey)
        {

            byte[] dataBytes;
            if (data.Length % 2 != 0)
            {
                dataBytes = new byte[data.Length + 1];
                data.CopyTo(dataBytes, 0);
                dataBytes[dataBytes.Length - 1] = 0x00;
            }
            else
            {
                dataBytes = new byte[data.Length];
                data.CopyTo(dataBytes, 0);
            }

            byte[] result = new byte[dataBytes.Length];
            byte[] pcbcKey = initializationVector;
            byte[] plainTextBlock = new byte[2];
            for (int i = 0; i < dataBytes.Length; i += 2)
            {
                //Po dva byta nam je block
                plainTextBlock[0] = dataBytes[i];
                plainTextBlock[1] = dataBytes[i + 1];

 
                plainTextBlock[0] ^= pcbcKey[0];
                plainTextBlock[1] ^= pcbcKey[1];

                byte[] partialResult = a52Coder.Encrypt(plainTextBlock, publicKey);

                result[i]  = partialResult[0];
                result[i+1]= partialResult[1];

                partialResult[0] ^= dataBytes[i];
                partialResult[1] ^= dataBytes[i + 1];

                pcbcKey = partialResult;
            }

            return result;

        }
        
        public byte[] Decrypt(byte[] data, uint publicKey)
        {

            byte[] result = new byte[data.Length];
            byte[] pcbcKey = initializationVector;

            byte[] cipherTextBlock = new byte[2];
            for (int i = 0; i < data.Length; i += 2)
            {

                cipherTextBlock[0] = data[i];
                cipherTextBlock[1] = data[i+1];

                byte[] partialResult = a52Coder.Decrypt(cipherTextBlock, publicKey);

                partialResult[0] ^= pcbcKey[0];
                partialResult[1] ^= pcbcKey[1];


                result[i] = partialResult[0];
                result[i+1] = partialResult[1];
                partialResult[0] ^= data[i];
                partialResult[1] ^= data[i + 1];

                pcbcKey = partialResult;

            }
            byte[] res;
            if (result[result.Length - 1] == 0x00)
            {
                res = new byte[result.Length - 1];
                for (int i = 0; i < result.Length - 1; i++)
                {
                    res[i] = result[i];
                }
            }
            else
                res = result;
            return res;
        }
    }
}
