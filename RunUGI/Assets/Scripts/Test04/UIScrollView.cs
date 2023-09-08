using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;
using UnityEngine.U2D;

public class UIScrollView : MonoBehaviour
{
    [SerializeField]
    private GameObject uiChestCellAd;
    [SerializeField]
    private GameObject uiChestCell;
    [SerializeField]
    private Transform content;
    [SerializeField]
    private SpriteAtlas atlas;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.instance.Init();
        var chestDatas = DataManager.instance.GetDicChestDatas();
        for(int i = 0; i<chestDatas.Count; i++)
        {
            var data = chestDatas[100+i];
            Sprite sprite = this.atlas.GetSprite(data.sprite_name);
            if (data.type == 0) {
                GameObject go = Instantiate(uiChestCellAd,content);
                var cell = go.GetComponent<UIChestCellAd>();
                cell.Init(data, sprite);
                cell.onClickAd = () =>
                {
                    Debug.Log("±¤°í ½ÃÃ»");
                };
                cell.onClickButton = () =>
                {
                    Debug.LogFormat("{0}, {1}", data.name, data.price);
                };
            }
            else
            {
                GameObject go = Instantiate(uiChestCell, content);
                var cell = go.GetComponent<UIChestCell>();
                cell.Init(data, sprite);
                cell.onClickButton = () =>
                {
                    Debug.LogFormat("{0}, {1}", data.name, data.price);
                };

            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
