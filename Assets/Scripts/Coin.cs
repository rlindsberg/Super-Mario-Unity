using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
 
    private void OnCollisionEnter(Collision collision)
    {
        //name of component we look for
        var coinScript = collision.gameObject.GetComponent<CoinCollector>();

        if (coinScript != null)
        {
            coinScript.AddPoint(coinValue);
            Destroy(gameObject);
        }
    }
    
}
