using UnityEngine;

public class GameController : MonoBehaviour
{
	public delegate void FireProjectile();
	public static event FireProjectile Fire;

	private float _timer;
	[SerializeField] private float _timeToFire;

	private void Update()
	{
		UpdateTimer();
	}

	private void UpdateTimer()
	{
		if (_timer < _timeToFire)
		{
			_timer += Time.deltaTime;
		}
		else
		{
			OnFireProjectile();
			_timer = 0f;
		}
	}

	private void OnFireProjectile()
	{
		Fire();
	}
}