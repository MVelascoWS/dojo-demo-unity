using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField]
    private float tumble;
    [SerializeField]
    private float downForce;

    private Rigidbody asteroidRB;
    void Start()
    {
        asteroidRB = GetComponent<Rigidbody>();
        asteroidRB.angularVelocity = Random.insideUnitSphere * tumble;
        asteroidRB.velocity = Vector3.down * downForce;
    }

    void Update()
    {
        asteroidRB.velocity = Vector3.down * downForce;
    }
}