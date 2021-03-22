using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public GameObject coin;
    public int coinScore;

    private void OnTriggerEnter(Collider other)
    {
        coinScore = +1;
        Destroy(coin);
        print(coinScore);
    }
}
