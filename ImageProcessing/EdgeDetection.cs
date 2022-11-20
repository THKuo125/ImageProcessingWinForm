using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class EdgeDetection
    {
        public int[,,] Sobel(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];

            for (int x=0; x<width; x++)
            {
                for (int y=0; y<height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }
            
            int Gx = 0;
            int Gy = 0;
            for (int x=1; x<width-1; x++)
            {
                for (int y=1; y<height-1; y++)
                {
                    Gx = (r[x+1, y-1] + 2 * r[x+1, y] + r[x+1, y+1]) - (r[x-1, y-1] + 2 * r[x-1, y] + r[x-1, y+1]);
                    Gy = (r[x-1, y-1] + 2 * r[x, y-1] + r[x+1, y-1]) - (r[x-1, y+1] + 2 * r[x, y+1] + r[x+1, y+1]);
                    int Gr = (int)Math.Sqrt((Math.Pow(Gx, 2) + Math.Pow(Gy, 2)));
                    if(Gr > 255)
                    {
                        Gr = 255;
                    }

                    Gx = (g[x + 1, y - 1] + 2 * g[x + 1, y] + g[x + 1, y + 1]) - (g[x - 1, y - 1] + 2 * g[x - 1, y] + g[x - 1, y + 1]);
                    Gy = (g[x - 1, y - 1] + 2 * g[x, y - 1] + g[x + 1, y - 1]) - (g[x - 1, y + 1] + 2 * g[x, y + 1] + g[x + 1, y + 1]);
                    int Gg = (int)Math.Sqrt((Math.Pow(Gx, 2) + Math.Pow(Gy, 2)));
                    if (Gg > 255)
                    {
                        Gg = 255;
                    }

                    Gx = (b[x + 1, y - 1] + 2 * b[x + 1, y] + b[x + 1, y + 1]) - (b[x - 1, y - 1] + 2 * b[x - 1, y] + b[x - 1, y + 1]);
                    Gy = (b[x - 1, y - 1] + 2 * b[x, y - 1] + b[x + 1, y - 1]) - (b[x - 1, y + 1] + 2 * b[x, y + 1] + b[x + 1, y + 1]);
                    int Gb = (int)Math.Sqrt((Math.Pow(Gx, 2) + Math.Pow(Gy, 2)));
                    if (Gb > 255)
                    {
                        Gb = 255;
                    }

                    rgb[x, y, 0] = Gr;
                    rgb[x, y, 1] = Gg;
                    rgb[x, y, 2] = Gb;
                }
            }
            return rgb;
        }
        public int[,,] Laplacian4(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];
            int[,] Laplacian_Mask = new int[3, 3]
            {
                {0, -1, 0}, {-1, 4, -1}, {0, -1, 0}
            };

            for (int x=0; x<width; x++)
            {
                for(int y=0; y<height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }
            for(int x=1; x<width-1; x++)
            {
                for(int y=1; y<height-1; y++)
                {
                    int threshold_r = Laplacian_Mask[0, 0] * r[x - 1, y + 1] + Laplacian_Mask[0, 1] * r[x, y + 1] + Laplacian_Mask[0, 2] * r[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * r[x - 1, y] + Laplacian_Mask[1, 1] * r[x, y] + Laplacian_Mask[1, 2] * r[x + 1, y] +
                                       Laplacian_Mask[2, 0] * r[x - 1, y - 1] + Laplacian_Mask[2, 1] * r[x, y - 1] + Laplacian_Mask[2, 2] * r[x + 1, y - 1];
                    if(threshold_r > 255)
                    {
                        threshold_r = 255;
                    }
                    if(threshold_r < 0)
                    {
                        threshold_r = 0;
                    }

                    int threshold_g = Laplacian_Mask[0, 0] * g[x - 1, y + 1] + Laplacian_Mask[0, 1] * g[x, y + 1] + Laplacian_Mask[0, 2] * g[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * g[x - 1, y] + Laplacian_Mask[1, 1] * g[x, y] + Laplacian_Mask[1, 2] * g[x + 1, y] +
                                       Laplacian_Mask[2, 0] * g[x - 1, y - 1] + Laplacian_Mask[2, 1] * g[x, y - 1] + Laplacian_Mask[2, 2] * g[x + 1, y - 1];
                    if (threshold_g > 255)
                    {
                        threshold_g = 255;
                    }
                    if (threshold_g < 0)
                    {
                        threshold_g = 0;
                    }

                    int threshold_b = Laplacian_Mask[0, 0] * b[x - 1, y + 1] + Laplacian_Mask[0, 1] * b[x, y + 1] + Laplacian_Mask[0, 2] * b[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * b[x - 1, y] + Laplacian_Mask[1, 1] * b[x, y] + Laplacian_Mask[1, 2] * b[x + 1, y] +
                                       Laplacian_Mask[2, 0] * b[x - 1, y - 1] + Laplacian_Mask[2, 1] * b[x, y - 1] + Laplacian_Mask[2, 2] * b[x + 1, y - 1];
                    if (threshold_b > 255)
                    {
                        threshold_b = 255;
                    }
                    if (threshold_b < 0)
                    {
                        threshold_b = 0;
                    }

                    rgb[x, y, 0] = threshold_r;
                    rgb[x, y, 1] = threshold_g;
                    rgb[x, y, 2] = threshold_b;
                }
            }
            return rgb;
        }

        public int[,,] LaplacianAdd4(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];
            int[,,] origin = new int[width, height, 3];
            int[,] Laplacian_Mask = new int[3, 3]
            {
                {0, -1, 0}, {-1, 4, -1}, {0, -1, 0}
            };

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }
            for (int x = 1; x < width-1; x++)
            {
                for (int y = 1; y < height-1; y++)
                {
                    int threshold_r = Laplacian_Mask[0, 0] * r[x - 1, y + 1] + Laplacian_Mask[0, 1] * r[x, y + 1] + Laplacian_Mask[0, 2] * r[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * r[x - 1, y] + Laplacian_Mask[1, 1] * r[x, y] + Laplacian_Mask[1, 2] * r[x + 1, y] +
                                       Laplacian_Mask[2, 0] * r[x - 1, y - 1] + Laplacian_Mask[2, 1] * r[x, y - 1] + Laplacian_Mask[2, 2] * r[x + 1, y - 1];
                    if (threshold_r > 255)
                    {
                        threshold_r = 255;
                    }
                    if (threshold_r < 0)
                    {
                        threshold_r = 0;
                    }

                    int threshold_g = Laplacian_Mask[0, 0] * g[x - 1, y + 1] + Laplacian_Mask[0, 1] * g[x, y + 1] + Laplacian_Mask[0, 2] * g[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * g[x - 1, y] + Laplacian_Mask[1, 1] * g[x, y] + Laplacian_Mask[1, 2] * g[x + 1, y] +
                                       Laplacian_Mask[2, 0] * g[x - 1, y - 1] + Laplacian_Mask[2, 1] * g[x, y - 1] + Laplacian_Mask[2, 2] * g[x + 1, y - 1];
                    if (threshold_g > 255)
                    {
                        threshold_g = 255;
                    }
                    if (threshold_g < 0)
                    {
                        threshold_g = 0;
                    }

                    int threshold_b = Laplacian_Mask[0, 0] * b[x - 1, y + 1] + Laplacian_Mask[0, 1] * b[x, y + 1] + Laplacian_Mask[0, 2] * b[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * b[x - 1, y] + Laplacian_Mask[1, 1] * b[x, y] + Laplacian_Mask[1, 2] * b[x + 1, y] +
                                       Laplacian_Mask[2, 0] * b[x - 1, y - 1] + Laplacian_Mask[2, 1] * b[x, y - 1] + Laplacian_Mask[2, 2] * b[x + 1, y - 1];
                    if (threshold_b > 255)
                    {
                        threshold_b = 255;
                    }
                    if (threshold_b < 0)
                    {
                        threshold_b = 0;
                    }

                    rgb[x, y, 0] = threshold_r;
                    rgb[x, y, 1] = threshold_g;
                    rgb[x, y, 2] = threshold_b;

                    origin[x, y, 0] = r[x, y] + rgb[x, y, 0];
                    origin[x, y, 1] = g[x, y] + rgb[x, y, 1];
                    origin[x, y, 2] = b[x, y] + rgb[x, y, 2];
                }
            }
            return origin;
        }

        public int[,,] LaplacianMinus4(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];
            int[,,] origin = new int[width, height, 3];
            int[,] Laplacian_Mask = new int[3, 3]
            {
                {0, -1, 0}, {-1, 4, -1}, {0, -1, 0}
            };

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }
            for (int x = 1; x < width-1; x++)
            {
                for (int y = 1; y < height-1; y++)
                {
                    int threshold_r = Laplacian_Mask[0, 0] * r[x - 1, y + 1] + Laplacian_Mask[0, 1] * r[x, y + 1] + Laplacian_Mask[0, 2] * r[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * r[x - 1, y] + Laplacian_Mask[1, 1] * r[x, y] + Laplacian_Mask[1, 2] * r[x + 1, y] +
                                       Laplacian_Mask[2, 0] * r[x - 1, y - 1] + Laplacian_Mask[2, 1] * r[x, y - 1] + Laplacian_Mask[2, 2] * r[x + 1, y - 1];
                    if (threshold_r > 255)
                    {
                        threshold_r = 255;
                    }
                    if (threshold_r < 0)
                    {
                        threshold_r = 0;
                    }

                    int threshold_g = Laplacian_Mask[0, 0] * g[x - 1, y + 1] + Laplacian_Mask[0, 1] * g[x, y + 1] + Laplacian_Mask[0, 2] * g[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * g[x - 1, y] + Laplacian_Mask[1, 1] * g[x, y] + Laplacian_Mask[1, 2] * g[x + 1, y] +
                                       Laplacian_Mask[2, 0] * g[x - 1, y - 1] + Laplacian_Mask[2, 1] * g[x, y - 1] + Laplacian_Mask[2, 2] * g[x + 1, y - 1];
                    if (threshold_g > 255)
                    {
                        threshold_g = 255;
                    }
                    if (threshold_g < 0)
                    {
                        threshold_g = 0;
                    }

                    int threshold_b = Laplacian_Mask[0, 0] * b[x - 1, y + 1] + Laplacian_Mask[0, 1] * b[x, y + 1] + Laplacian_Mask[0, 2] * b[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * b[x - 1, y] + Laplacian_Mask[1, 1] * b[x, y] + Laplacian_Mask[1, 2] * b[x + 1, y] +
                                       Laplacian_Mask[2, 0] * b[x - 1, y - 1] + Laplacian_Mask[2, 1] * b[x, y - 1] + Laplacian_Mask[2, 2] * b[x + 1, y - 1];
                    if (threshold_b > 255)
                    {
                        threshold_b = 255;
                    }
                    if (threshold_b < 0)
                    {
                        threshold_b = 0;
                    }

                    rgb[x, y, 0] = threshold_r;
                    rgb[x, y, 1] = threshold_g;
                    rgb[x, y, 2] = threshold_b;

                    origin[x, y, 0] = r[x, y] - rgb[x, y, 0];
                    origin[x, y, 1] = g[x, y] - rgb[x, y, 1];
                    origin[x, y, 2] = b[x, y] - rgb[x, y, 2];
                }
            }
            return origin;
        }

        public int[,,] Laplacian9(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];
            int[,] Laplacian_Mask = new int[3, 3]
            {
                {-1, -1, -1}, {-1, 9, -1}, {-1, -1, -1}
            };

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }
            for (int x = 1; x < width-1; x++)
            {
                for (int y = 1; y < height-1; y++)
                {
                    int threshold_r = Laplacian_Mask[0, 0] * r[x - 1, y + 1] + Laplacian_Mask[0, 1] * r[x, y + 1] + Laplacian_Mask[0, 2] * r[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * r[x - 1, y] + Laplacian_Mask[1, 1] * r[x, y] + Laplacian_Mask[1, 2] * r[x + 1, y] +
                                       Laplacian_Mask[2, 0] * r[x - 1, y - 1] + Laplacian_Mask[2, 1] * r[x, y - 1] + Laplacian_Mask[2, 2] * r[x + 1, y - 1];
                    if (threshold_r > 255)
                    {
                        threshold_r = 255;
                    }
                    if (threshold_r < 0)
                    {
                        threshold_r = 0;
                    }

                    int threshold_g = Laplacian_Mask[0, 0] * g[x - 1, y + 1] + Laplacian_Mask[0, 1] * g[x, y + 1] + Laplacian_Mask[0, 2] * g[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * g[x - 1, y] + Laplacian_Mask[1, 1] * g[x, y] + Laplacian_Mask[1, 2] * g[x + 1, y] +
                                       Laplacian_Mask[2, 0] * g[x - 1, y - 1] + Laplacian_Mask[2, 1] * g[x, y - 1] + Laplacian_Mask[2, 2] * g[x + 1, y - 1];
                    if (threshold_g > 255)
                    {
                        threshold_g = 255;
                    }
                    if (threshold_g < 0)
                    {
                        threshold_g = 0;
                    }

                    int threshold_b = Laplacian_Mask[0, 0] * b[x - 1, y + 1] + Laplacian_Mask[0, 1] * b[x, y + 1] + Laplacian_Mask[0, 2] * b[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * b[x - 1, y] + Laplacian_Mask[1, 1] * b[x, y] + Laplacian_Mask[1, 2] * b[x + 1, y] +
                                       Laplacian_Mask[2, 0] * b[x - 1, y - 1] + Laplacian_Mask[2, 1] * b[x, y - 1] + Laplacian_Mask[2, 2] * b[x + 1, y - 1];
                    if (threshold_b > 255)
                    {
                        threshold_b = 255;
                    }
                    if (threshold_b < 0)
                    {
                        threshold_b = 0;
                    }

                    rgb[x, y, 0] = threshold_r;
                    rgb[x, y, 1] = threshold_g;
                    rgb[x, y, 2] = threshold_b;
                }
            }
            return rgb;
        }

        public int[,,] LaplacianAdd9(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];
            int[,,] origin = new int[width, height, 3];
            int[,] Laplacian_Mask = new int[3, 3]
            {
                {-1, -1, -1}, {-1, 9, -1}, {-1, -1, -1}
            };

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }
            for (int x = 1; x < width-1; x++)
            {
                for (int y = 1; y < height-1; y++)
                {
                    int threshold_r = Laplacian_Mask[0, 0] * r[x - 1, y + 1] + Laplacian_Mask[0, 1] * r[x, y + 1] + Laplacian_Mask[0, 2] * r[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * r[x - 1, y] + Laplacian_Mask[1, 1] * r[x, y] + Laplacian_Mask[1, 2] * r[x + 1, y] +
                                       Laplacian_Mask[2, 0] * r[x - 1, y - 1] + Laplacian_Mask[2, 1] * r[x, y - 1] + Laplacian_Mask[2, 2] * r[x + 1, y - 1];
                    if (threshold_r > 255)
                    {
                        threshold_r = 255;
                    }
                    if (threshold_r < 0)
                    {
                        threshold_r = 0;
                    }

                    int threshold_g = Laplacian_Mask[0, 0] * g[x - 1, y + 1] + Laplacian_Mask[0, 1] * g[x, y + 1] + Laplacian_Mask[0, 2] * g[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * g[x - 1, y] + Laplacian_Mask[1, 1] * g[x, y] + Laplacian_Mask[1, 2] * g[x + 1, y] +
                                       Laplacian_Mask[2, 0] * g[x - 1, y - 1] + Laplacian_Mask[2, 1] * g[x, y - 1] + Laplacian_Mask[2, 2] * g[x + 1, y - 1];
                    if (threshold_g > 255)
                    {
                        threshold_g = 255;
                    }
                    if (threshold_g < 0)
                    {
                        threshold_g = 0;
                    }

                    int threshold_b = Laplacian_Mask[0, 0] * b[x - 1, y + 1] + Laplacian_Mask[0, 1] * b[x, y + 1] + Laplacian_Mask[0, 2] * b[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * b[x - 1, y] + Laplacian_Mask[1, 1] * b[x, y] + Laplacian_Mask[1, 2] * b[x + 1, y] +
                                       Laplacian_Mask[2, 0] * b[x - 1, y - 1] + Laplacian_Mask[2, 1] * b[x, y - 1] + Laplacian_Mask[2, 2] * b[x + 1, y - 1];
                    if (threshold_b > 255)
                    {
                        threshold_b = 255;
                    }
                    if (threshold_b < 0)
                    {
                        threshold_b = 0;
                    }

                    rgb[x, y, 0] = threshold_r;
                    rgb[x, y, 1] = threshold_g;
                    rgb[x, y, 2] = threshold_b;

                    origin[x, y, 0] = r[x, y] + rgb[x, y, 0];
                    origin[x, y, 1] = g[x, y] + rgb[x, y, 1];
                    origin[x, y, 2] = b[x, y] + rgb[x, y, 2];
                }
            }
            return origin;
        }

        public int[,,] LaplacianMinus9(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];
            int[,,] origin = new int[width, height, 3];
            int[,] Laplacian_Mask = new int[3, 3]
            {
                {-1, -1, -1}, {-1, 9, -1}, {-1, -1, -1}
            };

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }
            for (int x = 1; x < width-1; x++)
            {
                for (int y = 1; y < height-1; y++)
                {
                    int threshold_r = Laplacian_Mask[0, 0] * r[x - 1, y + 1] + Laplacian_Mask[0, 1] * r[x, y + 1] + Laplacian_Mask[0, 2] * r[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * r[x - 1, y] + Laplacian_Mask[1, 1] * r[x, y] + Laplacian_Mask[1, 2] * r[x + 1, y] +
                                       Laplacian_Mask[2, 0] * r[x - 1, y - 1] + Laplacian_Mask[2, 1] * r[x, y - 1] + Laplacian_Mask[2, 2] * r[x + 1, y - 1];
                    if (threshold_r > 255)
                    {
                        threshold_r = 255;
                    }
                    if (threshold_r < 0)
                    {
                        threshold_r = 0;
                    }

                    int threshold_g = Laplacian_Mask[0, 0] * g[x - 1, y + 1] + Laplacian_Mask[0, 1] * g[x, y + 1] + Laplacian_Mask[0, 2] * g[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * g[x - 1, y] + Laplacian_Mask[1, 1] * g[x, y] + Laplacian_Mask[1, 2] * g[x + 1, y] +
                                       Laplacian_Mask[2, 0] * g[x - 1, y - 1] + Laplacian_Mask[2, 1] * g[x, y - 1] + Laplacian_Mask[2, 2] * g[x + 1, y - 1];
                    if (threshold_g > 255)
                    {
                        threshold_g = 255;
                    }
                    if (threshold_g < 0)
                    {
                        threshold_g = 0;
                    }

                    int threshold_b = Laplacian_Mask[0, 0] * b[x - 1, y + 1] + Laplacian_Mask[0, 1] * b[x, y + 1] + Laplacian_Mask[0, 2] * b[x + 1, y + 1] +
                                       Laplacian_Mask[1, 0] * b[x - 1, y] + Laplacian_Mask[1, 1] * b[x, y] + Laplacian_Mask[1, 2] * b[x + 1, y] +
                                       Laplacian_Mask[2, 0] * b[x - 1, y - 1] + Laplacian_Mask[2, 1] * b[x, y - 1] + Laplacian_Mask[2, 2] * b[x + 1, y - 1];
                    if (threshold_b > 255)
                    {
                        threshold_b = 255;
                    }
                    if (threshold_b < 0)
                    {
                        threshold_b = 0;
                    }

                    rgb[x, y, 0] = threshold_r;
                    rgb[x, y, 1] = threshold_g;
                    rgb[x, y, 2] = threshold_b;

                    origin[x, y, 0] = r[x, y] - rgb[x, y, 0];
                    origin[x, y, 1] = g[x, y] - rgb[x, y, 1];
                    origin[x, y, 2] = b[x, y] - rgb[x, y, 2];
                }
            }
            return origin;
        }

    }
}
