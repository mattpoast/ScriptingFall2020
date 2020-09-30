using System.Collections;
using UnityEngine;

public class WallImitter : MonoBehaviour
{
    public GameObject preFab;
    public float delay = 5f;

    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(preFab);
            yield return new WaitForSeconds(delay);
        }
    }
}
