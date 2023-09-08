using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class AtlasManager : MonoBehaviour
{
    public static readonly AtlasManager instance = new AtlasManager();
    private SpriteAtlas iconAtlas;
    private SpriteAtlas rewardAtlas;

    public void LoadAtlases()
    {
        this.iconAtlas = Resources.Load<SpriteAtlas>("UI_AtlasMission");
        this.rewardAtlas = Resources.Load<SpriteAtlas>("UI_AtlasMissionReward");
    }

    public SpriteAtlas GetIconAtlas()
    {
        return iconAtlas;
    }

    public SpriteAtlas GetRewardAtlas()
    {
        return rewardAtlas;
    }
}
