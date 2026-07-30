using UnityEngine;

public class ColliderObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("OnCollisionStay");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit");
    }

}