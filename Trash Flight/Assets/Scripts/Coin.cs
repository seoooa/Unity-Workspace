using UnityEngine;

public class Coin : MonoBehaviour
{

    private float minY = -7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Jump();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= minY) {
            Destroy(gameObject);
        }
    }

    void Jump() {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();

        float randomJumpForce = Random.Range(4f, 8f); //4 ~ 8 사이 실수
        Vector2 jumpVelocity = Vector2.up * randomJumpForce;
        jumpVelocity.x = Random.Range(-2f, 2f);

        rigidBody.AddForce(jumpVelocity, ForceMode2D.Impulse); // 힘을 어느 방향으로 얼마나 줄지
    }
}
