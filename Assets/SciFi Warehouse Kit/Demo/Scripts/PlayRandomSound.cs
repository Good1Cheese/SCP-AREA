using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{

    public AudioSource randomSound;
    public AudioClip[] audioSources;

    public int clipDelay = 5;

    // Use this for initialization
    private void Start()
    {

        StartAudio();
    }

    private void StartAudio()
    {
        Invoke("RandomSoundness", clipDelay);
    }

    private void RandomSoundness()
    {
        randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
        randomSound.Play();
        StartAudio();
    }
}