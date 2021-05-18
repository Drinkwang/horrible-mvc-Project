using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tipCompnoent : MonoBehaviour
{
    public Text a;
    public static tipCompnoent instance;
    // Start is called before the first frame update
    public void Awake()
    {
        instance = this;

        
    }
    void Start()
    {
        
    }


    public void show(string xxx) {

        a=this.GetComponentInChildren<Text>();
        a.text = xxx;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
