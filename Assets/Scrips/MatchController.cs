using UnityEngine;
using TMPro;
public class MatchController : MonoBehaviour
{

    public TextMeshProUGUI voresText;
    public int startingNumber = 10;
    private int currentNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentNumber = startingNumber;
        updateNumber();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void minusNumber(int numberToMinus)
    {
        currentNumber = currentNumber - numberToMinus;
        updateNumber();
    }
    public void plusNumber(int numbertoplus)
    {
        currentNumber += numbertoplus;
        updateNumber();
    }
    public void updateNumber()
    {
        voresText.text = currentNumber.ToString(); 
    }

}
