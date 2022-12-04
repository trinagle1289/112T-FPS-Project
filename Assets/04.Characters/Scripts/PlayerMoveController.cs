using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour {

    /// <summary>
    /// 移動速度
    /// </summary>
    [SerializeField] private float moveSpeed = 3.0f;

    /// <summary>
    /// 旋轉速度
    /// </summary>
    [SerializeField] private float rotateSpeed = 3.0f;

    private Rigidbody rb = null;

    private void Awake() {
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            rb.AddForce(transform.forward * moveSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A)) {
            rb.AddTorque(Vector3.up * rotateSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D)) {
            rb.AddTorque(Vector3.down * rotateSpeed, ForceMode.Force);
        }

    }
}
