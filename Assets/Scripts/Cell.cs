using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CellState
{
    None = 0,
    White = 1,
    Black = 2
}

public class Cell : MonoBehaviour
{
    [SerializeField] private CellState m_cellState = CellState.None;
    public CellState CellState
    {
        get => m_cellState;
        set
        {
            m_cellState = value;
        }
    }

    private void OnValidate()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
