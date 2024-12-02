using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum State
    {
        Staying,
        RUNning,
        MenImDeeeeD,
    }

    private State currentState;

    void Start()
    {
        currentState = State.Staying;

        Debug.Log("I'm" + currentState);
    }

    void Update()
    {
        HandleState();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeState(State.RUNning);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        { 
            ChangeState(State.Staying);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            ChangeState(State.MenImDeeeeD);
        }
    }

    private void HandleState()
    {
        switch (currentState)
        {
            case State.Staying:
                //currentState = State.Staying;
                Debug.Log("Staying");
                break;

            case State.RUNning:
                //currentState = State.RUNning;
                Debug.Log("Running");
                break;

            case State.MenImDeeeeD:
                //currentState = State.MenImDEEEEED;
                Debug.Log("MenImDEEEEED");
                break;
        }
    }
    void ChangeState(State newState)
    {
        currentState = newState;

        Debug.Log("Current State: " + currentState);
    }
}