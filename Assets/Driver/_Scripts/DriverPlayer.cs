using UnityEngine;

public class DriverPlayer : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 0.1f;
    [SerializeField] private float _moveSpeed = 0.01f;

    private void Update()
    {
        MoveForwardBy(_moveSpeed);
        RotateBy(_rotateSpeed);
    }

    private void SetRotation(Quaternion newRotation) { transform.rotation = newRotation; }
    private void RotateBy(float amount)
    {
        transform.Rotate(0, 0, amount);
    }
    private void MoveForwardBy(float amount)
    {
        transform.Translate(Vector3.up * amount);
    }

}