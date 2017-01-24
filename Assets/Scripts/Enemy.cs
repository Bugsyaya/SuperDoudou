using UnityEngine;

/// <summary>
/// Comportement générique pour les méchants
/// </summary>
public class Enemy : MonoBehaviour
{
  private WeaponScript weapon;

  void Awake()
  {
    // Récupération de l'arme au démarrage
    weapon = GetComponent<WeaponScript>();
  }

  void Update()
  {
    // Tir auto
    if (weapon.CanAttack)
    {
      weapon.Attack(true);
    }
  }
}