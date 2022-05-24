using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxLife = 10;

    private void OnEnable()
    {
        // Forma de adicionarmos UpgradeLife como listener de OnLevelUpAction
        GetComponent<Level>().OnLevelUpAction += UpgradeLife;
    }

    private void OnDisable()
    {
        // Forma de remover um listener do OnLevelUpAction
        GetComponent<Level>().OnLevelUpAction -= UpgradeLife;
    }

    private void UpgradeLife()
    {
        maxLife *= 1.1f;
    }
}
