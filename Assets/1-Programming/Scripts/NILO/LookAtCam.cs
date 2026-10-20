using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    Transform cachedTarget = null;
    [SerializeField] bool inverted = false;

    private void Start()
    {
        if (Camera.main != null) cachedTarget = Camera.main.transform;
    }

    private void Update()
    {
        if (cachedTarget == null) return;


        if (inverted)
        {
            Vector3 direction = transform.position - cachedTarget.position;
            transform.rotation = Quaternion.LookRotation(direction);
        }
        else
        {
            transform.LookAt(cachedTarget);
        }
    }
}
