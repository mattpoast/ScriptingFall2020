using System.Collections;
using UnityEngine;

public class Obsticles : MonoBehaviour
{
    public GameObject tree;
    public GameObject skis;
    public float delay = 5f;
    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(tree);
            yield return new WaitForSeconds(delay);
        }
    }
}
