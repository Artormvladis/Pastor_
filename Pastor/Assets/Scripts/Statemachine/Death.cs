using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Death : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(0f);
        manager.animator.SetBool("Isdead", true);
        Win.score += 100;
    }
    public override void ExitState(EnemyStateManager manager)
    {

    }
    public override void UpdateState(EnemyStateManager manager)
    {
        
    }
}
