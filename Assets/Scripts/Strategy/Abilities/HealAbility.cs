using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : IAbility
{
    public void Use(GameObject currentGameObject)
    {
        Debug.Log("Here eat this!");
    }
}
