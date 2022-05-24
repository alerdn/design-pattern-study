public class GroundedState : LocomotionState
{
    public void Crouch(LocomotionContext context)
    {
        context.SetState(new CrouchingState());
    }

    public void Fall(LocomotionContext context)
    {
        context.SetState(new InAirState());
    }

    public void Jump(LocomotionContext context)
    {
        context.SetState(new InAirState());
    }

    public void Land(LocomotionContext context)
    {
    }
}
