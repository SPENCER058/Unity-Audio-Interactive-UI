using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CooldownButton : MonoBehaviour
{
	[SerializeField] Button button;
	[SerializeField] TMP_Text countDownText;
	[SerializeField] float duration = 10;

	float timer;
	bool isCoolDown = false; 

	private void Start () {
		button.interactable = true;
		countDownText.text = "Button";
		button.image.fillAmount = 1;
	}

	public void StartCooldown () {
		button.interactable = false;
		timer = duration;
		countDownText.text = timer.ToString("F1") + " s";
		button.image.fillAmount = timer / duration;
		isCoolDown = true;
	}

	private void Update () {
		if (isCoolDown == false) {
			return;
		}

		timer -= Time.deltaTime;
		countDownText.text = timer.ToString("F1") + " s";
		button.image.fillAmount = timer / duration;

		if (timer <= 0) {
			button.interactable = true;
			countDownText.text ="Button";
			button.image.fillAmount = 1;
			isCoolDown=false;
		}
	}
}
