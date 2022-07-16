
using System.Drawing;
using System.IO;
namespace Exam_Management_System.Image_controll
{
    internal class Images
    {

        public static void ConvertImageToByte()
        {

        }


        public static MemoryStream SaveImageToStream(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms;
        }

    }
}
