using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource musicSource;

    void Start()
    {
        if (musicSource != null)
        {
            musicSource.loop = true;
            musicSource.Play();
        }
    }
}
