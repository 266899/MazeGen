using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    // Input fields for maze size
    public InputField length;
    public InputField width;

    void Start()
    {
        PlayerPrefs.DeleteAll(); // Delete all player preferences saved before
        length.contentType = InputField.ContentType.IntegerNumber; // Only integers allowed for the input
        width.contentType = InputField.ContentType.IntegerNumber; // Only integers allowed for the input
        length.characterLimit = 3; // Maximum numbers in the input field
        width.characterLimit = 3; // Maximum numbers in the input field
        length.text = "5"; // Default length
        width.text = "5"; // Default width
    }

    // Function for "Generate" button in the first scene
    public void Generate()
    {
        try
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load the next scene
            PlayerPrefs.SetInt("Length", int.Parse(length.text)); // Save maze length
            PlayerPrefs.SetInt("Width", int.Parse(length.text)); // Save maze width
        }
        catch (FormatException)
        {
            return;
        }
        
    }

    // Function to quit application
    public void Quit()
    {
        Application.Quit();
    }
}
