using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextDisplay : MonoBehaviour
{
    public TextMeshProUGUI textObj;
    public SimpleIntData counter;
    public Text textContent;

    public void Update()
    {
        textObj.text = "Score: " + counter.value;
    }
}
