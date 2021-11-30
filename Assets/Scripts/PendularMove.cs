using UnityEngine;
public class PendularMove : MonoBehaviour {
  private Vector3 initPos;
  public float frecuency = 1f;
  public float magnitude = 1f;
  public Vector3 axis = Vector3.up;
  void Start() {
    initPos = transform.position;
  }
  void Update() {
    transform.position = initPos + axis * Mathf.Sin(Time.time * frecuency) * magnitude;
  }
}

  
