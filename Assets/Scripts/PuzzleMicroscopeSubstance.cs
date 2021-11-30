using UnityEngine;
public class PuzzleMicroscopeSubstance : MonoBehaviour {
  public bool good;
  private PuzzleMicroscope puzzle;
  private SpriteRenderer render;
  protected void Start() {
    puzzle = transform.parent.GetComponent<PuzzleMicroscope>();
    render = GetComponent<SpriteRenderer>();
  }
  protected void OnMouseOver() {
    render.color = Color.yellow;
  }
  protected void OnMouseExit() {
    render.color = Color.white;
  }
  protected void OnMouseDown() {
    Util.SetVisible(gameObject, false);
    puzzle.OnSubstanceClicked(good);
  }
}
