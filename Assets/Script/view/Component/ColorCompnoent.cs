using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorCompnoent : MonoBehaviour
{
    public Button button;
    public Image image;
    public static ColorCompnoent instance;
    // Start is called before the first frame update
    public void Awake()
    {
        instance = this;
        

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShowColor(Color color)
    {
        image.color = color;
    }
}
