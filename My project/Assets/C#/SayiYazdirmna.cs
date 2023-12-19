using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SayiYazdirmna : MonoBehaviour
{
    public int sayi1;
    public int sayi2;
    string x;
    void Start()
    {
        sayihesaplama(sayi1, sayi2);
    }

    void sayihesaplama(int a, int b)
    {

        for (int i = a; i <= b; i++)
        {x += i.ToString(); if (i < b) { x += " - "; }}
        x = x.TrimEnd(' ', '-');
        print(x);

        x = "";
        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 0)
            {
                x += i.ToString();
                if (i < b && i % 2 == 0) { x += " - "; }
            }
        }
        x = x.TrimEnd(' ', '-');
        print(x);

        x = "";
        for (int i = a; i <= b; i++)
        {
            if (i % 3 == 0)
            {
                x += i.ToString();
                if (i < b && i % 3 == 0) { x += " - "; }
            }
        }
        x = x.TrimEnd(' ', '-');
        print(x);

        x = "";
        for (int i = a; i <= b; i++)
        {
            if (i % 4 == 0)
            {
                x += i.ToString();
                if (i < b && i % 4 == 0)
                { x += " - "; }
            }
        }
        x = x.TrimEnd(' ', '-');
        print(x);

        x = "";
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                x += i.ToString();
                if (i < b && i % 5 == 0) { x += " - "; }
            }
        }
        x = x.TrimEnd(' ', '-');
        print(x);
    }
}
