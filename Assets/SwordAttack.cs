using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    Vector2 rightAttackOffset;
    public Collider2D SwordCollider;

    public float damage = 3;

    void Start()
    {
        rightAttackOffset = transform.position;
        SwordCollider.enabled = false;
    }
    void Update()
    {
        
    }

    public void AttackRight()
    {
        SwordCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }

    public void AttackLeft()
    {
        SwordCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack()
    {
        SwordCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            print("hit");
            //deal damage to enemy
            Enemy enemy = other.GetComponent<Enemy>();
            if( enemy != null)
            {
                enemy.Health -= damage;
            }
        }
        if(other.tag == "Chest")
        {
            Chest chest = other.GetComponent<Chest>();
            chest.Open();
        }
    }
}
