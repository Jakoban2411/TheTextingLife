using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

    [SerializeField] Text StoryTextComponent;
    [SerializeField] StoryStatesObject StartingState;
    [SerializeField] Vector2 StartDialoguePosition;
    StoryStatesObject[] NextStates;
    StoryStatesObject CurrentState;
    [SerializeField] GameObject ParentImage;
    Image NewSpeechBubbletoGenerate, NextSpeechBubble;
    Vector2 NextPosition;
	// Use this for initialization
	void Start ()
    {
        CurrentState = StartingState;
        StoryTextComponent.text = CurrentState.GetStateDialogue();
        NextStates = CurrentState.GetNextStates();
        NextPosition = StartDialoguePosition + new Vector2(0, 50);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrentState = NextStates[0];
            NextStates = CurrentState.GetNextStates();
            NextSpeechBubble = CurrentState.GetDialogueImage();
            NewSpeechBubbletoGenerate = ParentImage.AddComponent<Image>();
            NewSpeechBubbletoGenerate.sprite = NextSpeechBubble.sprite;
            NewSpeechBubbletoGenerate.GetComponent<RectTransform>().SetParent(ParentImage.transform);
            NewSpeechBubbletoGenerate.transform.position = NextPosition;
            NextPosition =NextPosition+ new Vector2(0, 50);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                CurrentState = NextStates[1];
                NextStates = CurrentState.GetNextStates();
            }
            else
            {
                CurrentState = NextStates[2];
                NextStates = CurrentState.GetNextStates();
            }
        }
    }
}
