using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerEvent : Singleton<PlayerEvent>
{
    private List<MapInteractionItem> actionCache = new List<MapInteractionItem>();
 
    public void InsertAction(MapInteractionItem item)
    {
        actionCache.Add(item);
        Debug.LogError($"add {item.name}, cache size = {actionCache.Count}");
    }
    public void DeleteAction(MapInteractionItem item)
    {
        actionCache.Remove(item);
        Debug.LogError($"remove {item.name}, cache size = {actionCache.Count}");
    }
    public void InvokeAction()
    {
        if (actionCache.Count == 0)
            return;
        MapInteractionItem invokeItem = actionCache[0];
        foreach (MapInteractionItem item in actionCache)
        {
            if (item.priority > invokeItem.priority)
            {
                invokeItem = item;
            }
        }
        invokeItem.InteractionAction();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            InvokeAction();
        }
    }

}
