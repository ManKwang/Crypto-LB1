using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MinValPlus : MonoBehaviour
{
    public TextMeshPro minText;
    public TextMeshPro maxText;

    public int minValue = 0;
    public int maxValue = 99;

    private int currentValue;
    // Start is called before the first frame update
    void Start()
    {
        currentValue = int.Parse(minText.text);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform.parent.parent != null && hit.transform.parent.parent.name == "ControlsMin")
            {
                if (hit.transform.parent.name == "Plus")
                {
                    currentValue++;
                } 
                else
                {
                    currentValue--;
                }

                if (currentValue < minValue)
                    currentValue = minValue;
                else if (currentValue > maxValue)
                    currentValue = maxValue;

                if (currentValue >= int.Parse(maxText.text))
                    currentValue--;

                minText.SetText(Convert.ToString(currentValue));
            }
            
        }
    }
}
