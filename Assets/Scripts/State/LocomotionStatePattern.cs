using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionStatePattern : MonoBehaviour, LocomotionContext
{
    private LocomotionState _currentState = new GroundedState();

    public void Crouch() => _currentState.Crouch(this);
    public void Fall() => _currentState.Fall(this);
    public void Jump() => _currentState.Jump(this);
    public void Land() => _currentState.Land(this);

    void LocomotionContext.SetState(LocomotionState state)
    {
        _currentState = state;
    }
}