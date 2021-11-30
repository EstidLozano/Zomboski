using UnityEngine;

public class CamFollow : MonoBehaviour {
  public Transform target;
  public float speed = 1f;
  public float stopDistance = 0.02f;
  public float leftBound = -100f;
  public float rightBound = 100f;
  public float topBound = 100f;
  public float bottomBound = -100f;
  private Vector3 offset;
  protected void Start() {
    offset = transform.position - target.position;
  }
  protected void Update() {
    Vector3 targetPos = target.position + offset;
    targetPos.x = Mathf.Clamp(targetPos.x, leftBound, rightBound);
    targetPos.y = Mathf.Clamp(targetPos.y, bottomBound, topBound);
    if (Vector3.Distance(transform.position, targetPos) > stopDistance) {
      float step = speed * Time.deltaTime;
      transform.position = Vector3.Lerp(transform.position, targetPos, step);
    }
  }
}
