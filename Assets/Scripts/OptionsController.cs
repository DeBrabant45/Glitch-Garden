using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider; //Creating public variable to add the slider to the script
    public LevelManager levelManager;
    public Slider difficultySlider; 

    private MusicManager musicManager;

    // Use this for initialization
    void Start ()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update ()
    {
        musicManager.SetVolume(volumeSlider.value);
	}

    //Saving the playerprefs when hitting back in the options
    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        levelManager.LoadLevel("01a Start Menu");
    }

    //Setting values of the volume and difficulty sliders when a user clicks default 
    public void SetDefaults()
    {
        volumeSlider.value = .80f;
        difficultySlider.value = 2;
    }
}
