using DigitalWorlds.StarterPackage2D;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 2f;
    void Update()
    {
        transform.Rotate(Vector3.forward* rotationSpeed * Time.deltaTime);
    }
}
