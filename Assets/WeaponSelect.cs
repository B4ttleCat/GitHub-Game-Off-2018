using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
	[SerializeField] private Sprite[] _projectiles;
	ProjectileType _selectedProjectile;
	private Sprite _selectedProjectileSprite;

	private enum ProjectileType
	{
		Small,
		Medium,
		Large
	};

	void Start()
	{
		_selectedProjectile = ProjectileType.Small;
	}

	void Update()
	{
		SelectProjectile();
	}

	private void SelectProjectile()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (_selectedProjectile == ProjectileType.Small)
			{
				_selectedProjectile = ProjectileType.Medium;
			}
			else if (_selectedProjectile == ProjectileType.Medium)
			{
				_selectedProjectile = ProjectileType.Large;
			}
			else if (_selectedProjectile == ProjectileType.Large)
			{
				_selectedProjectile = ProjectileType.Small;
			}
			_selectedProjectileSprite = _projectiles[_selectedProjectile.GetHashCode()];
			print(_selectedProjectile + " with " + _selectedProjectileSprite);
		}
	}
}