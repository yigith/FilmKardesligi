using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKardesligi
{
    public static class Utilities
    {
        public static string Yildizla(int derece)
        {
            // ★: 2605  ☆: 2606
            return new string('\x2605', derece) + new string('\x2606', 5 - derece);
        }

        public static string Virgulle(this IEnumerable<string> kaynak)
        {
            return string.Join(", ", kaynak);
        }

        // https://stackoverflow.com/questions/3801275/how-to-convert-image-to-byte-array
        public static byte[] ImageToByteArray(Image image)
        {
            return (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
        }

        // https://stackoverflow.com/questions/9173904/byte-array-to-image-conversion
        public static Image ByteArrayToImage(byte[] data)
        {
            return (Bitmap)new ImageConverter().ConvertFrom(data);
        }
    }
}
