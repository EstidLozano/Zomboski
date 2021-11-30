using UnityEngine;
public class PuzzleSafeKey : MonoBehaviour {
  public int number;
  private PuzzleSafe puzzle;
  private SpriteRenderer render;
  protected void Start() {
    puzzle = transform.parent.GetComponent<PuzzleSafe>();
    render = GetComponent<SpriteRenderer>();
  }
  protected void OnMouseOver() {
    render.color = Color.yellow;
  }
  protected void OnMouseExit() {
    render.color = Color.white;
  }
  protected void OnMouseDown() {
    puzzle.OnKeyClicked(number);
  }
}
