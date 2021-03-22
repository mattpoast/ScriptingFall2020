using UnityEngine;
using Random = UnityEngine.Random;
public class MovingObstacel : MonoBehaviour
{
    public Vector3 randomSpeed;
    private bool changer = true;
   private void Start()
   {
       randomSpeed.x = Random.Range(.1f,1f);
   }
   private void Update()
   {
       if (changer)
       {
           moveRight();
       }
       if (!changer)
       {
           moveLeft();
       }
       if (transform.position.x >= .3f)
       {
           changer = false;
       }
       if (transform.position.x <= -.3f)
       {
           changer = true;
       }
   }
   void moveRight()
   {
       transform.Translate(randomSpeed*Time.deltaTime);
   }
   void moveLeft()
   {
       transform.Translate(-randomSpeed*Time.deltaTime);
   }
}
   

