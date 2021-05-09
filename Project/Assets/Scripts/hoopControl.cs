using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoopControl : MonoBehaviour
{
    public static float score=0;
    public TextMesh scoreText;
    public ParticleSystem expPrefab;
    public GameObject scripts;

    private ParticleSystem exp;


    private void OnCollisionEnter(Collision collision)
    {
        if(!exp)
        {
            exp = Instantiate(expPrefab, collision.gameObject.GetComponent<Rigidbody>().position, Quaternion.identity);
        }
        if(exp)
        {
            Audio audio = scripts.GetComponent<Audio>();
            audio.explosionSound();
            exp.transform.position = collision.gameObject.GetComponent<Rigidbody>().position;
            exp.Play();
        }
        

        Destroy(collision.gameObject);
        if(Timer.startTimer)
        {
            if (MoveHoop.move)
            {
                score += 1.0f;
            }
            else
            {
                score += 0.5f;
            }
        }
        
        scoreText.text = score.ToString();
    }

    public static void Reset()
    {
        score = 0;
    }
}
