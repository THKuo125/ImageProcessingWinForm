using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Contrast
    {
        public int[,,] Negative(int[,,] rgb, int width, int height)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    rgb[x, y, 0] = 255 - rgb[x, y, 0];
                    rgb[x, y, 1] = 255 - rgb[x, y, 1];
                    rgb[x, y, 2] = 255 - rgb[x, y, 2];
                }
            }
            return rgb;
        }

        public int[,,] Logrithmic(int[,,] rgb, int width, int height)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    for(int i=0; i<3; i++)
                    {
                        rgb[x, y, i] = (int)(40 * Math.Log(rgb[x, y, i] + 1));
                    }
                }
            }
            return rgb;
        }

        public int[,,] Gamma(int[,,] rgb, int width, int height)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    for(int i = 0; i<3; i++)
                    {
                        float pixel = (float)(rgb[x, y, i] / 255.0);
                        rgb[x, y, i] = (int)(1 * (Math.Pow(pixel, 0.3) * 255.0f));
                    }
                }
            }
            return rgb;
        }

        public int[,,] Equalization(int[,,] rgb, int width, int height)
        {
            int pixel = width * height;
            int[] r = new int[256];
            int[] g = new int[256];
            int[] b = new int[256];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[rgb[x, y, 0]]++;
                    g[rgb[x, y, 1]]++;
                    b[rgb[x, y, 2]]++;
                }
            }

            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum = sum + r[i];
                r[i] = (int)((float)sum / (float)pixel * 255.0);
            }
            sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum = sum + g[i];
                g[i] = (int)((float)sum / (float)pixel * 255.0);
            }
            sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum = sum + b[i];
                b[i] = (int)((float)sum / (float)pixel * 255.0);
            }

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    rgb[x, y, 0] = r[rgb[x, y, 0]];
                    rgb[x, y, 1] = g[rgb[x, y, 1]];
                    rgb[x, y, 2] = b[rgb[x, y, 2]];
                }
            }
            return rgb;
        }
    }
}
