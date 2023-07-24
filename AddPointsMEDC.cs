using UnityEngine;
using UnityEngine.UI;

public class AddPointsMEDC : MonoBehaviour
{
    public Button AddMED;
    public InputField MEDInput;

    private void Start()
    {
        AddMED.onClick.AddListener(AddFourPoints);
    }

    public void AddFourPoints()
    {
        if (int.TryParse(MEDInput.text, out int currentValue))
        {
            int newPoints = currentValue + 4;
            MEDInput.text = newPoints.ToString();
        }
        else
        {
            MEDInput.text = "4";
        }
    }
}
