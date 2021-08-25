using UnityEngine;
using Random = UnityEngine.Random;
public class WaterMelon : MonoBehaviour
{
    public Animator waterMelonAnimator;
    public bool idleOnePlaying;
    public float idleOneTime;
    public float idleOneCounter;
    public float idleTwoTime;
    public float idleTwoCounter;
    public int idleChoice;
    private void Start()
    {
        waterMelonAnimator = GetComponent<Animator>();
        idleOneCounter = 2f;
        idleTwoCounter = idleTwoTime;
        ChooseIdle();
        RandomTwo();
        RandomizeYRotation();
    }
    void RandomizeYRotation()
    {
        Quaternion randYRotation = Quaternion.Euler(0, Random.Range(-95, -141), 0);
        transform.rotation = randYRotation;
    }
    private void Update()
    {
        if (idleOnePlaying)
        {
            idleOneCounter -= Time.deltaTime;
            switch (idleChoice)
            {
                case 0 : waterMelonAnimator.SetBool("IdleOnePlaying",true);
                    break;
                case 1 : waterMelonAnimator.SetBool("IdleOnePlaying",true);
                    break;
                case 2 : waterMelonAnimator.SetBool("IdleOnePlaying",true);
                    break;
                case 3 : waterMelonAnimator.SetBool("IdleOnePlaying",false);
                    break;
            }
            if (idleOneCounter <= 0)
            {
                RandomTwo();
                idleOnePlaying = false;
                idleTwoCounter = idleTwoTime;
            }
        }
        else
        {
            idleTwoCounter -= Time.deltaTime;
            if (idleTwoCounter <= 0)
            {
                ChooseIdle();
            }
        }
    }
    public void ChooseIdle()
    {
        idleChoice = Random.Range(0,4);
        idleOnePlaying = true;
        RandomOne();
        idleOneCounter = idleOneTime;
    }
    public void RandomOne()
    {
        idleOneTime = Random.Range(2f, 6f);
    }
    public void RandomTwo()
    {
        idleTwoTime = Random.Range(2f, 3f);
    }
}

