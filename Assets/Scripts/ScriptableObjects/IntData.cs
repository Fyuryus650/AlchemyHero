using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
    public bool canGoBelowZero;

    public void AddToValue(int num)
    {
        //simple function to add to value
        value += num;
    }

    public void SubtractFromValue(int num)
    {
        value -= num;
    }
    public void MulitplyValue(int num)
    {
        value *= num;
        if (canGoBelowZero = false && num < 0)
        {
            num = num * -1;
        }
    }
    public void DivideValue(int num)
    {
        value /= num;
    }

    public void ResetValue(int num)
    {
        value = num;
    }
}
