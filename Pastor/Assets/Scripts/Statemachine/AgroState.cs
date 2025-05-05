using UnityEngine;

public class AgroState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(1.5f);
        manager.animator.SetBool("IsPoisk", false);
        manager.animator.SetBool("IsAttack", false);
        manager.animator.SetBool("IsAgro", true);
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
        if (manager.DistToTarget() <= 1.7)
        {
            manager.SwitchState(manager.attacState);
            return;
        }
    }
}
