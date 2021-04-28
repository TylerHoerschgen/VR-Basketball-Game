using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject parent;
    

    // Start is called before the first frame update
    void Start()
    {
        GenerateBall();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void GenerateBall()
    {
        var ball = Instantiate(ballPrefab);
    }
}
