using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    public Transform hourHand;  // Refer�ncia ao transform do ponteiro das horas
    public Transform minuteHand;  // Refer�ncia ao transform do ponteiro dos minutos
    public Transform secondHand;  // Refer�ncia ao transform do ponteiro dos segundos

    // Atualiza a posi��o dos ponteiros a cada frame
    void Update()
    {
        // Obt�m o tempo atual
        System.DateTime currentTime = System.DateTime.Now;

        // Calcula os �ngulos de rota��o para cada ponteiro
        float hours = currentTime.Hour % 12 + currentTime.Minute / 60f; // Hora em formato de 12 horas
        float minutes = currentTime.Minute + currentTime.Second / 60f;
        float seconds = currentTime.Second;

        // Aplica as rota��es aos ponteiros
        hourHand.localRotation = Quaternion.Euler(hours * 30f, 0, 0); // 360 graus / 12 horas = 30 graus por hora
        minuteHand.localRotation = Quaternion.Euler(minutes * 6f, 0, 0); // 360 graus / 60 minutos = 6 graus por minuto
        secondHand.localRotation = Quaternion.Euler(seconds * 6f, 0, 0); // 360 graus / 60 segundos = 6 graus por segundo
    }
}
