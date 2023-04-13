using UnityEngine;

public class AudioTest : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;

    public void Play (AudioClip audioClip) {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
