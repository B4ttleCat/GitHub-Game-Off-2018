using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private bool _canMove;
	[SerializeField] private float _moveSpeed;

	private void Start()
	{
		_canMove = true;
	}

	private void Update()
	{
		if (_canMove)
		{
			var moveY = Input.GetAxisRaw("Vertical") * _moveSpeed * Time.deltaTime;
			transform.position = new Vector2(transform.position.x, transform.position.y + moveY);
		}
	}
}