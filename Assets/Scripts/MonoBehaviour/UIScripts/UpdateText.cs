using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    public IntData numData;
    public Text textObj;
    public string textSubject;

    private void Awake()
    {
        textObj.text = textSubject + numData.value;
    }
    public void TextUpdate()
    {
        textObj.text = textSubject + numData.value;
    }
}
