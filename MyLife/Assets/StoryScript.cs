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
    GameObject MyNewSpeechBubbletoGenerate;
    Image MySpeechBubble;
    Sprite MyNextSpeechBubble;
    Vector3 MyNextPosition;
    GameObject PlayerNewSpeechBubbletoGenerate;
    Image PlayerSpeechBubble;
    Sprite PlayerNextSpeechBubble;
    Vector3 PlayerNextPosition;

    // Use this for initialization
    void Start ()
    {
        CurrentState = StartingState;
        StoryTextComponent.text = CurrentState.GetStateDialogue();
        NextStates = CurrentState.GetNextStates();
        PlayerNextPosition = PlayerDialoguePosition;
        MyNextPosition = StartDialoguePosition;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MyNewSpeechBubbletoGenerate = new GameObject();
            PlayerNewSpeechBubbletoGenerate = new GameObject();

            CurrentState = NextStates[0];
            StoryTextComponent.text = CurrentState.GetStateDialogue();
            NextStates = CurrentState.GetNextStates();

            PlayerNextSpeechBubble = CurrentState.GetPlayerSprite();
            PlayerSpeechBubble = PlayerNewSpeechBubbletoGenerate.AddComponent<Image>();
            PlayerSpeechBubble.sprite = PlayerNextSpeechBubble;
            PlayerNewSpeechBubbletoGenerate.GetComponent<RectTransform>().SetParent(ParentImage.transform);
            PlayerNewSpeechBubbletoGenerate.transform.position = PlayerNextPosition;
            MyNextPosition.y =PlayerNextPosition.y- 70;
            PlayerNewSpeechBubbletoGenerate.transform.localScale = new Vector3(2, 2, 2);
            PlayerNewSpeechBubbletoGenerate.SetActive(true);

            MyNextSpeechBubble = CurrentState.GetDialogueSprite();
            MySpeechBubble = MyNewSpeechBubbletoGenerate.AddComponent<Image>();
            MySpeechBubble.sprite = MyNextSpeechBubble;
            MyNewSpeechBubbletoGenerate.GetComponent<RectTransform>().SetParent(ParentImage.transform);
            MyNewSpeechBubbletoGenerate.transform.position = MyNextPosition;
            MyNewSpeechBubbletoGenerate.transform.localScale = new Vector3(2, 2, 2);
            PlayerNextPosition.y =MyNextPosition.y- 70;
            MyNewSpeechBubbletoGenerate.SetActive(true);
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
