using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMissionCell : MonoBehaviour
{

    [SerializeField]
    private GameObject[] arrState;
    [SerializeField]
    private Image[] icon;
    [SerializeField]
    private TMPro.TMP_Text[] name;
    [SerializeField]
    private TMPro.TMP_Text[] desc;
    [SerializeField]
    private Image[] reward_icon;
    [SerializeField]
    private TMPro.TMP_Text[] reward_amount;
    [SerializeField]
    private Button claimButton;
    [SerializeField]
    private Slider slider;



    private MissionData missionData;
    private int state;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(MissionData mission)
    {


        AtlasManager.instance.LoadAtlases();
        var iconAtlas = AtlasManager.instance.GetIconAtlas();
        var rewardAtlas = AtlasManager.instance.GetRewardAtlas();
        var icon = iconAtlas.GetSprite(mission.icon_name);
        var reward = rewardAtlas.GetSprite(mission.reward_icon_name);

        this.missionData = mission;
        for (int i = 0; i < arrState.Length; i++)
        {
            if(i == 0)
            {
                this.arrState[i].SetActive(true);
            }
            else
            {
                this.arrState[i].SetActive(false);
            }

            this.icon[i].sprite = icon;
            this.reward_icon[i].sprite = reward;
            this.name[i].text = this.missionData.name;
            this.desc[i].text = this.missionData.desc;
            this.reward_amount[i].text = this.missionData.reward_amount.ToString();
        };
        this.state = 0;
        this.count = missionData.goal;
    }

    public MissionInfo GetInfo()
    {
        var missionInfo = new MissionInfo();
        missionInfo.id = this.missionData.id;
        missionInfo.count = this.count;
        missionInfo.state = this.state;
        return missionInfo;
    }

    
}
