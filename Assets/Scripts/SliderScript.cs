using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI sliderText = null;
    public int SliderChange(int value)
    {
        int localvalue = value;
        sliderText.text = localvalue.ToString("0");
        return localvalue;
    }
    
}
