using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CastelHP : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public TextMeshProUGUI healthText; // UI TextMeshPro для отображения здоровья замка
    public GameObject gameOverPanel; // Панель, которая будет показываться при поражении

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
        gameOverPanel.SetActive(false); // Убедитесь, что панель поражения скрыта в начале игры
    }

    // Функция для нанесения урона замку
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            GameOver();
        }
        UpdateHealthUI();
    }

    // Обновление UI здоровья замка
    void UpdateHealthUI()
    {
        healthText.text = "HP: " + currentHealth.ToString();
    }

    // Функция, вызываемая при поражении
    void GameOver()
    {
        Debug.Log("Game Over!");
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        // Дополнительно можно добавить остановку игры, показ меню или другие действия
    }
}
