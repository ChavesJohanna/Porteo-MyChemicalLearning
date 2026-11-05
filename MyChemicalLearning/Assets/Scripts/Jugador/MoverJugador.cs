using UnityEngine;
using UnityEngine.InputSystem;

public class MoverJugador : MonoBehaviour//el script se encuentra en el jugador
{
    private Rigidbody2D rb;

    private float velocidad = 4f;
    private float fuerza = 8.5f;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float direccion = 0;

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)//si presiona la A o <- lo mueve ala izquierda
            direccion = -1;

        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)//si presiona la D o -> lo mueve ala derecha
            direccion = 1;

        rb.linearVelocity = new Vector2(direccion * velocidad, rb.linearVelocity.y);

    }
    private void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame || Keyboard.current.spaceKey.wasPressedThisFrame || Keyboard.current.upArrowKey.wasPressedThisFrame)//si presiona la W o Space salta
            Saltar();      
    }

    private void Saltar()
    {
        LayerMask piso = LayerMask.GetMask("Piso"); //el nombre del Layer en que se encuntran las plataformas del mapa

        RaycastHit2D golpe = Physics2D.Raycast(rb.position, Vector2.down, 1.5f, piso); //lanza un raycast hacia el piso

        Debug.DrawRay(rb.position, Vector2.down * 1.5f, Color.red); //si no está tocando el piso, no puede saltar

        if (!golpe) return;

        rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerza);
    }
}
