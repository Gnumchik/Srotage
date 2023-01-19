using UnityEngine;

public class Context
{
    private Animator animator;

    private IAttackStrategy attacksStrategy;

    public Context(Animator animator)
    {
        this.animator = animator;
    }

    public void Stratage(IAttackStrategy attackStrategy)
    {
        attacksStrategy = attackStrategy;
    }

    public void PreformAttack()
    {
        attacksStrategy.Attack(animator);
    }

}
