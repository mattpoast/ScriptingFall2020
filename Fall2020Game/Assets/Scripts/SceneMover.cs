using UnityEngine;

public class SceneMover : MonoBehaviour
{
    public GameObject scene;
    public float speed = 5f;
    private void OnMouseDown()
    {
        scene.transform.Rotate(0,0,180 * Time.deltaTime * speed);
    }
    
}
