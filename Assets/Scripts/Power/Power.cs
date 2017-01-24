using UnityEngine;

public class Power {
    public delegate void PowerEffect(GameObject gameObject);

    private GameObject prefab;
    private PowerEffect effect;

    public Power(GameObject prefab, PowerEffect effect) {
        this.prefab = prefab;
        this.effect = effect;
    }

    public GameObject spawn(Vector3 position) {
        GameObject spawned = GameObject.Instantiate(prefab, position, Quaternion.identity);
        spawned.GetComponent<ApplyPower>().power = this;
        return spawned;
    }

    public void applyOn(GameObject gameObject) {
        effect(gameObject);
    }
}