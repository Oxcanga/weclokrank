using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class ButtonHandler : MonoBehaviour
{
    [SerializeField] string ButtonText;
    [SerializeField] TextMeshProUGUI[] tmps;
    // Start is called before the first frame update
    void OnEnable()
    {
        tmps = GetComponentsInChildren<TextMeshProUGUI>();
        foreach (var t in tmps) t.text = ButtonText;
    }

}
