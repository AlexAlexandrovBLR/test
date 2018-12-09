using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Extensions
{
    public static class ImageHelper
    {
        public static byte[] GetBytes(this string fileName)
        {

            var data = File.ReadAllBytes(fileName);
            return data;

        }
    }
}
