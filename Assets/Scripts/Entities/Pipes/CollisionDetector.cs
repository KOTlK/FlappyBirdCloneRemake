using System.Collections;
using UnityEngine;

namespace Entities
{
    public class CollisionDetector : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.TryGetComponent<Player>(out Player player))
            {
                player.Die();
            }
        }
    }
}