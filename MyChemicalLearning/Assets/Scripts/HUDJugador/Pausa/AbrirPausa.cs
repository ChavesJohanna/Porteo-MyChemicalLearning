using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class AbrirPausa : MonoBehaviour, IPointerDownHandler //el script se encuntra en el boton Abrir dentro del objeto Pausa
{
    private Pausa pausa;

    private void Start()
    {
        pausa = GetComponentInParent<Pausa>(); //obtiene el componente del padre
    }

    public void OnPointerDown(PointerEventData eventData) //se ejecuta al tocar el boton
    {
        AudioManager.Instance.ReproducirBotonPausa();
        pausa.AbrirPausa(); //mestra el panel de pausa
    }
    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame) //Abre al presionar el Esc
        {
            pausa.AbrirPausa();
        }
    }
}
