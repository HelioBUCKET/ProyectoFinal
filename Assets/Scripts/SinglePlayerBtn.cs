using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SinglePlayerBtn : MonoBehaviour {
        
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("The cursor entered the selectable UI element.");
    }
    public void OnSelect(BaseEventData eventData)
    {
        Debug.Log("The cursor entered the selectable UI element. LOL");


    }

}
