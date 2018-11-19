using UnityEngine;
using UnityEngine.UI;

public class WeaponSelect : MonoBehaviour
{
	[SerializeField] private GameObject[] _projectiles;
	[SerializeField] private Text _missileTypeText;

	public GameObject SelectedProjectilePrefab { get; private set; }

	ProjectileType _selectedProjectile;

	private enum ProjectileType
	{
		Small,
		Medium,
		Large
	};

	void Start()
	{
//		_missileTypeText = GetComponent<Text>();
		_selectedProjectile = ProjectileType.Small;
		SelectedProjectilePrefab = _projectiles[0];
	}

	void Update()
	{
		SelectProjectile();
	}

	private GameObject SelectProjectile()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			switch (_selectedProjectile)
			{
				case ProjectileType.Small:
					_selectedProjectile = ProjectileType.Medium;
					break;
				case ProjectileType.Medium:
					_selectedProjectile = ProjectileType.Large;
					break;
				case ProjectileType.Large:
					_selectedProjectile = ProjectileType.Small;
					break;
			}
		}

		SelectedProjectilePrefab = _projectiles[_selectedProjectile.GetHashCode()];
		_missileTypeText.text = _selectedProjectile.ToString();
		return SelectedProjectilePrefab;
	}
}