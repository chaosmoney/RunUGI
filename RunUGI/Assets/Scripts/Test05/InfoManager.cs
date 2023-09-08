using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System;
using System.IO;

public class InfoManager : MonoBehaviour
{
    public static readonly InfoManager instance = new InfoManager();
    Dictionary<int, MissionInfo> dicMissionInfos = new Dictionary<int, MissionInfo>();
    string savePath = Application.persistentDataPath + "/GameInfo.json";
    public void Save(Dictionary<int, MissionInfo> info)
    {
        if(File.Exists(savePath))
        {
            Debug.Log("���� ����");
        }
        else
        {
            Debug.Log("�ű� ����");
        }

        this.dicMissionInfos = info;
    }

    public void Load()
    {
        string json = JsonConvert.SerializeObject(dicMissionInfos.Values);
        Debug.Log(json);
        File.WriteAllText(this.savePath, json);
        Console.WriteLine("���� ���� �Ϸ�");
    }

    public void GetInfos()
    {
        var path = File.ReadAllText(this.savePath);
        var json = JsonConvert.DeserializeObject<MissionInfo[]>(path);
    }
}
