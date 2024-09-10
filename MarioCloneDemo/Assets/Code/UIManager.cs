using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private TextMeshProUGUI coinText;
    private int coinCount;
    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }

    public void UpdateCointext(int coinValue)
    {
        coinCount += coinValue;
        coinText.text = "x" + coinCount;
    }
}
