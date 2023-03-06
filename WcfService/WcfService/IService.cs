using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        void EncryptA52(string loadPath, string savePath);
        [OperationContract]
        void DecryptA52(string loadPath, string savePath);
        [OperationContract]
        void EncryptRailFence(string loadPath, string savePath);
        [OperationContract]
        void DecryptRailDence(string loadPath, string savePath);
        [OperationContract]
        void EncryptXTEA(string loadPath, string savePath);
        [OperationContract]
        void DecryptXTEA(string loadPath, string savePath);
        [OperationContract]
        void EncryptPCBC(string loadPath, string savePath);
        [OperationContract]
        void DecryptPCBC(string loadPath, string savePath);


        [OperationContract]
        void EncryptA52BMP(string loadPath, string savePath);
        [OperationContract]
        void DecryptA52BMP(string loadPath, string savePath);
        [OperationContract]
        void EncryptRailFenceBMP(string loadPath, string savePath);
        [OperationContract]
        void DecryptRailDenceBMP(string loadPath, string savePath);
        [OperationContract]
        void EncryptPCBCBMP(string loadPath, string savePath);
        [OperationContract]
        void DecryptPCBCBMP(string loadPath, string savePath);
        [OperationContract]
        bool Md5hash(string loadPath, string savePath);
        [OperationContract]
        void EncryptParalelization(string loadPath, string savePath, int numberOfThreads,int rails);
    }
}
