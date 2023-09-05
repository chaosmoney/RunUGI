using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Test03UIStageController : MonoBehaviour
{
    enum eState
    {
        Lock,Doing,Complete
    }

    [SerializeField]
    private Button[] stages;

    private int doingStage = 0;

    public UnityAction nextStageOpen;
    // Start is called before the first frame update
    void Start()
    {
        Init();

        for(int i = 0; i < stages.Length; i++)
        {
            Test03UIStage stage = stages[i].GetComponent<Test03UIStage>();
            if(i == 0)
            {
                stage.ChangeState(1);
            }
            this.stages[i].onClick.AddListener(() =>
            {
                if (stage.state == 1)
                {
                    stage.ChangeState(2);
                }

            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Init()
    {
        for (int i = 0; i < stages.Length; i++)
        {
            this.stages[i].transform.GetChild(0).gameObject.SetActive(false);
            this.stages[i].transform.GetChild(1).gameObject.SetActive(false);
            this.stages[i].transform.GetChild(2).gameObject.SetActive(false);

            this.stages[i].transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
