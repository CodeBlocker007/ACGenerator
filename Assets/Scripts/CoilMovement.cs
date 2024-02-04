using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CoilMovement : MonoBehaviour
{
    [SerializeField] Slider speedSlider = null;
    [SerializeField] Slider coilSlider = null;
    [SerializeField] GameObject coilPrefab;
    [SerializeField] List<float> nocoilsArray = new List<float>();
    [SerializeField] List<GameObject> CoilArray = new List<GameObject>();

    public GameObject[] coilsArray;
    
    public void Start()
    {
        nocoilsArray.Add(0);
        nocoilsArray.Add(1);
    }

    public void Update()
    {
        coilPrefab.transform.Rotate(Vector3.right , 360 * speedSlider.value * Time.deltaTime/10);
        CoilCountManager(coilSlider.value);
    }
    public void CoilCountManager(float value)
    {
        float numberOfCoil = value;

        coilPrefab.AddComponent<CoilMovement>();

        nocoilsArray.Add(numberOfCoil);
        Debug.Log(nocoilsArray.Count);

        if((nocoilsArray[nocoilsArray.Count - 1]-nocoilsArray[nocoilsArray.Count-2]) >= 0)
        {
            for (float i = nocoilsArray[nocoilsArray.Count - 1]-nocoilsArray[nocoilsArray.Count-2]; i > 0; i--)
            {
                Vector3 newPosition = coilPrefab.transform.position;
                Quaternion newRotation = coilPrefab.transform.rotation * Quaternion.Euler(0.1f, 0f, 0f);

                CoilArray.Append(Instantiate(coilPrefab, newPosition, newRotation));
            }
        }
        else
        {
            for (float i = nocoilsArray[nocoilsArray.Count - 1]-nocoilsArray[nocoilsArray.Count-2]; i < 0; i++)
            {
                Destroy(CoilArray[(int)(i)]);
            }
        }

    }
}
