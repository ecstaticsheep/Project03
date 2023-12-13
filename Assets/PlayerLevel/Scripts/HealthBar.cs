using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider _healthVal = null;

    public void SetMaxHealth(int health)
    {
        _healthVal.maxValue = health;
        _healthVal.value = health;
    }

    public void SetHealth(int health)
    {
        _healthVal.value = health;
    }
}
