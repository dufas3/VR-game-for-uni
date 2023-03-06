using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    public GameObject GenTrash;
    public GameObject RecTrash;
    public GameObject GreTrash;

    void Start()
    {
        StartCoroutine(randomGentrash());
        StartCoroutine(randomGretrash());
        StartCoroutine(randomRectrash());
    }

    private IEnumerator randomGentrash()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0, 10));
            Instantiate(GenTrash, transform.position, transform.rotation);
        }
    }
    private IEnumerator randomRectrash()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0, 10));
            Instantiate(RecTrash, transform.position, transform.rotation);
        }
    }
    private IEnumerator randomGretrash()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0, 10));
            Instantiate(GreTrash, transform.position, transform.rotation);
        }
    }
}
