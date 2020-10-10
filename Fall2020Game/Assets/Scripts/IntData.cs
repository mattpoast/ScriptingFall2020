using System;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public Void UpdateValue(int number)
    {
        value += number;
        Debug.Log(value +" "+this.name);
    }
}
