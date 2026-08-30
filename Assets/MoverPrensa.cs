using UnityEngine;

public class MoverPrensa : MonoBehaviour
{
    // Ángulo máximo al que bajará la palanca (90 grados)
    public float anguloMaximo = 90f;
    
    // Velocidad con la que oscila el movimiento
    public float velocidadCiclo = 2f;

    // Guarda la rotación inicial del objeto
    private Quaternion rotacionInicial;

    void Start()
    {
        rotacionInicial = transform.localRotation;
    }

    void Update()
    {
        // Calcula un valor oscilante entre 0 y 1 usando el tiempo
        float ciclo = Mathf.Sin(Time.time * velocidadCiclo);
        
        // Mapea el ciclo para que vaya de 0 a anguloMaximo (baja y sube)
        float anguloActual = ((ciclo + 1f) / 2f) * anguloMaximo;

        // Aplica la rotación en el eje X local (puedes cambiar 'Vector3.right' por 'Vector3.up' o 'Vector3.forward' según el eje que necesites)
        transform.localRotation = rotacionInicial * Quaternion.Euler(0f,-anguloActual,0f);
    }
}