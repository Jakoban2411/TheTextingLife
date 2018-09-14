using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "State")]
public class StoryStatesObject : ScriptableObject
{
    [SerializeField] Image DialogueBubble;
    [TextArea(10, 15)] [SerializeField] string Dialogue;
    [SerializeField] StoryStatesObject[] NextStates;
    public string GetStateDialogue()
    {
        return Dialogue;
    }
    public StoryStatesObject[] GetNextStates()
    {
        return NextStates;
    }
    public Image GetDialogueImage()
    {
        return DialogueBubble;
    }
}
