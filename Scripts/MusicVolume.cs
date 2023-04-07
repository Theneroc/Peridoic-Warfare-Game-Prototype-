using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    public Slider slider;
    public AudioSource audioSource;
    private float volume = .1f;


    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
       
    }

    void Update()
    {
        audioSource.volume = this.volume;
    }
    public void VolumeUpdate(float volume)
    {
        this.volume = volume;
    }

}

