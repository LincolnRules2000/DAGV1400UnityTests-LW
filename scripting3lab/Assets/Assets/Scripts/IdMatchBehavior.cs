using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class IdMatchBehavior : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var otherId = other.GetComponent<SimpleIDBehavior>();

        if (otherId.id == id)
        {
            matchEvent.Invoke();
            Destroy(other.gameObject);
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}
