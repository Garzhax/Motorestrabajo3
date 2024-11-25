using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento
    public CharacterController controller; // Referencia al componente CharacterController

    void Start()
    {
        // Obtén el CharacterController adjunto al jugador
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Capturar las teclas de movimiento
        float horizontal = Input.GetAxis("Horizontal"); // Movimiento izquierda/derecha (A/D)
        float vertical = Input.GetAxis("Vertical");     // Movimiento adelante/atrás (W/S)

        // Crear el vector de movimiento basado en la entrada del usuario
        Vector3 move = transform.right * horizontal + transform.forward * vertical;

        // Aplicar el movimiento usando el CharacterController
        controller.Move(move * speed * Time.deltaTime);
    }
}
