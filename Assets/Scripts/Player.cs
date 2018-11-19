using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
	private bool _canMove;
	[SerializeField] private float _moveSpeed;

	[Space] [Header("Missile")] [SerializeField]
	private GameObject _missilePrefab;
	[SerializeField] private Transform _missileSpawnPoint;

	private WeaponSelect _weaponSelect;

	private void OnEnable()
	{
		GameController.Fire += Fire;
	}

	private void OnDisable()
	{
		GameController.Fire -= Fire;
	}

	private void Start()
	{
		_canMove = true;
		_weaponSelect = GetComponent<WeaponSelect>();
	}

	private void Update()
	{
		Movement();
	}

	private void Movement()
	{
		if (_canMove)
		{
			var moveY = Input.GetAxisRaw("Vertical") * _moveSpeed * Time.deltaTime;
			transform.position = new Vector2(transform.position.x, transform.position.y + moveY);
		}
	}

	private void Fire()
	{
		_missilePrefab = _weaponSelect.SelectedProjectilePrefab;
		Instantiate(_missilePrefab, _missileSpawnPoint.transform.position, Quaternion.identity);
	}
}