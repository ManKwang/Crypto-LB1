using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CancelController : MonoBehaviour
{
    public TextMeshPro preText;

    public TextMeshPro minVal;
    public TextMeshPro maxVal;
    public TextMeshPro amountVal;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform.name == "CancelButton")
            {
                preText.text = "";
                minVal.text = "0";
                maxVal.text = "100";
                amountVal.text = "25";
            }
        }
    }
}
