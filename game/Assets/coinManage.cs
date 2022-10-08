using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinManage : MonoBehaviour
{
    public int coinCount;

    // Start is called before the first frame update
    public void resetCoin()
    {
        coinCount = 0;
    }

    public void addCoin()
    {
        ++coinCount;
    }

    public int checkCoins()
    {
        return coinCount;
    }

    public void removeCoins(int by)
    {
        coinCount -= by;
    }
}
