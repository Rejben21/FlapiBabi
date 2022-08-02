using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public GameObject player;
    public Rigidbody2D playerRGBody;
    public bool hasStarted = false;

    public float jumpForce;

    public int pickUpCollected;

    public GameObject gameOverScreen;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerRGBody = player.GetComponent<Rigidbody2D>();
        UI.instance.UbdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                playerRGBody.bodyType = RigidbodyType2D.Dynamic;
                playerRGBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                hasStarted = true;
            }
        }
        else if(player == null)
        {
            gameOverScreen.SetActive(true);
            UI.instance.UbdateScore();

        }
    }
}
