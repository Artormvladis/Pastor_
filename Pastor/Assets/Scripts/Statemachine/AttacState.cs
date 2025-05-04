using UnityEngine;

public class AttacState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(0);
    }
    public override void ExitState(EnemyStateManager manager)
    {

    }
    public override void UpdateState(EnemyStateManager manager)
    {
        if (manager.DistToTarget() > 3) 
        {
            manager.SwitchState(manager.agroState);
            return;
        }
    }
}