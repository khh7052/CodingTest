using System;

public class Solution
{
    public int solution(int[,] dots)
    {
        int x1 = dots[0,0], y1 = dots[0,1];
        int x2 = dots[1,0], y2 = dots[1,1];
        int x3 = dots[2,0], y3 = dots[2,1];
        int x4 = dots[3,0], y4 = dots[3,1];

        if (Slope(x1,y1,x2,y2) == Slope(x3,y3,x4,y4)) return 1;
        if (Slope(x1,y1,x3,y3) == Slope(x2,y2,x4,y4)) return 1;
        if (Slope(x1,y1,x4,y4) == Slope(x2,y2,x3,y3)) return 1;

        return 0;
    }
    
    double Slope(int xa, int ya, int xb, int yb) 
        => (double)(yb - ya) / (xb - xa);
}
