using UnityEngine;
using System.Collections.Generic;
using LitJson;
using UniFrame.Common;

public class ArchiveManager : Singleton<ArchiveManager>
{
    string resFolder = "json/";
    Dictionary<string,JsonData> cached;

    private ArchiveManager()
    {
        cached = new Dictionary<string, JsonData>(); 
    }
    
    public JsonData Retrieve<T>() where T : class
    {
        string key = typeof(T).ToString();
        if (cached.TryGetValue(key, out JsonData v))
            return v;
        string jsonStr = Read(key);
        JsonData jsonData = JsonMapper.ToObject(jsonStr);
        cached.Add(key, jsonData);
        return cached[key];
    }

    public List<T> GetSamplelist<T>()where T:class {
        var t = ArchiveManager.Instance.Retrieve<T>();
        var content = t.ToJson();
        List<T> list = JsonMapper.ToObject<List<T>>(content);
        return list;
    }

    public T GetSampleInIndex<T>(int i) where T : class
    {
        var t = ArchiveManager.Instance.Retrieve<T>();
        var content = t.ToJson();
        List<T> list = JsonMapper.ToObject<List<T>>(content);
        return list[i];
    }


    #region Private Methods
    private string Read(string filename)
    {
        string path = resFolder + filename;
        return Resources.Load<TextAsset>(path).text;
    }
    #endregion
}
