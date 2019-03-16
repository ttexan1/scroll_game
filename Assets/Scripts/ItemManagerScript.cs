using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemManagerScript : MonoBehaviour
{
    int item1;
    int item2;
    int coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Item1Button()
    {
        if (coin >= 10) {
            coin -= 10;
            item1 += 1;
        }
    }

    public void Item2Button()
    {
        if (coin >= 20)
        {
            coin -= 20;
            item2 += 1;
        }
    }

}
