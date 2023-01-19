using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1 : IAttackStrategy
{
    public void Attack(Animator animator)
    {
        animator.SetTrigger("a1");
    }
}

