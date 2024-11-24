using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SelectLevelButton : MonoBehaviour
{
    [SerializeField] private int _targetLevel;
    [SerializeField] private Text _levelText;

    private void Awake()
    {
        _levelText.text = _targetLevel.ToString();

        GetComponent<Button>().onClick.AddListener(() =>
        {
            PlayerPrefs.SetInt("level", _targetLevel - 1);
            SceneManager.LoadScene(1);
        });
    }
}
