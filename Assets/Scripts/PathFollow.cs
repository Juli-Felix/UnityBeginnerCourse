using System.Collections;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    [SerializeField] int xPos = 22;
    [SerializeField] int zPos = -6;
    [SerializeField] GameObject destination;
    [SerializeField] int position = 1;
    [SerializeField] bool resetMove = false;


    void Start()
    {
        resetMove = true;
        destination.transform.position = new Vector3(xPos, 1, zPos);
        position += 1;
        StartCoroutine(NextDestination());
    }


    void Update()
    {
        transform.LookAt(destination.transform);
        transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, 0.01f);
        if (resetMove == false)
        {
            resetMove = true;
            StartCoroutine(NextDestination());
        }
    }


    IEnumerator NextDestination()
    {
        if (position == 1)
        {
            yield return new WaitForSeconds(2);
            xPos = 22;
            zPos = -6;
            destination.transform.position = new Vector3(xPos, 2, zPos);
            position = 1;
            resetMove = false;
        }
        if (position == 2)
        {
            yield return new WaitForSeconds(2);
            xPos = 16;
            zPos = -6;
            destination.transform.position = new Vector3(xPos, 2, zPos);
            position += 1;
            resetMove = false;
        }
        if (position == 3)
        {
            yield return new WaitForSeconds(2);
            xPos = 20;
            zPos = 0;
            destination.transform.position = new Vector3(xPos, 2, zPos);
            position = 1;
            resetMove = false;
        }
    }
}
