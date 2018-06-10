using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _19.Thea_The_Photographer
{
    class 19. Thea The Photographer
    {
        static void Main(string[] args)
        {
            var picturesCount = int.Parse(Console.ReadLine());
            var singlePictureFilterTime = int.Parse(Console.ReadLine());
            var filterPrecentage = int.Parse(Console.ReadLine());
            var singlePictureUploadTime = int.Parse(Console.ReadLine());

            var filterTimeSecond = (long)picturesCount * singlePictureFilterTime;

            // 100 was casted to double and Math.Cailing was casted to long 
            var picturesToUpload = (long)Math.Ceiling(picturesCount * (filterPrecentage / 100d));
            var uploadTimeSeconds = picturesToUpload * singlePictureUploadTime;

            var totalTimeNeedSeconds = filterTimeSecond + uploadTimeSeconds;

            var totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTimeNeedSeconds);
            // printing in a specific format
            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"d\:hh\:mm\:ss")); 
        }
    }
}
