using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class removeWhite
    {
        public static void PictureWhite(Bitmap background, Bitmap newPicture, int x, int y)
        {
            for (int z = 0; z < newPicture.Height; z++)
            {
                for (int r = 0; r < newPicture.Width; r++)
                {
                    if (newPicture.GetPixel(x, y).A < 255)
                    {
                        Color newColor = background.GetPixel(r + x, z + y);
                        newPicture.SetPixel(x, y, newColor);
                    }
                }
            }
        }
        public static void PictureWhite(PictureBox background, PictureBox frontend)
        {
            int leftAndRight = Math.Abs(background.Left - frontend.Left);
            int topAndDown = Math.Abs(background.Top - frontend.Top);
            PictureWhite((Bitmap)background.Image, (Bitmap)frontend.Image, leftAndRight, topAndDown);
        }
    }
}
