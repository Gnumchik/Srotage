using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2 : IAttackStrategy
{
    public void Attack(Animator animator)
    {
        animator.SetTrigger("a2");
    }
}
