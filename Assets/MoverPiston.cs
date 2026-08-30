using UnityEngine;

public class MoverPiston : MonoBehaviour
{
    // Distancia máxima que bajará el émbolo (en unidades de Unity)
    public float distanciaMaxima = 0.05f; // Ajusta este valor según el tamaño de tu modelo
    
    // Velocidad del ciclo (debe ser la misma que la palanca para que vayan sincronizados)
    public float velocidadCiclo = 2f;

    // Guarda la posición inicial del émbolo
    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.localPosition;
    }

    void Update()
    {
        // Calcula un valor oscilante sincronizado
        float ciclo = Mathf.Sin(Time.time * velocidadCiclo);
        
        // Mapea el ciclo para que vaya de 0 a distanciaMaxima (baja y sube)
        float desplazamientoActual = ((ciclo + 1f) / 2f) * distanciaMaxima;

        // Mueve el émbolo hacia abajo en su eje vertical local (restando en Y)
        transform.localPosition = posicionInicial - new Vector3(0f,0f,desplazamientoActual);
    }
}