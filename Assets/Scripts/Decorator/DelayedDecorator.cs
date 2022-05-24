using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDecorator : IAbility
{
    private IAbility wrappedAbility;

    public DelayedDecorator(IAbility wrappedAbility)
    {
        this.wrappedAbility = wrappedAbility;
    }

    public void Use(GameObject currentGameObject)
    {
        /* A ideia aqui é usar algum código antes da habilidade em si,
         assim a classe dela fica limpa, fazendo uma função só */
        wrappedAbility.Use(currentGameObject);
    }
}
