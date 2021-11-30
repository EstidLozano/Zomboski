public class PuzzleMicroscope : Puzzle {
  private int remainingGood = 3;
  private int remainingBad = 3;
  protected override void Start() {
    base.Start();
  }
  public void OnSubstanceClicked(bool good) {
    if (good) {
      if (--remainingGood == 0) {
        OnFailed();
      }
    } else {
      if (--remainingBad == 0) {
        OnSolved();
      }
    }
  }
  public override void OnFailed() {
  }
  public override void OnSolved() {
    base.OnSolved();
  }
  
}
