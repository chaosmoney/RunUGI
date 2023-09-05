using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01Main : MonoBehaviour
{
    [SerializeField]
    private Test01UIMain uiMain;
    // Start is called before the first frame update
    void Start()
    {
        this.uiMain.onButtonClicked = (btnType) =>
        {
            Debug.Log(btnType);
        };
        uiMain.Init();
    }
}
