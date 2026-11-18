
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    private Image barraLlena;

    private float vidaMaxima = 100f;
    private float vidaMinima = 25f;
    private float vidaActual = 100f;

    private Pantallas pantalla;

    private void Start()
    {
        barraLlena = transform.Find("Completa").GetComponent<Image>();

        pantalla = GameObject.Find("Pantallas")?.GetComponent<Pantallas>();

        // Inicializa visualmente la barra con la vida actual.
        ActualizarBarra();
    }

    public void Disminuir()
    {
        float daño = 10f;

        vidaActual = Mathf.Clamp(vidaActual - daño, vidaMinima, vidaMaxima);

        ActualizarBarra();

        if (vidaActual <= vidaMinima)
        {
            pantalla?.PantallaDerrota();
        }
    }

    public float VidaActual()
    {
        return vidaActual;
    }

    // Restaura la vida guardada al regresar de la Mesa de Trabajo.
    public void CargarVidaGuardada(float nuevaVida)
    {
        vidaActual = Mathf.Clamp(nuevaVida, vidaMinima, vidaMaxima);

        ActualizarBarra();
    }

    private void ActualizarBarra()
    {
        if (barraLlena != null)
        {
            barraLlena.fillAmount = vidaActual / vidaMaxima;
        }
    }
}
