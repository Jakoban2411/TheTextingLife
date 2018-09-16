using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "State")]
public class StoryStatesObject : ScriptableObject
{
    [TextArea(10, 15)] [SerializeField] string Dialogue;
    [SerializeField] Sprite MyReplySprite;
    [SerializeField] Sprite PlayerReplySprite;
    [SerializeField] StoryStatesObject[] NextStates;
    public string GetStateDialogue()
    {
        return Dialogue;
    }
    public StoryStatesObject[] GetNextStates()
    {
        return NextStates;
    }
    public Sprite GetDialogueSprite()
    {
        return MyReplySprite;
    }
    public Sprite GetPlayerSprite()
    {
        return PlayerReplySprite;
    }
}
