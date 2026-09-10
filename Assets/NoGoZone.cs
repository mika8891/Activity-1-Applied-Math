using UnityEngine;

public class NoGoZone : MonoBehaviour
{
    public Transform player;
    public float warningRadius = 3.0f;
    public float dangerRadius = 1.0f;
    private Vector2 startPos; 
    private SpriteRenderer spriteRenderer;
    void Start() 
    { 
        startPos = transform.position; 
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (player == null) return;

        // position subtraction
        Vector2 playerPos2D = player.position;
        float sqrDist = (playerPos2D - startPos).sqrMagnitude;

        if (sqrDist <= dangerRadius * dangerRadius)
        {
            // Teleports to startpos
            player.position = new Vector3( -7.86f, 0f, 0f); 
        }
        else if (sqrDist <= warningRadius * warningRadius)
        {
            spriteRenderer.color = Color.red;
            
            // shake effect
            Vector2 shake = Random.insideUnitCircle * 0.1f;
            transform.position = new Vector3(startPos.x + shake.x, startPos.y + shake.y, 0f);
        }
        else
        {
            spriteRenderer.color = Color.white;
            transform.position = new Vector3(startPos.x, startPos.y, 0f);
        }
    }
}

