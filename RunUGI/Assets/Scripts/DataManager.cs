using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
public class DataManager : MonoBehaviour
{
    public static readonly DataManager instance = new DataManager();
    Dictionary<int, ChestData> dicChestDatas = new Dictionary<int, ChestData>();
    Dictionary<int, MissionData> dicMissionDatas = new Dictionary<int, MissionData>();


    public void Init()
    {
        string json = Resources.Load("shopchest_data").ToString();
        ChestData[] chestData = JsonConvert.DeserializeObject<ChestData[]>(json);
        for (int i = 0; i < chestData.Length; i++)
        {
            this.dicChestDatas.Add(chestData[i].id, chestData[i]);
        }
    }

    public Dictionary<int, ChestData> GetDicChestDatas()
    {
        return dicChestDatas;
    }

    public void LoadMissionData()
    {
        string json = Resources.Load("Mission_data").ToString();
        var missions = JsonConvert.DeserializeObject<MissionData[]>(json);
        
        foreach(var mission in missions) {
            this.dicMissionDatas.Add(mission.id, mission);
        }
    }

    public Dictionary<int, MissionData> GetDicMissionDatas()
    {
        return dicMissionDatas;
    }

}
