using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using LitJson;
public class StudentComponent : MonoBehaviour
{
    public List<Transform> studentImageList;
    private List<string> list;
    public Button ShowInformtionBtn;
    public List<Color> colorList;
    public List<StudentModel> studentList;
    public static StudentComponent instance;
    public void Awake()
    {
        instance = this;
        
    }
    public void ShowStudentInformtion()
    {
        for(int i = 0; i < studentImageList.Count; i++)
        {
            string s = studentList[i].name;
            studentImageList[i].Find("Text").GetComponent<Text>().text=s;
        }
        
    }
    public void ShowMajorColor()
    {
        string filePath= Application.streamingAssetsPath + "\\Json" + "\\json.json";
        StreamReader sr = new StreamReader(filePath);
        string jsonStr0 = sr.ReadLine();
        string jsonStr1 = sr.ReadLine();
        string jsonStr2 =sr.ReadLine();
        string jsonStr3 =sr.ReadLine();
        string jsonStr4 =sr.ReadLine();
        sr.Close();
        List<MajorColor> list = new List<MajorColor>();
        list.Add(JsonMapper.ToObject<MajorColor>(jsonStr0));
        list.Add(JsonMapper.ToObject<MajorColor>(jsonStr1));
        list.Add(JsonMapper.ToObject<MajorColor>(jsonStr2));
        list.Add(JsonMapper.ToObject<MajorColor>(jsonStr3));
        list.Add(JsonMapper.ToObject<MajorColor>(jsonStr4));
        for (int i = 0; i < studentImageList.Count; i++)
        {
            Major major = StudentProxy.instances().getmodellist()[i].major;
            for(int j = 0; j < list.Count; j++)
            {
                if (major == list[j].major)
                {
                    studentImageList[i].GetComponent<Image>().color =StringToColor( list[j].colorName);
                }
            }
            
        }
        //UnityEngine.TextAsset s = Resources.Load(FileName) as TextAsset
        //StreamReader streamreader = new StreamReader(FileName);
        //JsonReader js = new JsonReader(streamreader);
        //list = JsonMapper.ToObject<List<string>>(js);
        //Debug.Log(JsonMapper.ToObject<List<string>>(js).Count);
        //for (int i = 0; i < studentImageList.Count; i++)
        //{
        //    Major major = StudentProxy.instances().getmodellist()[i].major;
        //    switch (major)
        //    {
        //        case Major.Chemical: studentImageList[i].GetComponent<Image>().color = colorList[0];break;
        //        case Major.Math: studentImageList[i].GetComponent<Image>().color = colorList[1]; break;
        //        case Major.Chinese: studentImageList[i].GetComponent<Image>().color = colorList[2]; break;
        //        case Major.Geographic: studentImageList[i].GetComponent<Image>().color = colorList[3]; break;
        //        case Major.Physical: studentImageList[i].GetComponent<Image>().color = colorList[4]; break;
        //        default: studentImageList[i].GetComponent<Image>().color = Color.white; break;
        //    }
           
        //}
    }
    private Color StringToColor(string s)
    {
        if (s.Equals("red"))
        {
            return Color.red;
        }
        if (s.Equals("blue"))
        {
            return Color.blue;
        }
        if (s.Equals("yellow"))
        {
            return Color.yellow;
        }
        if (s.Equals("green"))
        {
            return Color.green;
        }
        if (s.Equals("black"))
        {
            return Color.black;
        }
        return Color.gray;
    }
    public void DeleteStudentImage()
    {

    }
}
