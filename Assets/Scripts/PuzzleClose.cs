using UnityEngine;
public class PuzzleClose : MonoBehaviour {
  private Puzzle puzzle;
  private SpriteRenderer render;
  void Start() {
    puzzle = transform.parent.GetComponent<Puzzle>();
    render = GetComponent<SpriteRenderer>();
  }
  protected void OnMouseOver() {
    render.color = Color.yellow;
  }
  protected void OnMouseExit() {
    render.color = Color.white;
  }
  protected void OnMouseDown() {
    puzzle.Close();
  }
}
