using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlEstados : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    private float value;

    void Start()
    {
        value = 100f;
        textComponent.text = value.ToString();
    }

    void FixedUpdate()
    {
        value = value - 0.03f;
        textComponent.text = (Mathf.Ceil(value)).ToString();

    }
}
