using UnityEngine;

public class MoveScript : MonoBehaviour {
    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(-1, 0);
	public bool isCameraFollowing = false;

	public Vector3 cameraOffset = new Vector2(0,0);

    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    void Update()
    {
        // 2 - Movement
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);

		if(isCameraFollowing) {
			Camera.main.transform.position = new Vector3(
				transform.position.x + cameraOffset.x,
				transform.position.y + cameraOffset.y,
				Camera.main.transform.position.z
			);
		}
    }

    void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // Apply movement to the rigidbody
		rigidbodyComponent.AddForce(movement);
    }
}
