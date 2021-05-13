using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource leftButton;
    public AudioSource rightButton;
    public AudioSource cannon;
    public AudioSource explosion;
    public AudioSource otherExplosion;
    public AudioSource highScore;
    public AudioSource lowScore;
    public AudioSource cheering;
    public AudioSource louderCheering;

    public void Start()
    {
        cheering.Play();
    }

    public void leftButtonPressSound()
    {
        if(leftButton)
        {
            leftButton.Play();
        }
        else
        {
            Debug.Log("button error");
        }
        
    }
    public void rightButtonPressSound()
    {
        if (rightButton)
        {
            rightButton.Play();
        }
        else
        {
            Debug.Log("button error");
        }

    }
    public void cannonLaunchSound()
    {
        if (cannon)
        {
            cannon.Play();
        }
        else
        {
            Debug.Log("cannonlaunch error");
        }
    }
    public void highScoreSound()
    {
        if(highScore)
        {
            highScore.Play();
        }
        else
        {
            Debug.Log("highscore error");
        }
    }
    public void lowScoreSound()
    {
        if(lowScore)
        {
            lowScore.Play();
        }
        else
        {
            Debug.Log("lowScore error");
        }
    }
    public void explosionSound()
    {
        if(explosion)
        {
            explosion.Play();
            louder();
        }
        else
        {
            Debug.Log("explosion error");
        }
    }
    public void otherExplosionSound()
    {
        if (otherExplosion)
        {
            otherExplosion.Play();
        }
        else
        {
            Debug.Log("other explosion error");
        }
    }
    public void louder()
    {
        louderCheering.Play();
    }
}
