using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    void Update()
    {
        Reset();
    }

    public void Reset()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
