using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerCoaster : MonoBehaviour
{
    public GameObject[] waypoints;

    public Vector3[] vectors; // array to hold vectors from CSV file


    // parameters from waypoint tutorial
    int current = 0;
    public float rotSpeed = 50;
    public float speed = 8;
    float WPradius = 1;
    public Acelerar acelerar;
    void Start()
    {
    }

    void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        Vector3 targetDir = waypoints[current].transform.position - transform.position;
        targetDir.y = 0.0f;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(targetDir), Time.deltaTime * rotSpeed);
        Debug.Log(targetDir);
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * acelerar.Velocidad());

    }
}
