using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test01UIToggle : MonoBehaviour
{
    public enum eState
    {
        On,
        Off
    }

    private eState state;
    [SerializeField]
    private Button btn;

    [SerializeField]
    private GameObject[] arrOnOff;

    private void Start()
    {
        var go = this.arrOnOff[(int)this.state];
        go.SetActive(true);
        this.btn.onClick.AddListener(() =>
        {
            Debug.LogFormat("토글 버튼 클릭: {0}", this.state);
            var go = this.arrOnOff[(int)this.state];
            go.SetActive(false);
            //현재 상태를 반전
            if (this.state == eState.On)
            {
                this.state = eState.Off;

            }
            else if (this.state == eState.Off)
            {
                this.state = eState.On;
            }
            go = this.arrOnOff[(int)this.state];
            go.SetActive(true);
        });
    }


}
