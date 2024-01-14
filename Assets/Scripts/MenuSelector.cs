using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuSelector : MonoBehaviour
{
    [SerializeField] private Button[] buttons;
    [SerializeField] private Image selectorImage;
    private int selectedIndex = 0;

    void Start()
    {
        SelectButton();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            selectedIndex = (selectedIndex - 1 + buttons.Length) % buttons.Length;
            selectedIndex = Mathf.Clamp(selectedIndex, 0, buttons.Length - 1); // yeni satır
            SelectButton();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            selectedIndex = (selectedIndex + 1) % buttons.Length;
            selectedIndex = Mathf.Clamp(selectedIndex, 0, buttons.Length - 1); // yeni satır
            SelectButton();
        }
    }

    void SelectButton()
    {
        if (buttons.Length > 0) // yeni koşul
        {
            selectorImage.transform.position = buttons[selectedIndex].transform.position;
            EventSystem.current.SetSelectedGameObject(buttons[selectedIndex].gameObject);
        }
    }
}
