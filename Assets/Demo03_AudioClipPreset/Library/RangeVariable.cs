using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct RangeFloat
{
    public RangeFloat(float i_value)
    {
        m_minValue = i_value;
        m_maxValue = i_value;
    }

    public RangeFloat(float i_min, float i_max)
    {
        m_minValue = i_min;
        m_maxValue = i_max;
    }

    [SerializeField]
    private float m_minValue;
    [SerializeField]
    private float m_maxValue;

    public float MinValue
    {
        get { return m_minValue; }
        set { m_minValue = value; }
    }

    public float MaxValue
    {
        get { return m_maxValue; }
        set { m_maxValue = value; }
    }
}
