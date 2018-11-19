using UnityEngine;
using UnityEngine.Serialization;

public class Projectile : MonoBehaviour
{
	private float _baseSpeed = 1f;
	[SerializeField] private float _speedMultiplier;

	private void Update()
	{
		transform.Translate(_baseSpeed * _speedMultiplier * Time.deltaTime, 0f, 0f);
	}
}