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
    private GameObject[] stages;
    [SerializeField]
    private Button[] doings;
    [SerializeField]
    private GameObject[] clearStars;
    [SerializeField]
    private TMPro.TMP_Text[] doingTexts;
    [SerializeField]
    private TMPro.TMP_Text[] completeTexts;
    [SerializeField]
    private TMPro.TMP_Text statusStars;

    private int getStars;
    private int totalStars;

    private int Lock = (int)eState.Lock;
    private int Doing = (int)eState.Doing;
    private int Complete = (int)eState.Complete;

    private int[] stagesState;

    private void Start()
    {
        Init();
        for (int i = 0; i < doings.Length; i++)
        {
            int j = i;
            this.doings[i].onClick.AddListener(() =>
            {
                if (stages[j] == stages[stages.Length - 1])
                {
                    this.stages[j].transform.GetChild(1).gameObject.SetActive(false);
                    this.stages[j].transform.GetChild(2).gameObject.SetActive(true);
                }
                else
                {
                    this.stages[j].transform.GetChild(1).gameObject.SetActive(false);
                    this.stages[j].transform.GetChild(2).gameObject.SetActive(true);

                    this.stages[j + 1].transform.GetChild(0).gameObject.SetActive(false);
                    this.stages[j + 1].transform.GetChild(1).gameObject.SetActive(true);
                }

                InitStars(j);
                StatusStar();

            });
        }
    }
    private void Update()
    {

    }

    private void Init()
    {
        this.stagesState = new int[this.stages.Length];
        for (int i = 0; i < stages.Length; i++)
        {
            ChangeState(i,Lock);
            doingTexts[i].text = (i+1).ToString();
            completeTexts[i].text = (i+1).ToString();
        }
        ChangeState(0, Doing);

        this.totalStars = stages.Length * 3;

        for (int i = 0; i < stagesState.Length; i++)
        {
            Debug.Log(stagesState[i]);
        }
    }

    private void InitStars(int j)
    {
        int random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                clearStars[j].transform.GetChild(0).gameObject.SetActive(false);
                clearStars[j].transform.GetChild(1).gameObject.SetActive(false);
                clearStars[j].transform.GetChild(2).gameObject.SetActive(false);
                break;
            case 1:
                clearStars[j].transform.GetChild(0).gameObject.SetActive(true);
                clearStars[j].transform.GetChild(1).gameObject.SetActive(false);
                clearStars[j].transform.GetChild(2).gameObject.SetActive(false);
                getStars += 1;
                break;
            case 2:
                clearStars[j].transform.GetChild(0).gameObject.SetActive(true);
                clearStars[j].transform.GetChild(1).gameObject.SetActive(true);
                clearStars[j].transform.GetChild(2).gameObject.SetActive(false);
                getStars += 2;
                break;
            case 3:
                clearStars[j].transform.GetChild(0).gameObject.SetActive(true);
                clearStars[j].transform.GetChild(1).gameObject.SetActive(true);
                clearStars[j].transform.GetChild(2).gameObject.SetActive(true);
                getStars += 3;
                break;
        }
    }

    private void ChangeState(int i,int state)
    {
        this.stages[i].transform.GetChild(Lock).gameObject.SetActive(false);
        this.stages[i].transform.GetChild(Doing).gameObject.SetActive(false);
        this.stages[i].transform.GetChild(Complete).gameObject.SetActive(false);
        this.stages[i].transform.GetChild(state).gameObject.SetActive(true);
        this.stagesState[i] = state;
    }

    private void StatusStar()
    {
        statusStars.text = getStars.ToString() +" / "+ totalStars.ToString();
    }

    public int StatusStage()
    {
        return stages.Length; 
    }
}
