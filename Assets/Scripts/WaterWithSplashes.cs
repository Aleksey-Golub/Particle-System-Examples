using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWithSplashes : MonoBehaviour
{
    [SerializeField] private GameObject _effect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreCollision(collision.collider, collision.otherCollider);

        Instantiate(_effect, collision.GetContact(0).point, Quaternion.identity);
    }
}
