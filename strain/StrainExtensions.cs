using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class StrainExtensions
{
    public static LinkedList<int> Keep(this LinkedList<int> list, Func<int, bool> f)
    {
        return new LinkedList<int>();
    }
    public static LinkedList<int> Discard(this LinkedList<int> list, Func<int, bool> f)
    {
        return new LinkedList<int>();
    }


    public static HashSet<int> Keep(this HashSet<int> set, Func<int, bool> f)
    {
        return new HashSet<int>();
    }

    public static HashSet<int> Discard(this HashSet<int> set, Func<int, bool> f)
    {
        return new HashSet<int>();
    }

    public static int[] Keep(this int[] array, Func<int, bool> f)
    {
        return new int[0];
    }

    public static int[] Discard(this int[] array, Func<int, bool> f)
    {
        return new int[0];
    }

    public static List<int> Keep(this List<int> list, Func<int, bool> f)
    {
        return new List<int>();
    }

    public static List<int> Discard(this List<int> list, Func<int, bool> f)
    {
        return new List<int>();
    }

    public static string[] Keep(this string[] array, Func<string, bool> f)
    {
        return new string[0];
    }
    public static string[] Discard(this string[] array, Func<string, bool> f)
    {
        return new string[0];
    }

    public static int[][] Keep(this int[][] array, Func<int[], bool> f)
    {
        return new int[0][];
    }
    public static int[][] Discard(this int[][] array, Func<int[], bool> f)
    {
        return new int[0][];
    }


}

