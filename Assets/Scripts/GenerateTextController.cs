using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GenerateTextController : MonoBehaviour
{
    public TextMeshPro preText;

    public TextMeshPro minVal;
    public TextMeshPro maxVal;
    public TextMeshPro amountVal;

    private int min;
    private int max;
    private int amount;

    void GetValues()
    {
        min = int.Parse(minVal.text);
        max = int.Parse(maxVal.text);
        amount = int.Parse(amountVal.text);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform.name == "OkButton")
            {
                GetValues();

                preText.text = "";

                string text = "";
                for (int i = 0; i < amount; i++)
                {
                    text += Random.Range(min, max).ToString() + " ";
                }

                preText.text = text;
            }
        }
    }
}
