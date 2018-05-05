using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 15f;
    [SerializeField]
    private float mapWidth = 5f;

    private Rigidbody2D rigidbody;
    private GameManager gameManager;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * moveSpeed;

        Vector2 newPosition = rigidbody.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rigidbody.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.EndGame();
    }
}