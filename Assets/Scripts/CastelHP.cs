using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CastelHP : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public TextMeshProUGUI healthText; // UI TextMeshPro ��� ����������� �������� �����
    public GameObject gameOverPanel; // ������, ������� ����� ������������ ��� ���������

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
        gameOverPanel.SetActive(false); // ���������, ��� ������ ��������� ������ � ������ ����
    }

    // ������� ��� ��������� ����� �����
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

    // ���������� UI �������� �����
    void UpdateHealthUI()
    {
        healthText.text = "HP: " + currentHealth.ToString();
    }

    // �������, ���������� ��� ���������
    void GameOver()
    {
        Debug.Log("Game Over!");
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        // ������������� ����� �������� ��������� ����, ����� ���� ��� ������ ��������
    }
}
