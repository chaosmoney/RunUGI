using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMissionScrollView : MonoBehaviour
{
    [SerializeField]
    private GameObject uiMissionCell;
    [SerializeField]
    private Button saveButton;
    [SerializeField]
    private Transform content;

    private List<UIMissionCell> cells = new List<UIMissionCell>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init()
    {
        DataManager.instance.LoadMissionData();
        var missionData = DataManager.instance.GetDicMissionDatas();
        foreach (var mission in missionData)
        {
            
            GameObject go = Instantiate(uiMissionCell, content);
            var cell = go.GetComponent<UIMissionCell>();
            cell.Init(mission.Value);
            cells.Add(cell);
        }
        saveButton.onClick.AddListener(() =>
        {
            Dictionary<int, MissionInfo> dicMissionInfos = new Dictionary<int, MissionInfo>();
            for (int i = 0; i < cells.Count; i++)
            {
                dicMissionInfos.Add(cells[i].GetInfo().id, cells[i].GetInfo());
            }
            InfoManager.instance.Save(dicMissionInfos);
            InfoManager.instance.Load();
        });

    }

}
