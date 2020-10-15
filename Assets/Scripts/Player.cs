using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rig;
    public float jumpForce;
    public SpriteRenderer sr;
    static int score; // declare as static to carry score between scenes
    [SerializeField] public static int Lives = 3; //
    public UI ui;

    void Start()
    {
        // AddScore(0); //refresh score from previous Level scene
    }
    void FixedUpdate() //call every 0.02 secs for sprite physics
    {
        float xInput = Input.GetAxis("Horizontal");

        rig.velocity = new Vector2(xInput * moveSpeed, rig.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded())
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if(rig.velocity.x > 0) // moving right?
        {
            sr.flipX = false;
        }
        else if(rig.velocity.x < 0) // moving left?
        {
            sr.flipX = true; // flip it good
        }

        if (transform.position.y < -3) // fallen below ground
        {
            GameOver();
        }
    
    }

    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0, -0.1f, 0), Vector2.down, 0.2f);
        return hit.collider != null;
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SubLives(1);
    }

    public void AddScore(int amount)
    {
        score += amount;
        ui.SetScoreText(score);
    }

    public void SubLives(int amount)
    {
        Lives -= amount;
        ui.SetLivesText(Lives);
    }

    public int GetScore()
    {
         return score;
    }

    public void NextLevelScore(int amount)
    {
        score = amount;
        ui.SetScoreText(score);
    }
}
