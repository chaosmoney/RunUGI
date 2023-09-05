using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Test01InputField : MonoBehaviour
{
    private TMP_InputField input; 
    // Start is called before the first frame update
    void Start()
    {
        this.input = this.GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
