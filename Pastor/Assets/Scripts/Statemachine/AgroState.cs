using UnityEngine;

public class AgroState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(2);
    }
    public override void ExitState(EnemyStateManager manager)
    {

    }
    public override void UpdateState(EnemyStateManager manager)
    {
        if (manager.DistToTarget() > 8)
        {
            manager.SwitchState(manager.poiskState);
            return;
        }
        if (manager.DistToTarget() <= 3)
        {
            manager.SwitchState(manager.attacState);
            return;
        }
    }
}
