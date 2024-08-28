using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInteractionItem_Chest : MapInteractionItem
{
    public List<int> contents = new List<int>();

    //public GameObject TreasureTipPrefab;
    //public GameObject EquipmentSlectPrefab;
    //private GameObject TreasureTip;
    //private GameObject EquipmentSlect;
    public override void InteractionAction()
    {
        //Transform Canvas = GameObject.Find("Canvas").transform;
        //if (TreasureTip == null)
        //{
        //    TreasureTip = Instantiate(TreasureTipPrefab, Canvas);
        //}
        //Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        //screenPosition.Set(screenPosition.x + 5.5f, screenPosition.y + 5.5f, screenPosition.z);
        //TreasureTip.transform.position = screenPosition;
        //TreasureTip.SetActive(true);

        //CheckForClick();
    }


    //public void CheckForClick()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;
    //        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
    //        {
    //            if (EquipmentSlect == null)
    //            {
    //                EquipmentSlect = Instantiate(EquipmentSlectPrefab);
    //            }
    //            EquipmentSlectPrefab.SetActive(true);
    //        }
    //    }
    //}

    //public new void OnTriggerEnter(Collider other)
    //{
    //    base.OnTriggerEnter(other);
    //    InteractionAction();

    //}

    //public new void OnTriggerExit(Collider other)
    //{
    //    base .OnTriggerExit(other);
    //    if(TreasureTip != null)
    //    {
    //        TreasureTip.SetActive(false);
    //    }
    //}
}
