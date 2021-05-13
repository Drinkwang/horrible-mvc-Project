using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonpress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showColor1()
    {
        AppFactory.instances.Todo(new Observer(Cmd.showColor, ColorModel.instances().red));
    }

}
