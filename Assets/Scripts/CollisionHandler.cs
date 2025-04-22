using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyPlayerVFX;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(destroyPlayerVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
