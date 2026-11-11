using UnityEngine;
using UnityEngine.UI;

public class indicator : MonoBehaviour
{
    public RawImage hand;
    public RawImage chest;

    private void Start()
    {
        hand.enabled = false;
        chest.enabled = false;
    }

    public void showHand(bool show)
    {
        if (show)
        {
            hand.enabled = true;
            chest.enabled = false;
        }
        else
        {
            hand.enabled = false;
        }
    }

    public void showChest(bool show)
    {
        if (show)
        {
            hand.enabled = false;
            chest.enabled = true;
        }
        else
        {
            chest.enabled = false;
        }
    }
}
