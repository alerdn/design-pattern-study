using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceComposite : IAbility
{
    public IAbility[] abilities;

    public SequenceComposite(IAbility[] abilities)
    {
        this.abilities = abilities;
    }

    public void Use(GameObject currentGameObject)
    {
        foreach (var ability in abilities)
        {
            ability.Use(currentGameObject);
        }
    }
}
