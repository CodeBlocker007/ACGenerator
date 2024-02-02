using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CoilMovement : MonoBehaviour
{
    [SerializeField] Slider speedSlider = null;
    [SerializeField] Slider coilSlider = null;
    [SerializeField] GameObject coilPrefab;
    public GameObject[] coilsArray;

    private float speedZ;

    public void Update()
    {
        float numberOfCoil = coilSlider.value;
        float maxNumberOfCoil = coilSlider.maxValue;
        
        // Rotation
        coilPrefab.transform.Rotate(Vector3.right , (360 * speedSlider.value * Time.deltaTime)/10);

        if(coilsArray.Length != numberOfCoil){
            if(coilsArray.Length - numberOfCoil < 0)
            {
                for(int x = 0; x < numberOfCoil - coilsArray.Length; x++)
                {
                    Vector3 newposition = new Vector3((float)-4.30954, 0 , 0);
                    coilsArray[coilsArray.Length + x] = Instantiate(coilPrefab, newposition, Quaternion.Euler(0, 0, transform.rotation.z*(360/maxNumberOfCoil)));
            }
        }
    }
    }

    void Start()
    {
        coilsArray[0] = gameObject;
    }


}
