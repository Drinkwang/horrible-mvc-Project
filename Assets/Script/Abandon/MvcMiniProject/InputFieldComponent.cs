using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldComponent : MonoBehaviour
{
    public Button button;
    public Image image;
    public GameObject s_Image;
    public GameObject s_Text;
    public GameObject inputText;
    public Text text;
    public static InputFieldComponent instance;
    void Awake()
    {
        instance = this;
        //text = this.transform.Find("InputText").GetComponent<Text>();
        
    }

    public void ShowImageAndText(string s )
    {
        
        s_Image.SetActive(true);
        s_Text.SetActive(true);
        //text.text = inputText.GetComponentInChildren<Text>().text;
        text.text = s;
    }

    public void changseColor(Color body)
    {
        text.color = body;
    }

 

   

}
