using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.InputSystem;


public class DispararJugador : MonoBehaviour //el script se encuentra en el gameobject "Jugador"
{
    private Rigidbody2D rb;
    private float dif = 1f; //direrencia de posicion
    private float ultimadir = 1f;

    private AnimarJugador jugadorAnimacion;

    private float tiempoEspera = 1f; //para evitar disparos consecutivos
    private float proximoDisparo;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        jugadorAnimacion = GetComponent<AnimarJugador>();
    }

    private void FixedUpdate()
    {
        float moverX = rb.linearVelocity.x;

        if (moverX > dif)
        {
            ultimadir = 1f;
        }
        else if (moverX < -dif)
        {
            ultimadir = -1f;
        }
    }
    private void Update()
    {
        if (Time.unscaledTime < proximoDisparo)//el tiempo de espera sigue avanzando aun estando en pausa
            return;

        if (Keyboard.current.leftCtrlKey.wasPressedThisFrame ||
            Keyboard.current.rightCtrlKey.wasPressedThisFrame) //dispara al presionar la tecla Ctrl
        {
            jugadorAnimacion.AnimarDisparo();//ejecuta la animacion

            Disparar();//dispara el elemto correspondiente

            proximoDisparo = Time.unscaledTime + tiempoEspera;//inicia la espera para el sig disparo
        }
    }

    public void Disparar()
    {
        if (PoolElementos.Instance.ElementoNoElegido()) //si no se asigno el tipo de elemto entonce retorna 
            return;

        GameObject poolElemento = PoolElementos.Instance.AsignarPosicionElemento(transform); //le asigna la posicion al elemento

        if (poolElemento == null) 
            return;
           

        IElemento elemento = poolElemento.GetComponent<IElemento>();

        elemento.MovimientoElemento(ultimadir); //le envia la direccion a la cual moverse
    }
}
