using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoopControl : MonoBehaviour
{
    public float score=0;
    public TextMesh scoreText;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collison");
        Destroy(collision.gameObject);
        score+=0.5f;
        scoreText.text = "Score:" + score.ToString();
    }
}
