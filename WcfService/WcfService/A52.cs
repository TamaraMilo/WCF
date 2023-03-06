using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Algorithms
{

    class A52
    {
        uint r1, r2, r3, r4;

        // shift registers
        uint maskr1 = 0x07ffff;  // R1 has 19 bits - 000001111111111111111111
        uint maskr2 = 0x3fffff;  // R2 has 22 bits - 001111111111111111111111
        uint maskr3 = 0x7fffff;  // R3 has 23 bits - 011111111111111111111111-
        uint maskr4 = 0x01ffff;  // R4 has 17 bits - 000000011111111111111111

        // R4 shift controls registers
        uint r4controlr1 = 0x000400;  // 10-th bit
        uint r4controlr2 = 0x000008;  // 3-th bit
        uint r4controlr3 = 0x000080;  // 7-th bit

        // registers bits for getting firt
        uint r1setting = 0x072000;
        uint r2setting = 0x300000;
        uint r3setting = 0x700080;
        uint r4setting = 0x010800;


        byte[] privateKey = { 0x00, 0xfc, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };

        public bool parity(uint word)
        {
            word ^= word >> 16;
            word ^= word >> 8;
            word ^= word >> 4;
            word ^= word >> 2;
            word ^= word >> 1;

            return Convert.ToBoolean(word & 1);
        }

        public bool maj(uint word1, uint word2, uint word3)
        {
            int sum = Convert.ToInt32(word1 != 0) + Convert.ToInt32(word2 != 0) + Convert.ToInt32(word3 != 0);
            if (sum >= 2)
                return true;
            else
                return false;
        }

        public uint clockone(uint reg, uint mask, uint setting, uint loaded_bit)
        {
            uint num = reg & setting;
            reg = (reg << 1) & mask;
            reg |= Convert.ToUInt32(parity(num));
            reg |= loaded_bit;

            return reg;
        }

        public void clock(bool clockAll, bool loaded)
        {
            bool majority = maj(r4 & r4controlr1, r4 & r4controlr2, r4 & r4controlr3);
            if (clockAll || ((r4 & r4controlr1) != 0) == majority)
                r1 = clockone(r1, maskr1, r1setting, Convert.ToUInt32(loaded) << 15);

            if (clockAll || ((r4 & r4controlr2) != 0) == majority)
                r2 = clockone(r2, maskr2, r2setting, Convert.ToUInt32(loaded) << 16);

            if (clockAll || ((r4 & r4controlr3) != 0) == majority)
                r3 = clockone(r3, maskr3, r3setting, Convert.ToUInt32(loaded) << 18);

            r4 = clockone(r4, maskr4, r4setting, Convert.ToUInt32(loaded) << 10);

        }
        public bool getBit()
        {
            uint topBits = (((r1 >> 18) ^ (r2 >> 21) ^ (r3 >> 22)) & 0x01);
            uint nowbit = (
                topBits
                ^ Convert.ToUInt32(maj(r1 & 0x8000, (~r1 & 0x4000), r1 & 0x1000))
                ^ Convert.ToUInt32(maj((~r2) & 0x10000, r2 & 0x2000, r2 & 0x200))
                ^ Convert.ToUInt32(maj(r3 & 0x40000, r3 & 0x10000, (~r3) & 0x2000))
                );
            return Convert.ToBoolean(nowbit);
        }

        public void keysetup(byte[] kc, uint f)
        {
            int i;
            uint kcbit, fbit;
            r1 = r2 = r3 = r4 = 0;
            for (i = 0; i < 22; i++)
            {
                clock(true, false);
                kcbit = (uint)((kc[i / 8] >> (i & 7)) & 1);
                r1 ^= kcbit; r2 ^= kcbit; r3 ^= kcbit; r4 ^= kcbit;
            }

            for (i = 0; i < 22; i++)
            {
                clock(true, i == 21);
                fbit = (f >> i) & 1;
                r1 ^= fbit; r2 ^= fbit; r3 ^= fbit; r4 ^= fbit;
            }
            for (i = 0; i < 100; i++)
                clock(false, false);
            getBit();
        }


        public byte[] Encrypt(byte[] data, uint publicKey)
        {
            BitArray databytes = new BitArray(data);

            keysetup(privateKey, publicKey);
            BitArray xorData = new BitArray(databytes.Length);
            for(int i = 0;i< databytes.Length; i++)
            {
                clock(false, false);
                xorData.Set(i, getBit());
            }
            BitArray resultBits = databytes.Xor(xorData);
            byte[] res = new byte[resultBits.Length / 8];
            resultBits.CopyTo(res, 0);
            return res;

        }
        public byte[] Decrypt(byte[] data, uint publicKey)
        {
            BitArray databytes = new BitArray(data);

            keysetup(privateKey, publicKey);
            BitArray xorData = new BitArray(databytes.Length);
            for (int i = 0; i < databytes.Length; i++)
            {
                clock(false, false);
                xorData.Set(i, getBit());
            }
            BitArray resultBits = databytes.Xor(xorData);
            byte[] res = new byte[resultBits.Length/8];
            resultBits.CopyTo(res, 0);

            return res;
        }
    }
}
