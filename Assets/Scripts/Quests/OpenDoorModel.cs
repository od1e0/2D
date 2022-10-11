using UnityEngine;

public class OpenDoorModel : IQuestModel
{
    public bool TryComplete(GameObject activator)
    {
        return activator.GetComponent<CharacterView>();
    }
}
