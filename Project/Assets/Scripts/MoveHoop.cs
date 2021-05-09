using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHoop : MonoBehaviour
{
    public GameObject hoopTop;
    public GameObject scripts;

    public static bool move=false;
    float offset;
    float xChange = 0.01f;

    public void Update()
    {
        if(move == true)
        {
            offset = hoopTop.transform.position.x;

            if(offset>0.45 || offset<-0.45)
            {
                xChange = -xChange;
            }

            hoopTop.transform.Translate(Vector3.right * xChange);
        }
    }

    public void StartMovement()
    {
        Audio audio = scripts.GetComponent<Audio>();
        audio.rightButtonPressSound();

        if (move==false)
        {
            move = true;
        }
        else
        {
            hoopTop.transform.localPosition = Vector3.zero;
            move = false;
        }
        
    }
}
