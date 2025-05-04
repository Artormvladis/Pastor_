using UnityEngine;

public class PoiskState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(1);
        manager.animator.SetBool("IsPoisk", true);
    }
    public override void ExitState(EnemyStateManager manager)
    {

    }
    public override void UpdateState(EnemyStateManager manager)
    {
        if (manager.DistToTarget() <= 8)
        {
            manager.SwitchState(manager.agroState);
            return;
        }
    }
}
