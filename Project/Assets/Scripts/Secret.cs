using UnityEngine;

public class Secret : MonoBehaviour
{
    public static float score = 0;
    public TextMesh scoreText;
    public ParticleSystem expPrefab;
    public GameObject scripts;

    private ParticleSystem exp;


    private void OnCollisionEnter(Collision collision)
    {
        if (!exp)
        {
            exp = Instantiate(expPrefab, collision.gameObject.GetComponent<Rigidbody>().position, Quaternion.identity);
        }
        if (exp)
        {
            Audio audio = scripts.GetComponent<Audio>();
            audio.otherExplosionSound();
            audio.louder();
            exp.transform.position = collision.gameObject.GetComponent<Rigidbody>().position;
            exp.Play();
        }


        Destroy(collision.gameObject);
        if (Timer.startTimer)
        {
            score += 1.5f;
        }

        scoreText.text = score.ToString();
    }

    public static void Reset()
    {
        score = 0;
    }
}
