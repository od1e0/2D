using UnityEngine;

public class PhysicsBullet
{
    private BulletView _bulletView;
    private Vector3 _velocity;
    
    public PhysicsBullet(BulletView bulletView)
    {
        _bulletView = bulletView;
        _bulletView.SetVisible(false);
    }

    public void Throw(Vector3 position, Vector3 velocity)
    {
        _bulletView.SetVisible(false);
        _bulletView.transform.position = position;
        _bulletView.Rigidbody.velocity = Vector2.zero;
        _bulletView.Rigidbody.angularVelocity = 0;
        _bulletView.Rigidbody.AddForce(velocity, ForceMode2D.Impulse);
        _bulletView.SetVisible(true);
    }
}
