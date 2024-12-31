using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    private Rigidbody2D rigBody2D;
    private InputActions inputActions;

    public float swipeForce;

    private void Awake()
    {
        inputActions = new InputActions();
        inputActions.Enable();
    }

    private void OnDestroy()
    {
        inputActions.Disable();
    }

    void Start()
    {
        rigBody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (inputActions.Scenario.RotateRight.IsPressed())
        {
            addTorqueToRotate(-1);
            // rigBody2D.AddTorque(-1 * swipeForce);
        }

        if (inputActions.Scenario.RotateLeft.IsPressed())
        {
            addTorqueToRotate(1);
            // rigBody2D.AddTorque(swipeForce);
        }
    }

    public void addTorqueToRotate(int direction)
    {
        rigBody2D.AddTorque(direction * swipeForce);
    }
}
