using UnityEngine;
using UnityEngine.UI;

public class SetActiveButtons : MonoBehaviour
{
    public Button restartButton;
    public Button menuButton;
    private void Start()
    {
        restartButton.enabled = false;
        menuButton.enabled = false;
    }
    public void setActiveButtons()
    {
        restartButton.enabled = true;
        menuButton.enabled = true;
    }
}
