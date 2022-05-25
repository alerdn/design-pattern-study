using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthPresenter : MonoBehaviour
{
    public Health health;
    public TMP_Text hpText;

    private void Start()
    {
        health.OnLifeUpgrade += UpdateUI;
        UpdateUI();
    }

    private void UpdateUI()
    {
        hpText.text = $"HP: {health.maxLife}";
    }
}
