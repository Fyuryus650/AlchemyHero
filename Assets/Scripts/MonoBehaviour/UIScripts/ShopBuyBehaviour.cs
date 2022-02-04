using UnityEngine;
using UnityEngine.UI;

public class ShopBuyBehaviour : MonoBehaviour
{
    public IntData goldData, costData;
    public FloatData damageData;
    public int cost, priceIncrease, i = 1;
    public Button shopButton;

    private void Awake()
    {
        if(goldData.value < cost)
        {
            shopButton.enabled = false;
        }
    }
    public void Purchase()
    {
        cost = costData.value;
        i++;
        goldData.value = goldData.value - cost;
        cost += (priceIncrease * i);
        damageData.value += 5;
        costData.value = cost;
    }
    private void OnEnable()
    {
        UpdateShop();
    }
    public void UpdateShop()
    {
        if (goldData.value < cost)
        {
            shopButton.interactable = false;
        }
        else
        {
            shopButton.interactable = true;
        }
    }
}
