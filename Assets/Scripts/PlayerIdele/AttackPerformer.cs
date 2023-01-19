using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackPerformer
{

    private Animator animator;
    private Button[] button;

    private Context context;
    private Attack1 attack1;
    private Attack2 attack2;
    private Attack3 attack3;

    public AttackPerformer(Animator animator, Button[] button)
    {
        this.animator = animator;
        this.button = button;
        button[0].onClick.AddListener(Attack);
        button[1].onClick.AddListener(Attack2);
        button[2].onClick.AddListener(Attack3);

    }


    public void Awake()
    {
        context = new Context(animator);
        attack1 = new Attack1();
        attack2 = new Attack2();
        attack3 = new Attack3();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            context.PreformAttack();
        }
    }

    public void Attack()
    {
        context.Stratage(attack1);
        button[0].image.color = Color.black;
        button[1].image.color = Color.white;
        button[2].image.color = Color.white;
    }

    public void Attack2()
    {
        context.Stratage(attack2);
        button[0].image.color = Color.white;
        button[1].image.color = Color.black;
        button[2].image.color = Color.white;
    }
    public void Attack3()
    {
        context.Stratage(attack3);
        button[0].image.color = Color.white;
        button[1].image.color = Color.white;
        button[2].image.color = Color.black;
    }

}
