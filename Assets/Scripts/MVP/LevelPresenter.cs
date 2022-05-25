using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class LevelPresenter : MonoBehaviour
{
    public Level level;
    public TMP_Text displayText;
    public Button xpButton;

    private void Start()
    {
        xpButton.onClick.AddListener(GainXp);
        level.OnExperienceChange += UpdateUI;
        UpdateUI();
    }

    private void GainXp()
    {
        level.GainXp(10);
    }

    private void UpdateUI()
    {
        displayText.text = $"Level: {level.GetLevel()}\nXP: {level.currentXp}";
    }
}
