using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Regenerate : MonoBehaviour {

    // Input fields
    public InputField length;
    public InputField width;
    
    void Start ()
    {
        length.contentType = InputField.ContentType.IntegerNumber; // Only integers allowed for the input
        width.contentType = InputField.ContentType.IntegerNumber; // Only integers allowed for the input
        length.characterLimit = 3; // Maximum numbers in the input field
        width.characterLimit = 3; // Maximum numbers in the input field
    }

    // Function to regenerate maze by taking new values and loading the same scene
    public void RegenerateMaze()
    {
        int x = 0;
        int z = 0;
        try
        {
            x = int.Parse(length.text); // Getting maze length from the input field
            z = int.Parse(width.text); // Getting maze width from the input field
            PlayerPrefs.SetInt("Length", x); // Storing maze length for easy access
            PlayerPrefs.SetInt("Width", z); // Storing maze width for easy access
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Rebuild the same scene
        }

        // If input fields left empty - do nothing
        catch (FormatException)
        {
            return;
        }
    }
}
