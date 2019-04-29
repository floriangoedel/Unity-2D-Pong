using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Input Eingabe auf der vertikalen Axe
        float vertical = Input.GetAxisRaw("Vertical") * speed;
        
        // Geschwindigkeit des Schlägers
        rb.velocity = new Vector2(0, vertical);
    }
    
}
