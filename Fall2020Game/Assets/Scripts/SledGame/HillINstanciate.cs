using System.Collections;
using UnityEngine;

public class HillINstanciate : MonoBehaviour
{
    public Transform hillObj;
    private Vector3 nextHillSpawn;
    public Transform treeObj;
    private Vector3 nextTreeSpawn;
    private int randX;
    void Start()
    {
        nextHillSpawn.z = 42;
        StartCoroutine(spawnHill());
    }

    IEnumerator spawnHill()
    {
        yield return new WaitForSeconds(1);
        randX = Random.Range(-10, 11);
        nextTreeSpawn = nextHillSpawn;
        nextTreeSpawn.x = randX;
        Instantiate(hillObj, nextHillSpawn, hillObj.rotation);
        Instantiate(treeObj, nextTreeSpawn, treeObj.rotation);
        nextHillSpawn.z += 21;
        StartCoroutine(spawnHill());
    }
}
