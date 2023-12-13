using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [Header("General Stats")]
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _maxStamina;

    [Header("Combat Stats")]
    [SerializeField] private int _maxAttack;
    [SerializeField] private int _maxDefense;

    public HealthBar _healthBar = null;
    public StaminaBar _staminaBar = null;
    public LevelNumber _levelNumber = null;

    private int _currentHealth;
    private int _currentStamina;

    private void Awake()
    {
        _currentHealth = _maxHealth;
        _currentStamina = _maxStamina;

    }



}
