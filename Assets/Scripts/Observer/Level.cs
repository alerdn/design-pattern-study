using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    public int currentXp = 1;
    public int xpPerLevel = 100;

    // Usando observer utilizando Inspector da Unity
    public UnityEvent onLevelUp;

    // Usando observer apenas com C# e não Unity propriamente dita
    public event Action OnLevelUpAction;

    public void GainXp(int amount)
    {
        int level = GetLevel();
        currentXp += amount;

        if (GetLevel() > level)
        {
            // Invoca todos os métodos ouvindo o evento onLevelUp utilizando Inspector da Unity
            onLevelUp.Invoke();

            // Esta é uma forma de usar o observer sem precisar de UnityEvent, já que é algo da linguagem C#
            OnLevelUpAction?.Invoke();
        }
    }

    public int GetLevel()
    {
        // Calcular é melhor do que salvar em uma variável
        return currentXp / xpPerLevel;
    }
}
