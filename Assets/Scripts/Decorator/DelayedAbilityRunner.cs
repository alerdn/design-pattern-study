using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedAbilityRunner : MonoBehaviour
{
    [SerializeField] 
    private IAbility _currentAbility = new DelayedDecorator(new RageAbility());

    public void UseAbility()
    {
        _currentAbility.Use(gameObject);
    }
}
