using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{

    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;

	void Awake ()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destory on load: " + name);
	}

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[scene.buildIndex];

        // if Music is attached 
        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
            //Debug.Log(thisLevelMusic.length);
        }
    }

    //void OnLevelWasLoaded(int level)
    //{
    //    AudioClip thisLevelMusic = levelMusicChangeArray[level];
    //    Debug.Log("playing clip: " + thisLevelMusic);
    //    Debug.Log(thisLevelMusic);

    //    // if Music is attached 
    //    if (thisLevelMusic)
    //    {
    //        audioSource.clip = thisLevelMusic;
    //        audioSource.loop = true;
    //        audioSource.Play();
    //        Debug.Log(thisLevelMusic.length);
    //    }

    //}

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
