using UnityEngine;
using System.Linq;
using UnityEngine.UI;
public class PuzzleSafe : Puzzle {
  public Text text;
  public GameObject blood;
  private int[] key = {4, 2, 7, 2, 1};
  private int[] numbers = {-1, -1, -1, -1, -1};
  private int currentNum = 0;
  protected override void Start() {
    base.Start();
    Util.SetVisible(blood, false);
  }
  protected void Update() {
    if (Input.GetKeyDown(KeyCode.Return)) {
      OnKeyClicked(10);
    } else if (Input.GetKeyDown(KeyCode.Backspace)) {
      OnKeyClicked(11);
    } else {
      for (int i = 0; i < 10; i++) {
        if (Input.GetKeyDown(KeyCode.Alpha0 + i)) {
          OnKeyClicked(i);
        }
      }
    }
  }
  public void OnKeyClicked(int number) {
    if (number == 10) {
      if (currentNum == key.Length && Enumerable.SequenceEqual(numbers, key)) {
        OnSolved();
      } else {
        OnFailed();
      }
    } else if (number == 11) {
      if (currentNum > 0) {
        numbers[--currentNum] = -1;
      }
    } else if (currentNum < numbers.Length) {
      numbers[currentNum++] = number;
    }
    text.text = string.Join("", numbers.Select(n => n == -1 ? "" : n.ToString()).ToArray());
  }
  public override void OnFailed() {
  }
  public override void OnSolved() {
    base.OnSolved();
    Util.SetVisible(blood, true);
    blood.GetComponent<Animator>().SetTrigger("Play");
  }
}
