using System;
using UnityEngine;

public class QuestObjectView : MonoBehaviour
{
    [SerializeField] 
    private SpriteRenderer _spriteRenderer;
    
    [SerializeField] 
    private Color _completedColor;

    //[SerializeField]
    //private SpriteRenderer _door;
    
    [SerializeField] 
    private int _id;

    public int Id => _id;
    
    private Color _defaultColor;

    public Action<CharacterView> OnLevelObjectContact;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var levelObject = collider.gameObject.GetComponent<CharacterView>();
        OnLevelObjectContact?.Invoke(levelObject);
    }
    
    private void Awake()
    {
        _defaultColor = _spriteRenderer.color;
    }

    public void ProcessComplete()
    {
        _spriteRenderer.color = _completedColor;
        

    }
  
    public void ProcessActivate()
    {
        _spriteRenderer.color = _defaultColor;
    }

    //public void OpenDoor(SpriteRenderer door)
    //{
    //    _door = door;
    //    _door.transform.position = new Vector3(0, -5, 0);
    //}
}
