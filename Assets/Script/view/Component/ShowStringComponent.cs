using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStringComponent : MonoBehaviour
{

    public string s;
    public Text text;
    public static ShowStringComponent instance;
    // Start is called before the first frame update
    public void Awake()
    {
        instance = this;
      
    }
  

    public void ChangeStringInImage(string s)
    {
        Debug.Log(s);
        text.text = s;
    }
}
