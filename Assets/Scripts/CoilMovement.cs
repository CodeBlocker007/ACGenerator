using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CoilMovement : MonoBehaviour
{
    [SerializeField] Slider speedSlider = null;
    private float speedZ;

    public void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, (360 * speedSlider.value * Time.deltaTime)/10);
    }
}
