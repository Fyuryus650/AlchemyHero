using UnityEngine;
using UnityEngine.UI;

public class ColorMIxer : MonoBehaviour
{
    public ColorData colorDat;
    public Color color;
    private Image colorObj;


    public void UpdateColorData()
    {
        colorObj = gameObject.GetComponent<Image>();
        colorObj.color = new Color(colorDat.slidVal1, colorDat.slidVal3, colorDat.slidVal2);
    }
}

