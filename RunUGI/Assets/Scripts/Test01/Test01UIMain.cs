using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test01UIMain : MonoBehaviour
{
    public enum eButtonType
    {
        Blue, Red,Green,Purple,Yellow,Brown,BlueGray,Mint,Gray,Dark
    }

    [SerializeField]
    private List<Button> btns = new List<Button>();

    public System.Action<eButtonType> onButtonClicked;
    public void Init()
    {
        for(int i = 0; i<btns.Count; i++)
        {
            int j = i; // 캡쳐
            btns[i].onClick.AddListener(() =>
            {
                Debug.LogFormat("{0}버튼 클릭", (eButtonType)j);
                //클로저 : 람다 안에서 상위 스코프 변수에 접근
            });
        }
    }
}
