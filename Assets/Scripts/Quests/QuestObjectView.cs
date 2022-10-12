using System;
using UnityEngine;

public class QuestObjectView : MonoBehaviour
{
    [SerializeField] 
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    private SpriteRenderer _door;
    
    [SerializeField] 
    private Color _completedColor;

    //[SerializeField]
    //private SpriteRenderer _door;
    
    [SerializeField] 
    private int _id;

    public int Id => _id;
    
    private Color _defaultColor;

    private Transform _defaultTransform;

    public Action<CharacterView> OnLevelObjectContact;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var levelObject = collider.gameObject.GetComponent<CharacterView>();
        OnLevelObjectContact?.Invoke(levelObject);
    }
    
    private void Awake()
    {
        _defaultColor = _spriteRenderer.color;
        _defaultTransform = _door.transform;
    }

    public void ProcessComplete()
    {
        _spriteRenderer.color = _completedColor;
        _door.transform.position = new Vector3(1.5f, -1.5f, 0);
    }
  
    public void ProcessActivate()
    {
        _spriteRenderer.color = _defaultColor;
    }

}
