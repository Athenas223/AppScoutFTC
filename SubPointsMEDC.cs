using UnityEngine;
using UnityEngine.UI;

public class SubPointsMEDC : MonoBehaviour
{
    public Button SubMED;
    public InputField MEDInput;

    private void Start()
    {
        SubMED.onClick.AddListener(SubFourPoints);
    }

    public void SubFourPoints()
    {
        if (int.TryParse(MEDInput.text, out int currentValue))
        {
            int newPoints = currentValue - 4;
            MEDInput.text = newPoints.ToString();
        }
        else
        {
            MEDInput.text = "4";
        }
    }
}
