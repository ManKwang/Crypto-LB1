using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AverageController : MonoBehaviour
{
    public TextMeshPro currentText;

    public int minValue = 1;
    public int maxValue = 50;

    private int currentValue;
    // Start is called before the first frame update
    void Start()
    {
        currentValue = int.Parse(currentText.text);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform.parent.parent != null && hit.transform.parent.parent.name == "ControlsAmount")
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

                currentText.SetText(Convert.ToString(currentValue));
            }

        }
    }
}
