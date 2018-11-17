using UnityEngine;

public class GameController : MonoBehaviour
{
	public delegate void FireProjectile(Sprite projectileSprite, float speed);

	private float _timer;
	[SerializeField] private float _timeToFire;
	public static event FireProjectile OnFireProjectile;

	private void Start()
	{
	}

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
			Fire();
			_timer = 0f;
		}
	}

	private void Fire()
	{
		OnFireProjectile();
	}
}