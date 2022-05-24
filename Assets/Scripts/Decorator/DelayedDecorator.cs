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
        /* A ideia aqui � usar algum c�digo antes da habilidade em si,
         assim a classe dela fica limpa, fazendo uma fun��o s� */
        wrappedAbility.Use(currentGameObject);
    }
}
