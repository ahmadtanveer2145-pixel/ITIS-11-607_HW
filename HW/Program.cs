cat << 'EOF' > Program.cs
using System;

class Program
{
    static void Main()
    {
        int m = 5;
        int n = 10;

        // This loop starts at m, checks if it is less than or equal to n, and adds 1 each time
        for (int i = m; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}

