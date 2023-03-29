using UnityEngine;

public class batdeath : MonoBehaviour
{
    public GameObject particleEffectPrefab;
    public int scoreValue = 1;

    private void OnDestroy()
    {
        if (particleEffectPrefab != null)
        {
            Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
            UICollectables.instance.ChangeScore(scoreValue);
        }
    }
}