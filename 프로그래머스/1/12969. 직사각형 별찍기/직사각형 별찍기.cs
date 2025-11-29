using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        String[] s = Console.ReadLine().Split(' ');

        int w = Int32.Parse(s[0]);
        int h = Int32.Parse(s[1]);

        for(int i = 0; i < h; i++){
            sb.Append('*', w);
            sb.Append($"\n");
        }
        
        Console.WriteLine(sb);
    }
}