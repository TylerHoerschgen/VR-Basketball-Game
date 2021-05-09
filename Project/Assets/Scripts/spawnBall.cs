using System.Collections.Generic;
using UnityEngine;
using Tilia.Interactions.Interactables.Interactables;

public class spawnBall : MonoBehaviour
{
    public GameObject ball;
    public GameObject scripts;
    private static List<GameObject> spawnedBallsList;

    public void Start()
    {
        spawnedBallsList = new List<GameObject>();
    }

    public void generateBall()
    {
        Audio audio = scripts.GetComponent<Audio>();
        audio.leftButtonPressSound();
        audio.cannonLaunchSound();
        
        Timer.StartTimer();
        GameObject createdBall = Instantiate(ball);
        tooManyBalls();

        spawnedBallsList.Add(createdBall);
        createdBall.transform.position = new Vector3(-2.361f, 1.718f, 2.985f);
        createdBall.GetComponent<Rigidbody>().AddForce(new Vector3(8.0f, 5.0f, -10.0f), ForceMode.Impulse);    
    }

    public static void Despawn()
    {
        List<GameObject> temp = new List<GameObject>();

        for (int i=0; i < spawnedBallsList.Count; i++)
        {
            if(spawnedBallsList[i])
            {
                InteractableFacade interactable = spawnedBallsList[i].GetComponent<InteractableFacade>();
                if(interactable.IsGrabbed)
                {
                    temp.Add(spawnedBallsList[i]);
                }
                else
                {
                    Destroy(spawnedBallsList[i]);
                }
            }
        }
        spawnedBallsList = temp;
    }

    private void tooManyBalls()
    {
        if(spawnedBallsList.Count>4)
        {
            if (spawnedBallsList[0])
            {
                InteractableFacade interactable = spawnedBallsList[0].GetComponent<InteractableFacade>();
                if(!interactable.IsGrabbed)
                {
                    Destroy(spawnedBallsList[0]);
                    spawnedBallsList.RemoveAt(0);
                }
                else
                {
                    interactable = spawnedBallsList[1].GetComponent<InteractableFacade>();
                    if (!interactable.IsGrabbed)
                    {
                        Destroy(spawnedBallsList[1]);
                        spawnedBallsList.RemoveAt(1);
                    }
                }
                
            }
            else
            {
                spawnedBallsList.RemoveAt(0);
            }
        }
    }
}
