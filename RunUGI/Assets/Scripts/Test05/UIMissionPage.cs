using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class UIMissionPage : MonoBehaviour
{
    [SerializeField]
    private UIMissionScrollView scrollView;
    [SerializeField]
    private Button button;

    // Start is called before the first frame update
    private void Awake()
    {
        scrollView.Init();
        button.onClick.AddListener(() =>
        {
            InfoManager.instance.GetInfos();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
