public class InAirState : LocomotionState
{
    public void Crouch(LocomotionContext context)
    {
    }

    public void Fall(LocomotionContext context)
    {
    }

    public void Jump(LocomotionContext context)
    {
    }

    public void Land(LocomotionContext context)
    {
        context.SetState(new GroundedState());
    }
}