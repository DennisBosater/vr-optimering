using UnityEngine;

public class destroydoor : MonoBehaviour
{
    public GameObject particleEffectPrefab;
    
    private void OnDestroy()
    {
        if (particleEffectPrefab != null)
        {
            particleEffectPrefab.SetActive(true);
        }
    }
}