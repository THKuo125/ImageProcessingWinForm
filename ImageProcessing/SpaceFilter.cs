using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class SpaceFilter
    {
        public int[,,] Minimum(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }

            int[] filter = new int[9];
            for(int x=1; x<width-1; x++)
            {
                for(int y=1; y<height-1; y++)
                {
                    filter[0] = r[x - 1, y - 1];
                    filter[1] = r[x    , y - 1];
                    filter[2] = r[x + 1, y - 1];
                    filter[3] = r[x - 1, y    ];
                    filter[4] = r[x    , y    ];
                    filter[5] = r[x + 1, y    ];
                    filter[6] = r[x - 1, y + 1];
                    filter[7] = r[x    , y + 1];
                    filter[8] = r[x + 1, y + 1];

                    Array.Sort(filter);
                    int filterR = filter[0];
                    rgb[x, y, 0] = filterR;

                    filter[0] = g[x - 1, y - 1];
                    filter[1] = g[x    , y - 1];
                    filter[2] = g[x + 1, y - 1];
                    filter[3] = g[x - 1, y    ];
                    filter[4] = g[x    , y    ];
                    filter[5] = g[x + 1, y    ];
                    filter[6] = g[x - 1, y + 1];
                    filter[7] = g[x    , y + 1];
                    filter[8] = g[x + 1, y + 1];

                    Array.Sort(filter);
                    int filterG = filter[0];
                    rgb[x, y, 1] = filterG;

                    filter[0] = b[x - 1, y - 1];
                    filter[1] = b[x    , y - 1];
                    filter[2] = b[x + 1, y - 1];
                    filter[3] = b[x - 1, y    ];
                    filter[4] = b[x    , y    ];
                    filter[5] = b[x + 1, y    ];
                    filter[6] = b[x - 1, y + 1];
                    filter[7] = b[x, y + 1    ];
                    filter[8] = b[x + 1, y + 1];

                    Array.Sort(filter);
                    int filterB = filter[0];
                    rgb[x, y, 2] = filterB;
                }
            }
            return rgb;
        }

        public int[,,] Median(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }

            int[] filter = new int[9];
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    filter[0] = r[x - 1, y - 1];
                    filter[1] = r[x, y - 1];
                    filter[2] = r[x + 1, y - 1];
                    filter[3] = r[x - 1, y];
                    filter[4] = r[x, y];
                    filter[5] = r[x + 1, y];
                    filter[6] = r[x - 1, y + 1];
                    filter[7] = r[x, y + 1];
                    filter[8] = r[x + 1, y + 1];

                    Array.Sort(filter);
                    int filterR = filter[4];
                    rgb[x, y, 0] = filterR;

                    filter[0] = g[x - 1, y - 1];
                    filter[1] = g[x, y - 1];
                    filter[2] = g[x + 1, y - 1];
                    filter[3] = g[x - 1, y];
                    filter[4] = g[x, y];
                    filter[5] = g[x + 1, y];
                    filter[6] = g[x - 1, y + 1];
                    filter[7] = g[x, y + 1];
                    filter[8] = g[x + 1, y + 1];

                    Array.Sort(filter);
                    int filterG = filter[4];
                    rgb[x, y, 1] = filterG;

                    filter[0] = b[x - 1, y - 1];
                    filter[1] = b[x, y - 1];
                    filter[2] = b[x + 1, y - 1];
                    filter[3] = b[x - 1, y];
                    filter[4] = b[x, y];
                    filter[5] = b[x + 1, y];
                    filter[6] = b[x - 1, y + 1];
                    filter[7] = b[x, y + 1];
                    filter[8] = b[x + 1, y + 1];

                    Array.Sort(filter);
                    int filterB = filter[4];
                    rgb[x, y, 2] = filterB;
                }
            }
            return rgb;
        }

        public int[,,] Maximum(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }

            int[] filter = new int[9];
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    filter[0] = r[x - 1, y - 1];
                    filter[1] = r[x, y - 1];
                    filter[2] = r[x + 1, y - 1];
                    filter[3] = r[x - 1, y];
                    filter[4] = r[x, y];
                    filter[5] = r[x + 1, y];
                    filter[6] = r[x - 1, y + 1];
                    filter[7] = r[x, y + 1];
                    filter[8] = r[x + 1, y + 1];

                    Array.Sort(filter);
                    int filterR = filter[8];
                    rgb[x, y, 0] = filterR;

                    filter[0] = g[x - 1, y - 1];
                    filter[1] = g[x, y - 1];
                    filter[2] = g[x + 1, y - 1];
                    filter[3] = g[x - 1, y];
                    filter[4] = g[x, y];
                    filter[5] = g[x + 1, y];
                    filter[6] = g[x - 1, y + 1];
                    filter[7] = g[x, y + 1];
                    filter[8] = g[x + 1, y + 1];

                    Array.Sort(filter);
                    int filterG = filter[8];
                    rgb[x, y, 1] = filterG;

                    filter[0] = b[x - 1, y - 1];
                    filter[1] = b[x, y - 1];
                    filter[2] = b[x + 1, y - 1];
                    filter[3] = b[x - 1, y];
                    filter[4] = b[x, y];
                    filter[5] = b[x + 1, y];
                    filter[6] = b[x - 1, y + 1];
                    filter[7] = b[x, y + 1];
                    filter[8] = b[x + 1, y + 1];

                    Array.Sort(filter);
                    int filterB = filter[8];
                    rgb[x, y, 2] = filterB;
                }
            }
            return rgb;
        }

        public int[,,] Mean(int[,,] rgb, int width, int height)
        {
            int[,] r = new int[width, height];
            int[,] g = new int[width, height];
            int[,] b = new int[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[x, y] = rgb[x, y, 0];
                    g[x, y] = rgb[x, y, 1];
                    b[x, y] = rgb[x, y, 2];
                }
            }

            int[] filter = new int[9];
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    filter[0] = r[x - 1, y - 1];
                    filter[1] = r[x, y - 1];
                    filter[2] = r[x + 1, y - 1];
                    filter[3] = r[x - 1, y];
                    filter[4] = r[x, y];
                    filter[5] = r[x + 1, y];
                    filter[6] = r[x - 1, y + 1];
                    filter[7] = r[x, y + 1];
                    filter[8] = r[x + 1, y + 1];

                    Array.Sort(filter);
                    int sum = 0;
                    for(int i=0; i<9; i++)
                    {
                        sum += filter[i];
                    }
                    int filterR = sum / 9;
                    rgb[x, y, 0] = filterR;

                    filter[0] = g[x - 1, y - 1];
                    filter[1] = g[x, y - 1];
                    filter[2] = g[x + 1, y - 1];
                    filter[3] = g[x - 1, y];
                    filter[4] = g[x, y];
                    filter[5] = g[x + 1, y];
                    filter[6] = g[x - 1, y + 1];
                    filter[7] = g[x, y + 1];
                    filter[8] = g[x + 1, y + 1];

                    Array.Sort(filter);
                    sum = 0;
                    for (int i = 0; i < 9; i++)
                    {
                        sum += filter[i];
                    }
                    int filterG = sum / 9;
                    rgb[x, y, 1] = filterG;

                    filter[0] = b[x - 1, y - 1];
                    filter[1] = b[x, y - 1];
                    filter[2] = b[x + 1, y - 1];
                    filter[3] = b[x - 1, y];
                    filter[4] = b[x, y];
                    filter[5] = b[x + 1, y];
                    filter[6] = b[x - 1, y + 1];
                    filter[7] = b[x, y + 1];
                    filter[8] = b[x + 1, y + 1];

                    Array.Sort(filter);
                    sum = 0;
                    for (int i = 0; i < 9; i++)
                    {
                        sum += filter[i];
                    }
                    int filterB = sum / 9;
                    rgb[x, y, 2] = filterB;
                }
            }
            return rgb;
        }
    }
}
