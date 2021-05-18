using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;
public class Main : MonoBehaviour
{
    
    void Start()
    {
        //AppFactory.instances.Todo(new Observer( Cmd.DeleteMinScore));
        //for(int i=0;i< StudentProxy.instances().getmodellist().Count; i++) {
        //    Debug.Log(StudentProxy.instances().getmodellist()[i].name);
        //}
         if(!File.Exists(Application.streamingAssetsPath + "\\Json\\" + "json.json"))
        {
            List<string> majorColorList = new List<string>();

            MajorColor majorColor0 = new MajorColor();
            majorColor0.colorName = "red";
            majorColor0.major = Major.Chemical;
            majorColorList.Add(JsonMapper.ToJson(majorColor0));
            MajorColor majorColor1 = new MajorColor();
            majorColor1.colorName = "blue";
            majorColor1.major = Major.Math;
            majorColorList.Add(JsonMapper.ToJson(majorColor1));
            MajorColor majorColor2 = new MajorColor();
            majorColor2.colorName = "yellow";
            majorColor2.major = Major.Chinese;
            majorColorList.Add(JsonMapper.ToJson(majorColor2));
            MajorColor majorColor3 = new MajorColor();
            majorColor3.colorName = "green";
            majorColor3.major = Major.Geographic;
            majorColorList.Add(JsonMapper.ToJson(majorColor3));
            MajorColor majorColor4 = new MajorColor();
            majorColor4.colorName = "black";
            majorColor4.major = Major.Physical;
            majorColorList.Add(JsonMapper.ToJson(majorColor4));
            File.WriteAllLines(Application.streamingAssetsPath + "\\Json\\" + "json.json", majorColorList);
        }
        
        
    }
    

}
public class MajorColor
{
    public string colorName;
    public Major major;

}





