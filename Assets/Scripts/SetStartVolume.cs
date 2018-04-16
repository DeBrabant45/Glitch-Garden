using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour
{
    private MusicManager musicManger;

	// Use this for initialization
	void Start ()
    {
        musicManger = GameObject.FindObjectOfType<MusicManager>();

        if (musicManger)
        {
            float volume = PlayerPrefsManager.GetMasterVolume();
            musicManger.SetVolume(volume);
        }
        else
        {
            Debug.LogWarning("No music manager found on start scene.");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}