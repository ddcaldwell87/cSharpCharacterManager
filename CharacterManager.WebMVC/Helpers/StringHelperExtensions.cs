using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class StringHelperExtensions
{
    public static string Truncate(this String source)
    {
        int length = 50;
        string trunk = "...";

        if (source.Length > length)
        {
            source = source.Substring(0, length) + trunk;
        }

        return source;
    }
}