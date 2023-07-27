using UnityEngine;
using UnityEngine.UI;

public class PointsMED : MonoBehaviour
{
    public Button AddMED;
    public Button SubMED;
    public InputField MEDInput;
    private int currentPoints;

    private void Start()
    {
        AddMED.onClick.AddListener(IncrementPoints);
        SubMED.onClick.AddListener(DecrementPoints);
    }

    private void IncrementPoints()
    {
        currentPoints += 4;
        MEDInput.text = currentPoints.ToString();
    }

    private void DecrementPoints(){
        currentPoints -= 4;
        MEDInput.text = currentPoints.ToString();
    }

}