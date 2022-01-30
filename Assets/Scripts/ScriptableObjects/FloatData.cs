using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;

    // num is adjustable in the unity editor
    public void AddToValue(float num)
    {
        //simple function to add to value
        value += num;
    }

    public void SubtractValue(float num)
    {
        value -= num;
    }
    public void ResetValue(float num)
    {
        value = num;
    }
}