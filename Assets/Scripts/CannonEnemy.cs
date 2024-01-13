using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class CannonEnemy : Enemy
    {
        private bool attacked = false;
        public override void Attack()
        {
            if (!attacked)
            {
                StartCoroutine(shoot());
                attacked = true;
            }
        }

        IEnumerator shoot()
        {
            yield return new WaitForSeconds(2);

            Vector3 director = player.transform.position - transform.position;
            enemyRb.AddForce(director.normalized * speed, ForceMode.Impulse);
        }
    }
}