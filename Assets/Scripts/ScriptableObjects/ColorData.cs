using UnityEngine;

[CreateAssetMenu]
public class ColorData : ScriptableObject
{
    public Color finalColor;
    public float slidVal1, slidVal2, slidVal3;

    private void Awake()
    {
        finalColor = new Color(0,0,0);
        slidVal1 = 0;
        slidVal2 = 0;
        slidVal3 = 0;
    }
    public void ColorAdd()
    {
        finalColor = Color.black;
        finalColor = new Color(slidVal1, slidVal3, slidVal2);
    }

    public void ResetColor()
    {
        finalColor = Color.white;
    }    
    
}
