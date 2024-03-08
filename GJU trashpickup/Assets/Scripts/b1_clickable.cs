 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class b1_clickable : MonoBehaviour
{
    [SerializeField] Text txtc;
    int counter = 0;
    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log(counter);
    }

    void IncreaseCounter()
    {
        counter++; 
    }
}
