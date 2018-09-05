using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour //this is the behaviour that I want to happen
public class LineRenderer : MonoBehaviour

{
  
    public OVRInput.Controller controller;

    private float indexTriggerState; //this is the controllers conparing when trigger is used 
    private float prevIndexTriggerState;

    //these will be the components (game objects) that will draw the line
    public GameObject boardPrefab;  //change these to reflect the game objects that are lines etc 
    public GameObject ballPrefab;
    private GameObject board;
    private GameObject ball;
    [SerializeField]
    protected LineRenderer m_LineRenderer;
    [SerializeField]
    protected Camera m_Camera;
    protected List<Vector3> m_Points;
    public virtual LineRenderer lineRenderer



    // Use this for initialization 
    void Start () {
        this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        VRInput.Update();

        //these correspond to what happens when the triggers are used 
   
        prevIndexTriggerState = indexTriggerState;
        indexTriggerState = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);
        Debug.Log("Index trigger state:" + indexTriggerState.ToString());
        if (indexTriggerState > 0.9f && prevIndexTriggerState <= 0.9f) ;

        while //trigger is on // then do the drawing 

            else // do not draw 

        //so I need to put in that the mesh is created upon pressing the trigger 

         void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0.2f)
        {
            GameObject myLine = new GameObject();
            myLine.transform.position = start;
            myLine.AddComponent<LineRenderer>();
            LineRenderer lr = myLine.GetComponent<LineRenderer>();
            lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
            lr.SetColors(color, color);
            lr.SetWidth(0.1f, 0.1f);
            lr.SetPosition(0, start);
            lr.SetPosition(1, end);
            GameObject.Destroy(myLine, duration);
        }

    }
}
