using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 2.0f;
    GameObject camera;
    const string Camera = "Camera";
    int coinCount;
    public Text coinText;

    void Start()
    {
        camera = transform.Find(Camera).gameObject;
        Debug.Log(camera);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(1 * speed*Time.deltaTime, 0, 0);
        Move();
    }

    void Move()
    {
        if (Input.GetKey("up"))
        {
            this.transform.position += new Vector3(0, 0.1f, 0);
            camera.transform.position -= new Vector3(0, 0.1f, 0);
        }
        if (Input.GetKey("down"))
        {
            this.transform.position += new Vector3(0, -0.1f, 0);
            camera.transform.position -= new Vector3(0, -0.1f, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            coinCount++;
            DisplayCoin();
        }
        if (collision.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("coinCount", coinCount);
            SceneManager.LoadScene("ResultScene");
        }
    }

    void DisplayCoin()
    {
        coinText.text = coinCount.ToString();
    }
}
