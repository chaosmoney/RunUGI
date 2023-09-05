using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test02InputField : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField input;
    [SerializeField]
    private Button buttonInactive;
    [SerializeField]
    private Button buttonActive;
    // Start is called before the first frame update
    void Start()
    {
        buttonActive.onClick.AddListener(() =>
        {
            Destroy(this.gameObject);
            Debug.Log(this.input.text);
        });

    }

    // Update is called once per frame
    void Update()
    {
        if(input.text == "")
        {
            buttonInactive.gameObject.SetActive(true);
            buttonActive.gameObject.SetActive(false);
        }
        else
        {
            buttonInactive.gameObject.SetActive(false);
            buttonActive.gameObject.SetActive(true);
        }
    }
}
