using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class Test03UIStage : MonoBehaviour
{
    enum eState
    {
        Lock,Doing,Complete
    }

    public int state = 0;

    public UnityAction onClicked;
    private void Start()
    {
    }

    public void ChangeState(int num)
    {
        OffState();
        this.transform.GetChild(num).gameObject.SetActive(true);
        state = num;
    }

    public void OffState()
    {
        for(int i = 0; i < 3; i++)
        {
            this.transform.GetChild(i).gameObject.SetActive(false);
        }
    }


    

}
