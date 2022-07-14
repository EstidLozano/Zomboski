public class PuzzleMicroscope : Puzzle {
  private int remainingGood = 3;
  private int remainingBad = 3;
  protected override void Start() {
    base.Start();
    index = 0;
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
  public override void Open() {
    base.Open();
    AudManage.Get(AudManage.laboratory).Stop();
    AudManage.Get(AudManage.challenge1).Play();
  }
  public override void Close() {
    base.Close();
    AudManage.Get(AudManage.challenge1).Stop();
    AudManage.Get(AudManage.laboratory).Play();
  }
  
}
