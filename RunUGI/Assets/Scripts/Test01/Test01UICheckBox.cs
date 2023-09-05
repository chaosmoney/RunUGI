using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test01UICheckBox : MonoBehaviour
{
    [SerializeField]
    private Button btn;

    private eState state;
    public enum eState
    {
        On,
        Off
    }

    [SerializeField]
    private GameObject[] arrOnOff;
    // Start is called before the first frame update
    void Start()
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
