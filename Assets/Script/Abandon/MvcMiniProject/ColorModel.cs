using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class ColorModel
{
    public Color red = Color.red;


    private static ColorModel instance;
    public static ColorModel instances()
    {
        if (instance == null)
        {
            instance = new ColorModel();

        }
        return instance;

    }
}

