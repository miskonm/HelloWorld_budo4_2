using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    public int Min = 1;
    public int Max = 1000;

    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI GuessLabel;
    public Button MoreButton;
    public Button LessButton;
    public Button FinishButton;

    private int _guess;

    private void Start()
    {
        // My comment
        MoreButton.onClick.AddListener(MoreButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);

        SetInfoText($"Загадай число от {Min} до {Max}.");
        CalculateGuess();
    }

    private void CalculateGuess()
    {
        _guess = (Min + Max) / 2;

        SetGuessText($"Твое число: {_guess}?");
    }

    private void SetInfoText(string text)
    {
        Debug.Log(text);

        InfoLabel.text = text;
    }

    private void SetGuessText(string text)
    {
        Debug.Log(text);

        GuessLabel.text = text;
    }

    private void MoreButtonClicked()
    {
        Debug.Log("Число больше");
        Min = _guess;
        CalculateGuess();
    }

    private void FinishButtonClicked()
    {
        SetGuessText($"Победа! Твое число: {_guess}");
    }

    private void LessButtonClicked()
    {
        Debug.Log("Число меньше");
        Max = _guess;
        CalculateGuess();
    }
}