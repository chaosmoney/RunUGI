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
            Debug.LogFormat("��� ��ư Ŭ��: {0}", this.state);
            var go = this.arrOnOff[(int)this.state];
            go.SetActive(false);
            //���� ���¸� ����
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
