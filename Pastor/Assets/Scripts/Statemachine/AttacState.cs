using UnityEngine;

public class AttacState : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        if (manager.CompareTag("miniboss") && EnemyStateManager.minibossspeed <= 2.5)
        {
            EnemyStateManager.minibossspeed += 0.5f;
        }
        manager.SetSpeed(0);
        manager.animator.SetBool("IsAttack", true);
    }
    public override void ExitState(EnemyStateManager manager)
    {

    }
    public override void UpdateState(EnemyStateManager manager)
    {

    }
}