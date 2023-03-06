using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using Algorithms;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in both code and config file together.
    public class Service1 : IService
    {
        private A52 a52;
        private RailfenceCipher railfenceCipher;
        private XTEA xtea;
        private PCBC pcbc;
        private MD5Hash md5;
        public Service1()
        {
            a52 = new A52();
            railfenceCipher = new RailfenceCipher();
            xtea = new XTEA();
            pcbc = new PCBC(Encoding.ASCII.GetBytes("ab"));
            md5 = new MD5Hash();
        }
        public void EncryptA52(string loadPath, string savePath)
        {
            byte[] data = loadBytes(loadPath);
            byte[] encrypted = a52.Encrypt(data, 0x21);
            saveBytes(encrypted, savePath);
        }
        public void DecryptA52(string loadPath, string savePath)
        {
            byte[] data = loadBytes(loadPath);
            byte[] decrypted  =  a52.Decrypt(data, 0x21);
            saveBytes(decrypted, savePath);
        }
        public void EncryptRailFence(string loadPath, string savePath)
        {
            byte[] data = loadBytes(loadPath);
            byte[] encrypted= railfenceCipher.Encrypt(data, 3);
            saveBytes(encrypted, savePath);
        }
        public void DecryptRailDence(string loadPath, string savePath)
        {
            byte[] data = loadBytes(loadPath);
            byte[] dencrypted = railfenceCipher.Decrypt(data, 3);
            saveBytes(dencrypted, savePath);
        }

        public void EncryptXTEA(string loadPath, string savePath)
        {
            string data = loadText(loadPath);

            string encypted =  xtea.Encrypt(data, "1234567812345678");
            saveText(encypted, savePath);
        }
        public void DecryptXTEA(string loadPath, string savePath)
        {
            string data= loadText(loadPath);
            string decrypted = xtea.Decrypt(data, "1234567812345678");
            saveText(decrypted, savePath);
        }

        public void EncryptPCBC(string loadPath, string savePath)
        {
            byte[] data = loadBytes(loadPath);
            byte[] encrypted = pcbc.Encrypt(data, 0x21);
            saveBytes(encrypted, savePath);
        }
        public void DecryptPCBC(string loadPath, string savePath)
        {
            byte[] data = loadBytes(loadPath);
            byte[] decrypted =  pcbc.Decrypt(data ,0x21);
            saveBytes(decrypted, savePath);
        }
        

        public void EncryptA52BMP(string loadPath, string savePath)
        {
            byte[] imageData = loadBitmap(loadPath);
            byte[] data = new byte[imageData.Length-54];
            for(int i = 0; i<imageData.Length-54;i++)
            {
                data[i] = imageData[i+54];
            }
            byte[] encryptedData = a52.Encrypt(data, 0x21);
            byte[] fullEncryptedData = new byte[encryptedData.Length + 54];
            for(int i = 0;i<54;i++)
            {
                fullEncryptedData[i] = imageData[i];
            }
            for(int i =0;i<encryptedData.Length;i++)
            {
                fullEncryptedData[i+54] = encryptedData[i];
            }
            saveBitmap(fullEncryptedData,savePath);
        }

        public void DecryptA52BMP(string loadPath, string savePath)
        {
            byte[] imageData = loadBitmap(loadPath);
            byte[] data = new byte[imageData.Length - 54];
            for (int i = 0; i < imageData.Length - 54; i++)
            {
                data[i] = imageData[i + 54];
            }
            byte[] decryptedData = a52.Decrypt(data, 0x21);
            byte[] fullDecryptedData = new byte[decryptedData.Length + 54];
            for (int i = 0; i < 54; i++)
            {
                fullDecryptedData[i] = imageData[i];
            }
            for (int i = 0; i < decryptedData.Length; i++)
            {
                fullDecryptedData[i + 54] = decryptedData[i];
            }
            saveBitmap(fullDecryptedData, savePath);
        }

        public void EncryptRailFenceBMP(string loadPath, string savePath)
        {
            byte[] imageData = loadBitmap(loadPath);
            byte[] data = new byte[imageData.Length - 54];
            for (int i = 0; i < imageData.Length - 54; i++)
            {
                data[i] = imageData[i + 54];
            }
            byte[] encryptedData = railfenceCipher.Encrypt(data, 3);
            byte[] fullEncryptedData = new byte[encryptedData.Length + 54];
            for (int i = 0; i < 54; i++)
            {
                fullEncryptedData[i] = imageData[i];
            }
            for (int i = 0; i < encryptedData.Length; i++)
            {
                fullEncryptedData[i + 54] = encryptedData[i];
            }
            saveBitmap(fullEncryptedData, savePath);
        }

        public void DecryptRailDenceBMP(string loadPath, string savePath)
        {
            byte[] imageData = loadBitmap(loadPath);
            byte[] data = new byte[imageData.Length - 54];
            for (int i = 0; i < imageData.Length - 54; i++)
            {
                data[i] = imageData[i + 54];
            }
            byte[] decryptedData = railfenceCipher.Decrypt(data, 3);
            byte[] fullDecryptedData = new byte[decryptedData.Length + 54];
            for (int i = 0; i < 54; i++)
            {
                fullDecryptedData[i] = imageData[i];
            }
            for (int i = 0; i < decryptedData.Length; i++)
            {
                fullDecryptedData[i + 54] = decryptedData[i];
            }
            saveBitmap(fullDecryptedData, savePath);
        }

     

        public void EncryptPCBCBMP(string loadPath, string savePath)
        {
            byte[] imageData = loadBitmap(loadPath);
            byte[] data = new byte[imageData.Length - 54];
            for (int i = 0; i < imageData.Length - 54; i++)
            {
                data[i] = imageData[i + 54];
            }
            byte[] encryptedData = pcbc.Encrypt(data, 0x21);
            byte[] fullEncryptedData = new byte[encryptedData.Length + 54];
            for (int i = 0; i < 54; i++)
            {
                fullEncryptedData[i] = imageData[i];
            }
            for (int i = 0; i < encryptedData.Length; i++)
            {
                fullEncryptedData[i + 54] = encryptedData[i];
            }
            saveBitmap(fullEncryptedData, savePath);
        }

        public void DecryptPCBCBMP(string loadPath, string savePath)
        {
            byte[] imageData = loadBitmap(loadPath);
            byte[] data = new byte[imageData.Length - 54];
            for (int i = 0; i < imageData.Length - 54; i++)
            {
                data[i] = imageData[i + 54];
            }
            byte[] decryptedData = pcbc.Decrypt(data, 0x21);
            byte[] fullDecryptedData = new byte[decryptedData.Length + 54];
            for (int i = 0; i < 54; i++)
            {
                fullDecryptedData[i] = imageData[i];
            }
            for (int i = 0; i < decryptedData.Length; i++)
            {
                fullDecryptedData[i + 54] = decryptedData[i];
            }
            saveBitmap(fullDecryptedData, savePath);
        }
        public bool Md5hash(string loadPath, string savePath)
        {
            byte[] loadFile = loadBytes(loadPath);
            byte[] saveFile = loadBytes(savePath);
            string loadString = md5.Calculate(loadFile);
            string saveString = md5.Calculate(saveFile);
            return loadString == saveString;
        }

        public byte[] loadBytes(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            return bytes;
        }

        public void saveBytes(byte[] bytes, string path)
        {
            try
            {

                File.WriteAllBytes(path, bytes);
                Console.WriteLine("\n> Rezultat je sacuvan u fajlu sa nazivom:" + path);

            }
            catch (Exception)
            {
                Console.WriteLine("> File not found. Try again.");
            }
        }
        public byte[] loadBitmap(string path)
        {
            byte[] imageBytes = File.ReadAllBytes(path);
            return imageBytes;
        }
        public void saveBitmap(byte[] imageBytes, string path)
        {
            var memoryStream = new MemoryStream(imageBytes);
            System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream);

            image.Save(path, ImageFormat.Bmp);
        }

        public void EncryptParalelization(string loadPath, string savePath, int numberOfThreads, int rails)
        {
            string data = loadText(loadPath);
            int partsSize = data.Length / numberOfThreads;
            string[] parts = new string[numberOfThreads];
            int start=0, end=0;
            for(int i = 0; i<numberOfThreads;i++)
            {
                start = i * partsSize;
                end = start + partsSize;
                if(i==(numberOfThreads-1))
                {
                    end = data.Length;
                }
                parts[i] = data.Substring(start, end-start);
            }

            var lockData = new object();
            string encryptedData ="";
            Parallel.ForEach(parts, new ParallelOptions { MaxDegreeOfParallelism = numberOfThreads }, part =>
            {
                string encryptedPart = railfenceCipher.EncryptString(part, rails);
                lock (lockData)
                {
                   encryptedData+= encryptedPart;
                }
            });
            saveText(encryptedData,savePath);

        }


        public void saveText(string text, string path)
        {
            try
            {
                File.WriteAllText(path, text);
                Console.WriteLine("\n> Rezultat je sacuvan u fajlu sa nazivom:" + path);
            }
            catch (Exception)
            {
                Console.WriteLine("> File not found. Try again.");
            }
        }

        public string loadText(string path)
        {
            string res = File.ReadAllText(path);
            return res;
        }

      
    }
}