using UnityEngine;

public class FiringBehaviour : MonoBehaviour
{
	[SerializeField] private GameObject _projectilePrefab;

	private void OnEnable()
	{
		GameController.OnFireProjectile += Fire;
	}

	private void OnDisable()
	{
		GameController.OnFireProjectile -= Fire;
	}


	private void Fire(Sprite projectileSprite, float speed)
	{
		var newProjectile = Instantiate(_projectilePrefab, transform.position, Quaternion.identity);
	}
}