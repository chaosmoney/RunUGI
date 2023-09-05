using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Test01UITapController : MonoBehaviour
{
    [SerializeField]
    private Button[] btns;

    void Start()
    {
        Init();
        foreach(var t in btns)
        {
            t.onClick.AddListener(() =>
            {
                Init();
                t.transform.GetChild(0).gameObject.SetActive(true);
                t.transform.GetChild(1).gameObject.SetActive(false);
            });
        }
    }

    private void Init()
    {
        foreach(var button in btns)
        {
            button.transform.GetChild(0).gameObject.SetActive(false);
            button.transform.GetChild(1).gameObject.SetActive(true);
        }
    }

}
