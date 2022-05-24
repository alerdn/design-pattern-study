public class CrouchingState : LocomotionState
{
    public void Crouch(LocomotionContext context)
    {
        context.SetState(new GroundedState());
    }

    public void Fall(LocomotionContext context)
    {
        context.SetState(new InAirState());
    }

    public void Jump(LocomotionContext context)
    {
        context.SetState(new GroundedState());
    }

    public void Land(LocomotionContext context)
    {
    }
}