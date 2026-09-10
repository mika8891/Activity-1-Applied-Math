using UnityEngine;

public class FinishZone : MonoBehaviour
{
    public Transform player;
    public GameObject winPanel;
    public float winRadius = 1.5f;

    void Update()
    {
        if (player == null || winPanel == null) return;

        Vector2 playerPos2D = player.position;
        Vector2 zonePos2D = transform.position;
        float sqrDist = (playerPos2D - zonePos2D).sqrMagnitude;

        if (sqrDist <= winRadius * winRadius)
        {
            winPanel.SetActive(true);
        }
    }
}
