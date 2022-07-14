using UnityEngine;
public class AudManage : MonoBehaviour {
  public static int cellSide = 0,
      challenge1 = 1,
      challenge2 = 2,
      laboratory = 3,
      menu = 4,
      puzzleOpen = 5,
      success = 6,
      suspense = 7,
      zombies = 8;
  private AudioSource[] srcs;
  private static AudManage instance;
  protected void Awake() {
    instance = this;
  }
  protected void Start() {
    srcs = GetComponents<AudioSource>();
  }
  public static AudioSource Get(int i) {
    return instance.srcs[i];
  }
  public void PlayDelayRandom(AudioSource src, float minDelay, float maxDelay, bool repeat) {
    src.PlayDelayed(Random.Range(minDelay, maxDelay));
    if (repeat) {
      PlayDelayRandom(src, minDelay, maxDelay, true);
    }
  }
}
