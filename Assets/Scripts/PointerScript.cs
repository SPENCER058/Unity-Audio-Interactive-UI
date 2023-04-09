//using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointerScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	//Image image;

	TMP_Text txt;

	[SerializeField] Vector2 pointerPos;

	public UnityEvent onClick;
	public UnityEvent onHoverEnter;

	private void Start () {
		txt = GetComponent<TMP_Text>();
	}

	public void OnPointerEnter (PointerEventData eventData) {
		/*		image.color = Color.blue;
				onHoverEnter.Invoke();*/

		txt.fontStyle = FontStyles.Underline;
		onHoverEnter.Invoke();
	}

	public void OnPointerExit (PointerEventData eventData) {
		//image.color = Color.white;
		txt.fontStyle = FontStyles.Normal;
	}
/*
	public void OnPointerDown (PointerEventData eventData) {
		image.color = Color.grey;
		onClick.Invoke();
	}

	public void OnPointerUp (PointerEventData eventData) {
		image.color = Color.blue;
	}

	public void OnPointerMove (PointerEventData eventData) {
		pointerPos = eventData.position;
	}*/
}
