using UnityEngine;
/// <summary>
/// Represents any integer variable.
/// </summary>
[CreateAssetMenu(fileName = "IntegerVariable", menuName = "ScriptabelObjects/IntegerVariable", order = 0)]
public class IntegerValue : ScriptableObject
{
    /// <summary>
    /// Value of this variable. Access through property.
    /// </summary>
    private int variableValue;
    /// <summary>
    /// Value of this variable.
    /// Will be set to zero if it is lower than zero. 
    /// </summary>
    public int Value
    {
        get => variableValue;
        set
        {
            variableValue = value >= 0 ? value : 0;
        }
    }
    #region Operators overloads and methods overredes.
    public static implicit operator int(IntegerValue integerVariable) => integerVariable.Value;
    public static IntegerValue operator ++(IntegerValue integerVariable)
    {
        integerVariable.Value++;
        return integerVariable;
    }
    public override string ToString() => variableValue.ToString();
    #endregion
}

