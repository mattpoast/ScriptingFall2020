using System.Collections;
using UnityEngine;

public class HillINstanciate : MonoBehaviour
{
    public Transform hillObj;
    private Vector3 nextHillSpawn;
    void Start()
    {
        nextHillSpawn.z = 42;
        nextHillSpawn.y = -42;
        StartCoroutine(spawnHill());
    }

    IEnumerator spawnHill()
    {
        yield return new WaitForSeconds(1);
        Instantiate(hillObj, nextHillSpawn, hillObj.rotation);
        nextHillSpawn.z += 21;
        nextHillSpawn.y += -21;
        StartCoroutine(spawnHill());
    }
}
