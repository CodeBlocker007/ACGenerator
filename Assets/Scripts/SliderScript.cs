using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UI;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Numerics;

public class SliderScript : MonoBehaviour
{
    public Slider fluxSlider;
    public Slider speedSlider;
    public Slider numberOfCoil;
    public TextMeshProUGUI fluxText = null;
    public TextMeshProUGUI speedText = null;
    public TextMeshProUGUI emfText = null;
    public TextMeshProUGUI coilText = null;
    public GameObject coil;
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
        UnityEngine.Quaternion x_quaternion = coil.transform.rotation;
        UnityEngine.Vector3 x_vector = x_quaternion.eulerAngles;
        float x = x_vector.x;
        emfText.text = (fluxSlider.value * speedSlider.value * area * numberOfCoil.value * Math.Sin(x)).ToString();
    }

    public void NoOfCoils(float value)
    {
        coilText.text = value.ToString();
        EMFChange();
    }
}
