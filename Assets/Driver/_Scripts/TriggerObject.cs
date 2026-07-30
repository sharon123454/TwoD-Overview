using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OnTriggerStay");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OnTriggerExit");
    }

}