using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

    [SerializeField] Text StoryTextComponent;
    [SerializeField] StoryStatesObject StartingState;
    [SerializeField] Vector3 StartDialoguePosition;
    [SerializeField] Vector3 PlayerDialoguePosition;
    StoryStatesObject[] NextStates;
    StoryStatesObject CurrentState;
    [SerializeField] GameObject ParentImage;
    GameObject NewSpeechBubbletoGenerate;
    Image SpeechBubble;
    Sprite NextSpeechBubble;
    Vector3 NextPosition;
	// Use this for initialization
	void Start ()
    {
        CurrentState = StartingState;
        StoryTextComponent.text = CurrentState.GetStateDialogue();
        NextStates = CurrentState.GetNextStates();
        NextPosition = StartDialoguePosition + new Vector3(0, 50,0);
        NewSpeechBubbletoGenerate = new GameObject();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrentState = NextStates[0];
            StoryTextComponent.text = CurrentState.GetStateDialogue();
            NextStates = CurrentState.GetNextStates();
            NextSpeechBubble = CurrentState.GetDialogueSprite();
            SpeechBubble = NewSpeechBubbletoGenerate.AddComponent<Image>();
            SpeechBubble.sprite = NextSpeechBubble;
            NewSpeechBubbletoGenerate.GetComponent<RectTransform>().SetParent(ParentImage.transform);
            NewSpeechBubbletoGenerate.transform.position = NextPosition;
            NewSpeechBubbletoGenerate.transform.localScale = new Vector3(2, 2, 2);
            NextPosition =NextPosition+ new Vector3(0, 50,0);
            NewSpeechBubbletoGenerate.SetActive(true);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                CurrentState = NextStates[1];
                NextStates = CurrentState.GetNextStates();
            }
            /*else
            {
                CurrentState = NextStates[2];
                NextStates = CurrentState.GetNextStates();
            }*/
        }
    }
}
