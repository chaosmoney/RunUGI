using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test03UIPageController : MonoBehaviour
{
    [SerializeField]
    private Button prevArrow;
    [SerializeField]
    private Button nextArrow;
    [SerializeField]
    private GameObject[] pages;
    [SerializeField]
    private TMPro.TMP_Text pageNavi;
    [SerializeField]
    private Test03UIStageController stage;
    

    private float totalPage;
    private int nowPage = 1;
    // Start is called before the first frame update
    void Start()
    {
        this.totalPage = Mathf.CeilToInt(stage.StatusStage() / 18f);

        pageNavi.text = string.Format("{0} / {1}",nowPage,totalPage);

        for (int i = 0; i < totalPage; i++)
        {
            if (pages[i] == pages[0])
            {
                pages[0].SetActive(true);
            }
            else
            {
                pages[i].SetActive(false);
            }
        }

        if(nowPage == 1)
        {
            this.prevArrow.gameObject.SetActive(false);
        }
        prevArrow.onClick.AddListener(() =>
        {
            PrevPage();
            this.nextArrow.gameObject.SetActive(true);
            if (nowPage == 2) {
                this.prevArrow.gameObject.SetActive(false);
            }
            this.nowPage -= 1;
            Debug.LogFormat("현재 페이지 : {0}", nowPage);
            pageNavi.text = string.Format("{0} / {1}", nowPage, totalPage);
        });
        nextArrow.onClick.AddListener(() =>
        {
            NextPage();
            this.prevArrow.gameObject.SetActive(true);
            if (nowPage == pages.Length - 1)
            {
                this.nextArrow.gameObject.SetActive(false);
            }
            this.nowPage += 1;
            Debug.LogFormat("현재 페이지 : {0}", nowPage);
            pageNavi.text = string.Format("{0} / {1}", nowPage, totalPage);
        });

        Debug.LogFormat("현재 페이지 : {0}", nowPage);
        Debug.LogFormat("총 페이지 : {0}", totalPage);
        Debug.LogFormat("총 스테이지 : {0}", stage.StatusStage());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NextPage()
    {
        this.pages[nowPage-1].SetActive(false);
        this.pages[nowPage].SetActive(true);
    }

    private void PrevPage()
    {
        this.pages[nowPage-1].SetActive(false);
        this.pages[nowPage - 2].SetActive(true);
    }


}
