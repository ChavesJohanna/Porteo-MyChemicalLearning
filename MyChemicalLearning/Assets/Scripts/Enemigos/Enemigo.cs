using System.Collections;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] protected float vida = 10f;
    [SerializeField] protected string debilidad;

    protected Animator animator;

    protected virtual void Start()
    {
        animator = GetComponent<Animator>();
    }

    public virtual void RecibirDano(float dano, string elemento)
    {
        if (elemento == debilidad)
        {
            dano *= 2f;
        }

        vida -= dano;

        if (vida <= 0)
        {
            Morir();
        }
    }

    protected void DanarJugador()
    {
        BarraVida barraVida = GameObject.Find("BarraVida")?.GetComponent<BarraVida>();

        if (barraVida != null)
        {
            //barraVida.Disminuir(da�oJugador);
            barraVida.Disminuir();
        }
    }

    protected virtual void Morir()
    {
        AudioManager.Instance.ReproducirMuerteEnemigo();

        StartCoroutine(AnimacionMuerte());
    }

    protected virtual IEnumerator AnimacionMuerte()
    {
        animator.SetBool("MurioPirito", true);

        yield return new WaitForSeconds(0.2f);

        gameObject.SetActive(false);
    }
}