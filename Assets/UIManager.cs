using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public Image panelImage;
    public Text endGameText;

    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            endGamePanel.SetActive(true);

            if (GameController.Venceu)
            {
                panelImage.color = Color.green;
                endGameText.text = "Você venceu!";
            }
            else
            {
                panelImage.color = Color.red;
                endGameText.text = "Você foi pego!";
            }
        }
    }
}