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

    private void Start()
    {
        _currentHealth = _maxHealth;
        _currentStamina = _maxStamina;
        _healthBar.SetMaxHealth(_maxHealth);
        _staminaBar.SetMaxStamina(_maxStamina);
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        _healthBar.SetHealth(_currentHealth);
    }

    public void WhenSprint()
    {
        _currentStamina -= 5;
        _staminaBar.SetStamina(_currentStamina);
    }

    public void LevelUp()
    {
        _maxHealth += 10;
        _currentHealth = _maxHealth;

        _maxStamina += 5;
        _currentStamina = _maxStamina;

        _maxAttack += 5;
        _maxDefense += 2;

        _healthBar.SetMaxHealth(_maxHealth);
        _staminaBar.SetMaxStamina(_maxStamina);
        _levelNumber.IncreaseLevelValue();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(5);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            WhenSprint();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            LevelUp();
        }

    }


}
