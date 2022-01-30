using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    public IntData healthData;
    public float health;
    private Slider slider;

    private void Awake()
    {
        health = healthData.value;
        slider = gameObject.GetComponent<Slider>();
    }

    public void Update()
    {
        health = healthData.value;
        slider.value = health / 200;
    }
}
