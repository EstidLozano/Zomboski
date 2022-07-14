using UnityEngine;
using UnityEngine.SceneManagement;
public class PuzzleSlide : Puzzle {
  public PuzzleSlideCell[] cells = new PuzzleSlideCell[9];
  private Vector3[] finalPositions;
  private float slideTime = 0.2f;
  private int goodCells;
  protected override void Start() {
    base.Start();
    index = 2;
    finalPositions = new Vector3[cells.Length];
    for (int i = 0; i < cells.Length; i++) {
      finalPositions[i] = cells[i].transform.localPosition;
      cells[i].index = i;
    }
    shuffle();
  }
  public void OnCellClicked(PuzzleSlideCell cell) {
    Transform empty = cells[cells.Length - 1].transform;
    float distance = Vector2.Distance(cell.transform.localPosition, empty.localPosition);
    distance = Mathf.Round(distance * 10) / 10;
    if (distance == 1f) {
      // Swap cells
      AudManage.Get(AudManage.cellSide).Play();
      if (empty.localPosition == finalPositions[cell.index]) {
        if (++goodCells == cells.Length - 1) {
          OnSolved();
          return;
        }
      } else if (cell.transform.localPosition == finalPositions[cell.index]) {
        goodCells--;
      }
      StartCoroutine(Util.IEMove(cell.transform, empty.localPosition, slideTime));
      StartCoroutine(Util.IEMove(empty, cell.transform.localPosition, slideTime));
    }
  }
  private void shuffle() {
    int[] indexes = Util.Unsorted(cells.Length - 1);
    // number of inversions
    int inversions = 0;
    for (int i = 0; i < indexes.Length; i++) {
      for (int j = i + 1; j < indexes.Length; j++) {
        if (indexes[i] > indexes[j])
          inversions++;
      }
    }
    // if inversions is odd, then the puzzle is unsolvable
    if (inversions % 2 == 1) {
      // make it solvable
      int temp = indexes[0];
      indexes[0] = indexes[1];
      indexes[1] = temp;
    }
    for (int i = 0; i < indexes.Length; i++) {
      cells[i].transform.localPosition = finalPositions[indexes[i]];
    }
    // add to good cells
    goodCells = 0;
    for (int i = 0; i < indexes.Length; i++) {
      if (indexes[i] == i)
        goodCells++;
    }
  }
  public override void OnSolved() {
    base.OnSolved();
    Invoke("EndGame", 3f);
  }
  private void EndGame() {
    SceneManager.LoadScene("MainMenu");
  }
}
