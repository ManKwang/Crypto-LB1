using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResetController : MonoBehaviour
{
    public TextMeshPro preText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform.name == "ResetButton")
            {
                preText.text = "";
            }
        }
    }
}
