using System.Collections;
using UnityEngine;

public class TreeINstanciate : MonoBehaviour
{
    public Transform tree;
    public Vector3 treePlacement;

    IEnumerator spawnTree()
    {
        yield return new WaitForSeconds(3);
        Instantiate(tree, treePlacement, tree.rotation);
    }
}
