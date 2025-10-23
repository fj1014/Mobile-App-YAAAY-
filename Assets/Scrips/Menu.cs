using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject VideoPanel;
    public GameObject MathPanel;
    public GameObject Mad;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changethat(string nameOfPanel)
    {
        VideoPanel.SetActive(nameOfPanel== "video");
        MathPanel.SetActive(nameOfPanel == "math");
        Mad.SetActive(nameOfPanel== "kabab");
    }
}
