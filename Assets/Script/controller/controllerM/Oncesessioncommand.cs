using System;
using System.Collections.Generic;
using UnityEngine;
public class Oncesessioncommand : IC
{
    public Sayingproxy saymore = Sayingproxy.instances();
    public Oncesessioncommand()
    {
    }
    public void Todo(Observer o)
    {//Debug.Log();
        if (o.body == null)
        {
            Debug.Log("thi is nothing todo");
        }
        else if (o.body != null && o.body.GetType().ToString() != "System.String")
        {
            List<string> news = (List<string>)o.body;
            string a = news[0];

            //			Debug.Log ("aaaa");
            news.Remove(a);
            if (news.Capacity != 0)
            {

                List<string> anyonesay = new List<string>();
                foreach (string msg in news)
                    anyonesay.Add(msg);
                saymore.Add(a, anyonesay);
            }
            AppFactory.instances.viewTodo(new Observer("dialogadd", saymore.returnLs()));
            AppFactory.instances.viewTodo(new Observer("dialog", a));

        }
        else if (o.body.GetType().ToString() == "System.String")
        {
            AppFactory.instances.viewTodo(new Observer("dialog", o.body.ToString()));
            //AppFactory.instances.playercontrol(false);

        }
    }
}


