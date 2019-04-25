using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialog : MonoBehaviour
{
    [SerializeField]
    private Image _textBox;
    [SerializeField]
    private TextMeshProUGUI _textDisplay;
    [SerializeField]
    private string[] _sentences;
    [SerializeField]
    private float _typingSpeed = 0.1f;

    private int _index = 0;
    public static bool _messageShown = false;

    private void Start()
    {
        StartCoroutine(Type());
    }

    public IEnumerator Type()
    {
        // Avoid skipping the message if it has not been entirely showed.
        _textBox.raycastTarget = false;

        foreach (char letter in _sentences[_index].ToCharArray())
        {
            _textDisplay.text += letter;

            yield return new WaitForSeconds(_typingSpeed);
        }

        _textBox.raycastTarget = true;
    }

    public void NextSentence()
    {
        if (_index < _sentences.Length - 1)
        {
            _index++;
            _textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            _messageShown = true;
            gameObject.SetActive(false);
        }
    }

    public void ResetData()
    {
        _messageShown = false;
    }
}
    