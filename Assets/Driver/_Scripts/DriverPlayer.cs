using UnityEngine;

public class DriverPlayer : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _rotateSpeed = 200f;

    private void FixedUpdate()
    {
        MoveForwardBy(Input.GetAxis("Vertical"));
        RotateBy(Input.GetAxis("Horizontal"));
    }

    private void RotateBy(float direction)
    {
        transform.Rotate(0, 0, -direction * _rotateSpeed * Time.deltaTime);
    }
    private void MoveForwardBy(float direction)
    {
        transform.Translate(Vector3.up * direction * _moveSpeed * Time.deltaTime);
    }

}