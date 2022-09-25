using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PhysicsBullet
{
    public BulletView _bullets;
    public PhysicsBullet(BulletView bullets)
    {
        _bullets = bullets;
        _bullets.SetVisible(false);
    }
    public void Throw(Vector3 position, Vector3 velocity)
    {
        _bullets.SetVisible(false);
        _bullets.transform.position = position;
        _bullets.Rigidbody.velocity = Vector2.zero;
        _bullets.Rigidbody.angularVelocity = 0;
        _bullets.Rigidbody.AddForce(velocity, ForceMode2D.Impulse);
        _bullets.SetVisible(true);
    }
}

