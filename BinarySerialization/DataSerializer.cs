﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    public class DataSerializer
    {
        public void BinarySerialize(object data, string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath))
                File.Delete(filePath);
            fileStream = File.Create(filePath);
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }

        public object BinaryDeserialize(string filePath)
        {
            Object obj = null;
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if(File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;
        }

        
    }
}
