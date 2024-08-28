using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MapCube : MonoBehaviour
{
    [HideInInspector]
    public bool used = true;
    private Renderer m_renderer;
    public TurretData memory;
    public int level;
    public GameObject turret;
    public int times = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_renderer = GetComponent<Renderer>();
        level = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject()==false&&Time.timeScale!=0)
        {
            m_renderer.material.color = Color.red;
        }
    }

    private void OnMouseExit()
    {
        m_renderer.material.color = Color.white;
    }

    
}
