using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public SpriteRenderer sR;
    public Sprite avocado, bacon, banana, chocolate, cookie, doughnut, drink, eggplant, fries, hamburger, martini, olive, onion, pancakes, pizza, spaghetti;
    private float number;
    public GameObject player;
    public Animator playerAnim;
    private float distanceToPlayer;

    // Start is called before the first frame update
    void Start()
    {
        number = Random.Range(1, 17);
        sR = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        if(player != null)
        {
            playerAnim = player.GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(number == 1)
        {
            sR.sprite = avocado;
        }
        else if(number == 2)
        {
            sR.sprite = bacon;
        }
        else if (number == 3)
        {
            sR.sprite = banana;
        }
        else if (number == 4)
        {
            sR.sprite = chocolate;
        }
        else if (number == 5)
        {
            sR.sprite = cookie;
        }
        else if (number == 6)
        {
            sR.sprite = doughnut;
        }
        else if (number == 7)
        {
            sR.sprite = drink;
        }
        else if (number == 8)
        {
            sR.sprite = eggplant;
        }
        else if (number == 9)
        {
            sR.sprite = fries;
        }
        else if (number == 10)
        {
            sR.sprite = hamburger;
        }
        else if (number == 11)
        {
            sR.sprite = martini;
        }
        else if (number == 12)
        {
            sR.sprite = olive;
        }
        else if (number == 13)
        {
            sR.sprite = onion;
        }
        else if (number == 14)
        {
            sR.sprite = pancakes;
        }
        else if (number == 15)
        {
            sR.sprite = pizza;
        }
        else if (number == 16)
        {
            sR.sprite = spaghetti;
        }

        if (player != null)
        {
            distanceToPlayer = Mathf.Abs(transform.position.x - player.transform.position.x);

            if (distanceToPlayer <= 1.2f)
            {
                playerAnim.Play("BabiEatAnim");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            LevelManager.instance.pickUpCollected++;
            UI.instance.UbdateScore();
            Destroy(this.gameObject, 0.2f);
        }
    }
}
