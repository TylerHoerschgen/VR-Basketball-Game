using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMesh timer;
    public TextMesh score;
    public TextMesh highScore;
    private float timerTime = 60;
    public static bool startTimer;

    public void Start()
    {
        startTimer = false;
    }

    public void Update()
    {
        if (startTimer == true)
        {
            if (timerTime > 0)
            {
                timerTime -= Time.deltaTime;
                timer.text = timerTime.ToString("#0.00");
            }
            else
            {
                startTimer = false;
                timerTime = 60;
                timer.text = timerTime.ToString("#0.00");

                spawnBall.Despawn();

                if(MoveHoop.move)
                {
                    GameObject Hoop = GameObject.Find("MoveableHoop");
                    Hoop.transform.localPosition = new Vector3(0, 0, 0);
                    MoveHoop.move = false;
                }

                GameObject temp = GameObject.Find("Scripts");
                Audio audio = temp.GetComponent<Audio>();

                if (int.Parse(score.text) > int.Parse(highScore.text))
                {
                    highScore.text = score.text;
                    
                    audio.highScoreSound();
                    audio.louder();
                }
                else
                {
                    audio.lowScoreSound();
                }
                score.text = "0";
                hoopControl.Reset();
            }
        }
    }

    public static void StartTimer()
    {
        if(startTimer == false)
        {
            startTimer = true;
        }
    }
}
