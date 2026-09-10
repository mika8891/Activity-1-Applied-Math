using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        Vector2 input = Vector2.zero;
        if (Keyboard.current != null) input = new Vector2(Keyboard.current.dKey.isPressed ? 1 : (Keyboard.current.aKey.isPressed ? -1 : 0), Keyboard.current.wKey.isPressed ? 1 : (Keyboard.current.sKey.isPressed ? -1 : 0));

        transform.position += new Vector3(input.x, input.y, 0) * speed * Time.deltaTime;
    }
}

