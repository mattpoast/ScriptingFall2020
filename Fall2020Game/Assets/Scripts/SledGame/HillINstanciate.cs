using System.Collections;
using UnityEngine;

public class HillINstanciate : MonoBehaviour
{
    public Transform hillObj;
    private Vector3 nextHillSpawn;
    void Start()
    {
        nextHillSpawn.z = 9;
        StartCoroutine(spawnHill());
    }

    IEnumerator spawnHill()
    {
        yield return new WaitForSeconds(1);
        Instantiate(hillObj, nextHillSpawn, hillObj.rotation);
        nextHillSpawn.z += 21;
        nextHillSpawn.x += -21;
        StartCoroutine(spawnHill());
    }
}
