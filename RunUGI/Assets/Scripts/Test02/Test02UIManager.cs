using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test02UIManager : MonoBehaviour
{
    [SerializeField]
    private Test02InputField inputField;
    [SerializeField]
    private Button home;
    // Start is called before the first frame update
    void Start()
    {
        this.home.onClick.AddListener(() =>
        {
            Instantiate(inputField);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
