using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

    [SerializeField] Text StoryTextComponent;
	// Use this for initialization
	void Start ()
    {
        StoryTextComponent.text = ("Heyo! I got your number from our mutual friend!");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
