using System.Collections;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Instanciater : MonoBehaviour
{
    public Transform snowObj;
    private Vector3 snowSpawn;
    public Transform one, two, three, four, five;
    
    private int setSelect;
    void Start()
    {
        snowSpawn.z = 12;
        StartCoroutine(spawnHill());
    }
    IEnumerator spawnHill()
    {
        yield return new WaitForSeconds(0.5f);
        setSelect = Random.Range(1, 6);
        Instantiate(snowObj, snowSpawn, snowObj.rotation);
        snowSpawn.z += 2.4f;
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


