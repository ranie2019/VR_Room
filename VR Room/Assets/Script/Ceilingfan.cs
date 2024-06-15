using UnityEngine;

public class CeilingFan : MonoBehaviour
{
    // Velocidade de rota��o da h�lice em graus por segundo.
    [Tooltip("Velocidade de rota��o da h�lice em graus por segundo.")]
    public float rotationSpeed = 360.0f;

    void Update()
    {
        // Chama o m�todo para girar a h�lice a cada frame.
        RotateBlades();
    }

    // M�todo respons�vel por calcular e aplicar a rota��o da h�lice.
    private void RotateBlades()
    {
        // Calcula a rota��o a ser aplicada na h�lice com base na velocidade e no tempo decorrido.
        float rotationAmount = rotationSpeed * Time.deltaTime;

        // Aplica a rota��o � h�lice ao redor do eixo Y.
        transform.Rotate(Vector3.up, rotationAmount);
    }
}
