using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,IEventSystemHandler {

	private bool buttonPressed = false;


	public bool GetButtonPressed (){
		return buttonPressed;
	}

	public void OnPointerDown(PointerEventData eventData){
		buttonPressed = true;
	}
	public void OnPointerUp(PointerEventData eventData){
		buttonPressed = false;
	}
}