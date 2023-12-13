using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider _staminaVal = null;

    public void SetMaxStamina(int stamina)
    {
        _staminaVal.maxValue = stamina;
        _staminaVal.value = stamina;
    }

    public void SetStamina(int stamina)
    {
        _staminaVal.value = stamina;
    }
}
