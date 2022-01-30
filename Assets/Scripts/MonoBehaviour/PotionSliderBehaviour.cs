using UnityEngine;
using UnityEngine.UI;

public class PotionSliderBehaviour : MonoBehaviour
{
    private Slider slider;
    public Color colorOut = Color.gray;
    public ColorData colorData;
    public FloatData fireDmg, coldDmg, poisonDmg;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.value = 0;
    }

    public void ChangeColorRed()
    {
        colorData.slidVal1 = slider.value;
        fireDmg.value = (slider.value * 100) / 10;
    }
    public void ChangeColorBlue()
    {
        colorData.slidVal2 = slider.value;
        coldDmg.value = (slider.value * 100) / 10;
    }
    public void ChangeColorGreen()
    {
        colorData.slidVal3 = slider.value;
        poisonDmg.value = (slider.value * 100) / 10;
    }
}
