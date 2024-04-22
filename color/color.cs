using System;
using System.Security.Cryptography.X509Certificates;
public static class color
{
    public static String Tocharrr(this string character)
    {
        switch (character)
        {
            case "r":
                return "red";
            case "b":
                return "black";
            case "y":
                return "yellow";
            case "w":
                return "white";
           default :
                return null;
        }




    }



}