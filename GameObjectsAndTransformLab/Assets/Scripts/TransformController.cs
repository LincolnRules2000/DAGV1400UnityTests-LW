using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        //Move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var z = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(x, z, 0);
        transform.position = p;

        //Rotate the target GameObject
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
    }
}
