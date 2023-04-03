using UnityEngine;

public class batdeath : MonoBehaviour
{
    public int scoreValue = 1;

    private void OnDestroy()
    {
            UICollectables.instance.ChangeScore(scoreValue);
    }
}