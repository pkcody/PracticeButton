using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleButton : MonoBehaviour
{
    public Text myLabel;
    private int number;
    public AudioClip aclip;

    void Start()
    {
        number = 0;
        Debug.Log("Clicked");
    }

    public void ButtonWasPressed()
    {
        number++;
        myLabel.GetComponent<Text>().text = "Times Clicked: " + number;

        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = aclip;
        audio.Play();
    }
}
