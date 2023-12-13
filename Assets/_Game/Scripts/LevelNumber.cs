using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelNumber : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentLevelTextView;
    private int _currentLevel = 1;

    public void IncreaseLevelValue()
    {
        _currentLevel++;
        _currentLevelTextView.text = _currentLevel.ToString();
    }
}
