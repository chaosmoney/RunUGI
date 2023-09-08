using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIChestCell : MonoBehaviour
{
    public enum eChestType
    {
        Wooden,Silver,Golden,Epic,Legendary
    }

    [SerializeField]
    protected Button buyButton;
    [SerializeField]
    protected TMPro.TMP_Text buttonText;

    [SerializeField]
    protected Image chestImage;

    private ChestData data;

    public System.Action onClickButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Init(ChestData dicChestDatas, Sprite sprite)
    {
        this.data = dicChestDatas;
        this.chestImage.sprite = sprite;
        this.buttonText.text = dicChestDatas.price.ToString();

        this.buyButton.onClick.AddListener(() =>
        {
            onClickButton();
        });
    }
}
