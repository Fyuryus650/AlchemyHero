using UnityEngine;
using UnityEngine.UI;

public class GoldCounter : MonoBehaviour
{
    public Text goldText;
    public IntData goldData;

    private void Awake()
    {
        goldData.value = 0;
        goldText.text = "Gold: " + goldData.value;
    }

    public void UpdateGold()
    {
        goldText.text = "Gold: " + goldData.value;
    }
}
