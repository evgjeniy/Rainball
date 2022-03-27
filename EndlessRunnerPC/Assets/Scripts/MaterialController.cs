using UnityEngine;

public class MaterialController : MonoBehaviour {
    public Material playerMaterial;
    private float H = 0, S = 0, V = 0;
    [Range(0.1f, 0.5f)]
    public float speed = 1f;

    void Update() {
        Color.RGBToHSV(playerMaterial.color, out H, out S, out V);
        H += speed * Time.deltaTime;
        if (H > 360) H = 0;
        playerMaterial.color = Color.HSVToRGB(H, S, V);
    }
}