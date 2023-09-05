using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Test01VolumeController : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private TMP_Text txtMin;
    [SerializeField]
    private TMP_Text txtMax;

    private void Start()
    {
        this.txtMin.text = this.slider.value.ToString();
        this.txtMax.text = this.slider.maxValue.ToString();

        this.slider.onValueChanged.AddListener((val) => {
            Debug.Log(val);
        });
    }
}
