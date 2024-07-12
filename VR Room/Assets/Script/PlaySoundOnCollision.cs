using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    public AudioClip collisionSound; // O �udio a ser reproduzido
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (collisionSound != null)
        {
            audioSource.clip = collisionSound;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica se a colis�o � com a bola
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (audioSource != null && collisionSound != null)
            {
                audioSource.Play();
            }
        }
    }
}
