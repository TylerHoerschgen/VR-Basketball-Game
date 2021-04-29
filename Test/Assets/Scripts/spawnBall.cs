using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBall : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    public void generateBall()
    {
        GameObject createdBall = Instantiate(ball);

        createdBall.transform.position = new Vector3(-2.487f, 1.627f, 2.96f);
        createdBall.GetComponent<Rigidbody>().AddForce(new Vector3(9.0f, 5.0f, -10.0f), ForceMode.Impulse);
    }

    public void Update()
    {
        
    }
}
