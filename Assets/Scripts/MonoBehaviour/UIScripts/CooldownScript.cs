using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CooldownScript : MonoBehaviour
{
    public float cooldownTime;
    public Slider sliderUI;
    public Button buttonUI;
    public ColorData colorData;
    public Image fillColor;

    public IEnumerator Cooldown(float seconds)
    {
        float animationTime = 0f;
        while (animationTime < seconds)
        {
            animationTime += Time.deltaTime;
            float lerpValue = animationTime / seconds;
            sliderUI.value = Mathf.Lerp(0, 1, lerpValue);
            yield return null;
            if(sliderUI.value >= 1)
            {
                buttonUI.interactable = true;
            }
        }
    }
    public void StartCooldown()
    {
        StartCoroutine(Cooldown(cooldownTime));
        fillColor.color = colorData.finalColor;
    }

    public void StopCooldown()
    {
        StopAllCoroutines();
    }

    public void ResetSlider()
    {
        sliderUI.value = 0f;
        buttonUI.interactable = false;
    }
}
