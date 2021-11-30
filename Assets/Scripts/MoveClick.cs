using UnityEngine;
public class MoveClick : MonoBehaviour {
  public float speed = 5f;
  private Animator animator;
  private Vector3 target;
  private string animProp = "DirectedDistance";
  private float stopDistance = 0.05f;
  private bool moving = false;
  protected void Start() {
    animator = GetComponent<Animator>();
  }
  protected void FixedUpdate() {
    if (moving) {
      float step = speed * Time.deltaTime;
      transform.position = Vector2.MoveTowards(transform.position, target, step);
      if (Vector3.Distance(transform.position, target) < stopDistance) {
        moving = false;
        animator.SetFloat(animProp, 0);
      } else {
        animator.SetFloat(animProp, target.x - transform.position.x);
      }
    }
  }
  protected void OnMouseDown() {
    target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    target.y = transform.position.y;
    moving = true;
  }
}
