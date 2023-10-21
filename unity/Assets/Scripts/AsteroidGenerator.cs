using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] asteroids;
    public Transform[] spawnPoints;
    void StartGame()
    {
        InvokeRepeating("Spawn", 0, 2f);
    }

    public void Spawn()
    {
        Instantiate(asteroids[Random.Range(0, asteroids.Length)],
                    spawnPoints[Random.Range(0, spawnPoints.Length)].position,
                    Quaternion.identity);

    }
}
