using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Debugger : MonoBehaviour
{
    public Level level;
    public Health health;

    public TMP_Text xpText;
    public TMP_Text levelText;
    public TMP_Text hpText;

    private void Awake()
    {
        StartCoroutine(Start());
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            level.GainXp(10);

            xpText.text = $"XP: {level.currentXp}";
            levelText.text = $"Level: {level.GetLevel()}";
            hpText.text = $"Health Points: {health.maxLife}";
        }
    }
}
