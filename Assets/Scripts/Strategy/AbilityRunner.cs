using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityRunner : MonoBehaviour
{
    [SerializeField] private IAbility _currentAbility = new RageAbility();

    public void UseAbility()
    {
        _currentAbility.Use(gameObject);
    }
}
