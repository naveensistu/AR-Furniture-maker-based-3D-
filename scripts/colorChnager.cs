using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChnager : MonoBehaviour
{
    public Color[] colour;
    public Renderer[] render;
    public void red()
    {
        for(int i=0;i<render.Length;i++)
        {
            render[i].material.color = colour[0];

        }
    }
    public void blue()
    {
        for (int i = 0; i < render.Length; i++)
        {
            render[i].material.color = colour[1];

        }
    }
    public void brown()
    {
        for (int i = 0; i < render.Length; i++)
        {
            render[i].material.color = colour[2];

        }
    }
    public void violet()
    {
        for (int i = 0; i < render.Length; i++)
        {
            render[i].material.color = colour[4];

        }
    }
}
