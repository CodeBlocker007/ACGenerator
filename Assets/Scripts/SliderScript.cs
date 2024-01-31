using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider fluxSlider;
    public Slider speedSlider;
    public Slider numberOfCoil;
    public TextMeshProUGUI fluxText = null;
    public TextMeshProUGUI speedText = null;
    public TextMeshProUGUI emfText = null;
    public TextMeshProUGUI coilText = null;
    public float fluxlocalvalue;
    public float speedlocalvalue;
    public float area = 10f;

    private void Start()
    {
        fluxSlider.onValueChanged.AddListener(FluxChange);
        speedSlider.onValueChanged.AddListener(SpeedChange);
        numberOfCoil.onValueChanged.AddListener(NoOfCoils);
        fluxText.text = fluxSlider.value.ToString();
        speedText.text = speedSlider.value.ToString();
        coilText.text = numberOfCoil.value.ToString();
        EMFChange();
    }
    public void FluxChange(float value)
    {
        fluxText.text = value.ToString();
        EMFChange();
    }
    public void SpeedChange(float value)
    {
        speedText.text = value.ToString();
        EMFChange();
    }
    
    public void EMFChange()
    {
        emfText.text = (fluxSlider.value * speedSlider.value * area * numberOfCoil.value).ToString();
    }

    public void NoOfCoils(float value)
    {
        coilText.text = value.ToString();
        EMFChange();
    }
}
