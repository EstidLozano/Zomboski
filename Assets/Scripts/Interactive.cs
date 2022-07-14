using UnityEngine;

public class Interactive : MonoBehaviour {
  public Puzzle puzzle;
  private SpriteRenderer render;
  protected void Start() {
    render = GetComponent<SpriteRenderer>();
  }
  protected void OnMouseOver() {
    if (canInteract()) {
      render.color = Color.yellow;
    }
  }
  protected void OnMouseExit() {
    if (canInteract()) {
      render.color = Color.white;
    }
  }
  protected void OnMouseDown() {
    if (canInteract()) {
      puzzle.Open();
    }
  }
  protected bool canInteract() {
    return puzzle != null && !puzzle.solved && Puzzle.current == puzzle.index;
  }
}
