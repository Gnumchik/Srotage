using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bootstraper : MonoBehaviour
{

    [SerializeField] Animator animator;
    [SerializeField] Button[] button;

    private AttackPerformer attackPerformer;

    private void Awake()
    {
        attackPerformer = new AttackPerformer(animator , button);
        attackPerformer.Awake();
    }

    private void Update()
    {
        attackPerformer.Update();
    }


}
