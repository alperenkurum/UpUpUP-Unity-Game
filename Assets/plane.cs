using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public Rigidbody2D planeBody;
    public float velocityStrength;
    public LogicScript logic;
    public bool planeCrashed = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && planeCrashed == false)
        {
            planeBody.velocity = Vector2.up * velocityStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOverScreen.SetActive(true);
        planeCrashed = true;
        Time.timeScale = 0;

    }
}
