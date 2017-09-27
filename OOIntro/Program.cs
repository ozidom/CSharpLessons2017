﻿﻿﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Object Serialization 
             * Serialization can be defined as the process of storing the state of an object instance to a storage
             * medium. During this process, the public and private fields of the object and the name of the class,
             * including the assembly containing the class, is converted to a stream of bytes, which is then written
             * to a data stream. When the object is subsequently deserialized, an exact clone of the original object
             * is created.
             Source:MSDN */

            /* Serialization:Taking an Object and storing it in a suitable format
             * DeSerialization:Taking the stored and rehydrating it as an Object */


            /*  Streams 
             *  Streams are just ways to transporting data to a specific target destination.
             *  Data => PUT IT IN THE STREAM => STORE IT SOMEWHERE
                FileStream – for reading and writing to a file.
                IsolatedStorageFileStream – for reading and writing to a file in isolated storage.
                MemoryStream – for reading and writing to memory as the backing store.
                BufferedStream – for improving performance of read and write operations.
                NetworkStream – for reading and writing over network sockets.
                PipeStream – for reading and writing over anonymous and named pipes.
                CryptoStream – for linking data streams to cryptographic transformations. 
                Source:MSDN */

            /* Serialization and Steams
             * Serilize the Data => PUT IT IN THE STREAM => STORE IT SOMEWHERE or SEND IT SOMEWHERE */

            SimpleEmployee employee = new SimpleEmployee();
            employee.Name = "John Wayne";
            employee.DOB = new DateTime(1908, 1, 1);
            employee.PayRate = 1000;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\temp\MyEmployee.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, employee);
            stream.Close();

            //OK SO thats been saved now - now lets desiralized
            IFormatter deSerializationformatter = new BinaryFormatter();
            Stream deSerializationStream = new FileStream(@"C:\temp\MyEmployee.bin",
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
            SimpleEmployee obj = (SimpleEmployee)formatter.Deserialize(deSerializationStream);

            Console.WriteLine($"{obj.Name}");
            deSerializationStream.Close();
            Console.ReadLine();
        }
    }

    [Serializable]
    public class SimpleEmployee
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int PayRate { get; set; }
    }
}
