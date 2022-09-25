using System.Collections.Generic;
using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private SpriteRenderer _background;
    
    [SerializeField]
    private CharacterView _characterView;

    [SerializeField]
    private SpriteAnimationConfig _spriteAnimationConfig;
    
    [SerializeField]
    private CannonView _cannonView;

    [SerializeField] 
    private List<BulletView> _bullets;

    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    //private MainHeroWalker _mainHeroWalker;
    private MainHeroPhysicsWalk _mainHeroPhysicsWalk;
    private AimingMuzzle _aimingMuzzle;
    private BulletsEmitter _bulletsEmitter;
    private BulletView _physicsBullets;

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        //_mainHeroWalker = new MainHeroWalker(_characterView, _spriteAnimator);
        _aimingMuzzle = new AimingMuzzle(_cannonView.transform, _characterView.transform);
        //_bulletsEmitter = new BulletsEmitter(_bullets, _cannonView.MuzzleTransform);
        _mainHeroPhysicsWalk = new MainHeroPhysicsWalk(_characterView, _spriteAnimator);
        //_physicsBullets = new PhysicsBullet(_physicsBullets);
    }

    private void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
        //_mainHeroWalker.Update();
        _aimingMuzzle.Update();
        //_bulletsEmitter.Update();
        
    }

    private void FixedUpdate()
    {
        _mainHeroPhysicsWalk.FixedUpdate();
    }

    private void OnDestroy()
    {
        
    }
}
