using System;
using System.Collections;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Random = UnityEngine.Random;

public class Instanciater : MonoBehaviour
{
    public Transform snowObj;
    private Vector3 snowSpawn;
    public Transform one, two, three, four, five;
    public float delayTimer;
    private int setSelect;
    void Start()
    { 
        delayTimer = 13f;
        snowSpawn.z = 9725;
        StartCoroutine(spawnHill());
    }
    private void Update()
    {
        delayTimer -= 0.1f * Time.deltaTime;
    }
    IEnumerator spawnHill()
    {
        yield return new WaitForSeconds(delayTimer);
        setSelect = Random.Range(1, 6);
        Instantiate(snowObj, snowSpawn, snowObj.rotation);
        snowSpawn.z += 9725;
        if (setSelect ==1)
        {
            Instantiate(one, snowSpawn, one.rotation);
        }

        if (setSelect ==2)
        {
            Instantiate(two, snowSpawn, two.rotation);
        }

        if (setSelect ==3)
        {
            Instantiate(three, snowSpawn, three.rotation);
        }

        if (setSelect ==4)
        {
            Instantiate(four, snowSpawn, four.rotation);
        }

        if (setSelect ==5)
        {
            Instantiate(five, snowSpawn, five.rotation);
        }
        StartCoroutine(spawnHill());
    }
}


