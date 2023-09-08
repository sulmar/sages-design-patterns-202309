using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class CloudStream
    {
        public virtual void Write(string data)
        {
            Console.WriteLine($"Storing {data}");
        }
    }

    public class EncryptedCloudStream : CloudStream
    {
        public override void Write(string data)
        {
            var encrypted = Encrypt(data);
            base.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "!@$%^%&^&^$%^#";
        }
    }

    public class CompressedCloudStream : CloudStream
    {
        public override void Write(string data)
        {
            var compressed = Compress(data);
            base.Write(compressed);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }

    public class CompressAndEncryptedCloudStream : CloudStream
    {
        
    }

}
