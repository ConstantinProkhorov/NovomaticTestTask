using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
/// <summary>
/// Logic for instantiating new ball facing direction player have clicked in.
/// </summary>
public class BallThrower : MonoBehaviour
{
    [Tooltip("Ball: ")]
    [SerializeField] private GameObject BallPrefab = null;
    [SerializeField] private IntegerValue BallsCount = null;
    private Vector3 ClickPosition;
    [Tooltip("GraphicRaycaster:")]
    [SerializeField] private GraphicRaycaster m_Raycaster = null;
    [SerializeField] private EventSystem m_EventSystem = null;
    private PointerEventData m_PointerEventData;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (IsUIElementClicked()) return;
            ThrowBall();
            BallsCount++;
        }
    }
    /// <summary>
    /// Instantiates a new ball from prefab.
    /// Determines which direction to face created ball, so that direction will match player click.
    /// </summary>
    private void ThrowBall()
    {     
        Plane plane = new Plane(Vector3.forward, 0.0f);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distanceToPlane;
        if (plane.Raycast(ray, out distanceToPlane))
        {
            ClickPosition = ray.GetPoint(distanceToPlane);
        }
        transform.LookAt(ClickPosition);
        Instantiate(BallPrefab, transform.position, gameObject.transform.rotation);
    }
    /// <summary>
    /// Checks if player has clicked UI element or not. 
    /// </summary>
    private bool IsUIElementClicked()
    {
        m_PointerEventData = new PointerEventData(m_EventSystem);
        m_PointerEventData.position = Input.mousePosition;
        List<RaycastResult> results = new List<RaycastResult>();
        m_Raycaster.Raycast(m_PointerEventData, results);
        return (results.Count > 0) ? true : false;
    }
}
