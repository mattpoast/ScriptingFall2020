using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneZero : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(0);
    }
}
