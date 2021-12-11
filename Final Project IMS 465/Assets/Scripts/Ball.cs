using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject owningPlayer;
    [SerializeField] private Rigidbody ballRB;

    // Start is called before the first frame update
    void Start()
    {
        owningPlayer = null;
        Debug.Log("Ball Start Called");
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (owningPlayer == null)
        {
            if (collision.gameObject.tag == "Player1")
            {
                owningPlayer = collision.gameObject;
                owningPlayer.GetComponent<PlayerController>().HoldBall(this.gameObject);
            }
            if (collision.gameObject.tag == "Player2")
            {
                owningPlayer = collision.gameObject;
                owningPlayer.GetComponent<PlayerController>().HoldBall(this.gameObject);
            }
        }
    }
}
