using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glider2 : MonoBehaviour
{

    public bool goingRight;
    public float speed;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = goingRight ? 1f : -1f;

        transform.position += new Vector3(
            direction * speed * Time.deltaTime,
            -speed * Time.deltaTime,
            0
        );
    }
}
