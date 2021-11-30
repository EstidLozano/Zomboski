using UnityEngine;

public class AudRandPlay : MonoBehaviour {
  public AudioSource aud;
  public float minDelay = 15;
  public float maxDelay = 30f;
  protected void Start() {
    Invoke("Play", Random.Range(minDelay, maxDelay));
  }
  private void Play() {
    aud.Play();
    Invoke("Play", Random.Range(minDelay, maxDelay));
  }
}
