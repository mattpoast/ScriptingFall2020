using UnityEngine;

public class ChairGas : MonoBehaviour
{
   public float gas = 5f;
   public Vector3 gasBaby;
   public void Update()
   {
    transform.Translate(gasBaby);
    gasBaby.z = gas * Time.deltaTime;

   }
}
