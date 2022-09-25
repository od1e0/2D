using UnityEngine;

public class BulletView : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    private Rigidbody2D _rigidbody;

    [SerializeField]
    private Collider2D _collider;

    [SerializeField]
    private TrailRenderer _trailRenderer;

    [SerializeField]
    private Transform _physicsBullet;

    [Header("Settings")]
    
    private float _radius = 0.3f;
    
    private float _groundLevel = 0;
    
    private float _acceleration = -10;

    public float Radius => _radius;

    public float GroundLevel => _groundLevel;

    public float Acceleration => _acceleration;

    public Rigidbody2D Rigidbody => _rigidbody;

    public Collider2D Colider => _collider;

    public Transform Bullet => _physicsBullet;
    
    public TrailRenderer TrailRenderer => _trailRenderer;


    public void SetVisible(bool visible)
    {
        _spriteRenderer.enabled = visible;
    }
}
