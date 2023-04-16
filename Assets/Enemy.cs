using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator animator;

    public float Health
    {
        set
        {
            health = value;
            print("hit");
            if(health <= 0)
            {
                print("dead");
                Defeated();
            }
        }
        get { return health; }
    }
    public float health = 1;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Defeated()
    {
        animator.SetTrigger("Defeated");
    }

    public void RemoveEnemy()
    {
        Destroy(gameObject);
    }
}
