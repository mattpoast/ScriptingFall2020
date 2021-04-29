using UnityEngine;

public class pauseScript : MonoBehaviour
{
   public GameObject pauseScreen;
      public bool gameIsPaused;
      public AudioSource pauseSong;
      public void Start()
      {
         pauseScreen.SetActive(false);
      }
      public void Update()
      {
         if (Input.GetKeyDown(KeyCode.Escape))
         {
            gameIsPaused = !gameIsPaused;
            Pause();
         }
      }
      private void Pause()
      {
         if (gameIsPaused)
         {
            Time.timeScale = 0;
   pauseScreen.SetActive(true);
   pauseSong.PlayDelayed(0.25f);
         }
         else
         {
            Time.timeScale = 1;
            pauseScreen.SetActive(false);
            pauseSong.Stop();
         }
      }
}
