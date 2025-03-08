using UnityEngine;
using TMPro; // Import TextMeshPro

public class AnimalProximity : MonoBehaviour
{
    public string animalName;
    public string habitat;
    public string diet;
    public string funFact;

    public GameObject infoCanvas; // Assign the UI Canvas in Inspector

    // Change from GameObject to TextMeshProUGUI
    public TextMeshProUGUI nameField;
    public TextMeshProUGUI habitatField;
    public TextMeshProUGUI dietField;
    public TextMeshProUGUI factsField;

    private void Start()
    {
        infoCanvas.SetActive(false); // Hide UI initially
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera")) // Detect when the camera is near
        {
            ShowInfo();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera")) // Hide UI when the camera moves away
        {
            HideInfo();
        }
    }

    void ShowInfo()
    {
        infoCanvas.SetActive(true);

        // Directly update TextMeshProUGUI components
        nameField.text = "Name: " + animalName;
        habitatField.text = "Habitat: " + habitat;
        dietField.text = "Diet: " + diet;
        factsField.text = "Fun Fact: " + funFact;
    }

    void HideInfo()
    {
        infoCanvas.SetActive(false);
    }
}
