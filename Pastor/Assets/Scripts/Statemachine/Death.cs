using System;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class Death : BaseState
{
    public override void EnterState(EnemyStateManager manager)
    {
        manager.SetSpeed(0f);
        manager.animator.SetBool("Isdead", true);
        Win.score += 100;
        if (manager.CompareTag("miniboss"))
        {
            Win.score += 1000000;
        }
    }
    public override void ExitState(EnemyStateManager manager)
    {

    }
    public override void UpdateState(EnemyStateManager manager)
    {
        
    }
}
