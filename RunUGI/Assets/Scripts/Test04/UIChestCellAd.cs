using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class UIChestCellAd : UIChestCell
{
    [SerializeField]
    private Button adButton;

    public System.Action onClickAd;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Init(ChestData dicChestDatas, Sprite sprite)
    {
        base.Init(dicChestDatas, sprite);

        adButton.onClick.AddListener(() =>
        {
            onClickAd();
        });
    }
}
