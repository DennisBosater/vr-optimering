using UnityEngine;

public class batdeath : MonoBehaviour
{
    public GameObject particleEffectPrefab;
    public int fishValue = 1;

    private void OnDestroy()
    {
        if (particleEffectPrefab != null)
        {
            Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
            UICollectableFish.instance.ChangeScore(fishValue);
        }
    }
}