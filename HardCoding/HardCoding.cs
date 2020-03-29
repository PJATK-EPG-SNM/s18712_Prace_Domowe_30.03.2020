using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{

    void Start()
    {
        int a;
        a = 100;
        Debug.Log(a);

        int b;
        b = 120;
        Debug.Log(b);

        float fa;
        fa = 2.5f;
        bool c = true;
        bool d = false;

        string str = "Programuję w C#";
        string str1 = "EPG";

        Debug.Log("fa: " + fa + "c: " + c + "b: " + b + "str: " + str + "str1: " + str1);

        Koniunkcja(a, b, c, d);
        Alternatywa(a, b, c, d);

        Debug.Log(a == fa);
        Debug.Log(a != fa);
        Debug.Log(a > fa);
        Debug.Log(a >= fa);
        Debug.Log(a < fa);
        Debug.Log(a <= fa);




        if (a > fa)
        {
            Debug.Log("Tak");
        }
        else
        {
            Debug.Log("Nie");
        }


        if (str != str1)
		{
            Debug.Log("różne");

			} else if (str == str1)
		{
            Debug.Log("nie różne");
		
		}
        
    }
}



public void Koniunkcja(int a, int b, bool c, bool d)
{
    if ((a > b) && (a >= b))
    {
        Debug.Log(c);

    }
    else
    {
        Debug.Log(d);
    }
    if ((a > b) && (a != b))
    {
        Debug.Log(c);
    }
    else
    {
        Debug.Log(d);
    }
    if ((a < b) && (a <= b))
    {
        Debug.Log(c);
    }
    else
    {
        Debug.log(d);
    }
}

public void Alternatywa(int a, float b, bool c, bool d)
{
    if ((a > b) || (a >= b))
    {
        Debug.Log(c);

    }
    else
    {
        Debug.Log(d);
    }
    if ((a > b) || (a != b))
    {
        Debug.Log(c);
    }
    else
    {
        Debug.Log(d);
    }
    if ((a < b) || (a <= b))
    {
        Debug.Log(c);
    }
    else
    {
        Debug.log(d);
    }
}



