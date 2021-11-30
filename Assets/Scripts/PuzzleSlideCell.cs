using UnityEngine;
public class PuzzleSlideCell : MonoBehaviour {
  private PuzzleSlide puzzle;
  public int index;
  protected void Start() {
    transform.localScale = Vector2.one * 0.9f;
    puzzle = transform.parent.GetComponent<PuzzleSlide>();
  }
  protected void OnMouseDown() {
    puzzle.OnCellClicked(this);
  }
}
