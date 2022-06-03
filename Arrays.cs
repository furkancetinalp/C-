using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static void plusMinus(List<int> arr)
    {
        float positive=0;
        float zero=0;
        float negative=0;
        foreach (int i in arr){
            if(i<0){
                negative+=1;
            }
            else if(i==0){
                zero++;
            }
            else{
                positive++;
            }
            
        }
        
        Console.WriteLine(positive/arr.Count);
        Console.WriteLine(negative/arr.Count);
        Console.WriteLine(zero/arr.Count);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
