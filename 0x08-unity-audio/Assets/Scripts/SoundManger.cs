using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManger : MonoBehaviour
{
    private static readonly string FristPlay = "FristPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectPref";
    private int firstPlayInt;
    public Slider backgroundSlider, soundEffectSlider;
    private float backgroundFloat, soundEffectFloat;

    public AudioSource BGM;
    public AudioSource[] souneffect;
    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FristPlay);

        if (firstPlayInt == 0)
        {
            backgroundFloat = .25f;
            soundEffectFloat = .75f;
            backgroundSlider.value = backgroundFloat;
            soundEffectSlider.value = soundEffectFloat;
            PlayerPrefs.SetFloat(BackgroundPref, backgroundFloat);
            PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectFloat);
            PlayerPrefs.SetInt(FristPlay, -1);
        }
        else
        {
            backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
            backgroundSlider.value = backgroundFloat;
            soundEffectFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
            soundEffectSlider.value = soundEffectFloat;
        }

    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackgroundPref, backgroundSlider.value);
        PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectSlider.value);
    }

    private void OnApplicationFocus(bool infocus)
    {
        if(!infocus)
        {
            SaveSoundSettings();
        }
        
    }

    public void UpdateSound()
    {
        BGM.volume = backgroundSlider.value;

        for (int i = 0; i < souneffect.Length; i++)
        {
            souneffect[i].volume = soundEffectSlider.value;
        }
    }





}
