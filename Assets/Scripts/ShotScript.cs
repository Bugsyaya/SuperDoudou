using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {
  /// <summary>
  /// Damage inflicted
  /// </summary>
  public int damage = 1;

  /// <summary>
  /// Projectile damage player or enemies?
  /// </summary>
  public bool isEnemyShot = false;
  public float speed = 10;
  private Rigidbody2D rigidBody2D;

  private Vector2 movement;

  void Start()
  {
    movement = new Vector2(speed * (isEnemyShot ? -1 : 1), 0);
    rigidBody2D = GetComponent<Rigidbody2D>();
    Destroy(gameObject, 1.5f); 
  }

  void FixedUpdate() {
    rigidBody2D.velocity = movement;
  }
}
