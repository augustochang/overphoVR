using UnityEngine;

public class SpidermanCircularMovement : MonoBehaviour
{
    public float radius = 5f; // Radius of the circular path
    public float speed = 2f; // Speed of movement

    private Vector3 center; // Center of the circle
    private float angle; // Angle used to calculate the position on the circle

    private void Start()
    {
        // Set the center of the circle to the initial position of the Spiderman object
        center = transform.position;
    }

    private void Update()
    {
        // Calculate the new position of the Spiderman object on the circle
        angle += speed * Time.deltaTime;
        float x = Mathf.Cos(angle) * radius;
        float y = transform.position.y;
        float z = Mathf.Sin(angle) * radius;
        transform.position = center + new Vector3(x, y, z);
    }
}
