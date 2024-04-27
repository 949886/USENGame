using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HighAndLowTerminalView : AbstractView
{
    string m_prefabPath = "HighAndLow/HighAndLowTerminalPanel";
    Button m_backGameButton;
    Button m_pauseButton;
    Button m_terminalButton;
    HightAndLowGameView m_gameView;
    public void Build(Transform parent)
    {
        m_mainViewGameObject = LoadViewGameObject(m_prefabPath, parent);

        m_backGameButton = m_mainViewGameObject.transform.Find("BackGameButton").GetComponent<Button>();
        m_backGameButton.onClick.AddListener(OnBackGameButtonClicked);
        m_pauseButton = m_mainViewGameObject.transform.Find("PauseButton").GetComponent<Button>();
        m_pauseButton.onClick.AddListener(OnPauseButtonClicked);
        m_terminalButton = m_mainViewGameObject.transform.Find("TerminalButton").GetComponent<Button>();
        m_terminalButton.onClick.AddListener(OnTerminalButtonClicked);

        EventSystem.current.SetSelectedGameObject(m_backGameButton.gameObject);
    }

    public void Hide()
    {
        m_mainViewGameObject.SetActive(false);
    }

    public void OnAndroidKeyDown(string keyName)
    {
        
    }

    public void OnThemeTypeChanged()
    {
        
    }

    public void Show()
    {
        m_mainViewGameObject.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetButtonDown("Cancel")) {
            
        }
    }

    void OnBackGameButtonClicked() {
        Hide();
    }

    void OnPauseButtonClicked() {

    }

    void OnTerminalButtonClicked() {

    }
}