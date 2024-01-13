using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class FollowerEnemy : Enemy // INHERITANCE
    {
        public override void Attack()
        {
            if (transform.position.y > 0f)
            {
                Vector3 director = player.transform.position - transform.position;
                enemyRb.AddForce(director.normalized * speed);
            }
        }
    }
}