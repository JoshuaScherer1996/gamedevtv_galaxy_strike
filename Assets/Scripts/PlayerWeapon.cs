using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{

    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crosshair;
    private bool isFiring = false;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        ProcessFiring();
        MoveCrosshair();
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    private void ProcessFiring()
    {
        foreach (GameObject laser in lasers)
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isFiring;
        }
    }

    private void MoveCrosshair()
    {
        crosshair.position = Input.mousePosition;
    }
}
