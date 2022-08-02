using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public float timeToSpawn;
    public float time;
    public bool startSpawn = false;

    public GameObject player;

    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(LevelManager.instance.hasStarted == true)
        {
            startSpawn = true;
        }

        if(startSpawn == true)
        {
            if(time >= timeToSpawn)
            {
                Instantiate(obstacle, new Vector2(11, Random.Range(-2.5f, 2.5f)), Quaternion.identity);
                time = 0;
            }
        }

        if(player == null)
        {
            startSpawn = false;
        }
    }
}
