using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    private Rigidbody2D _rigidbody;
    private Vector3 _change;
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start() {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update() {
        _change = Vector3.zero;
        _change.x = Input.GetAxisRaw("Horizontal");
        _change.y = Input.GetAxisRaw("Vertical");
        UpdateMoveAnimation();
    }

    private void UpdateMoveAnimation() {
        if (_change != Vector3.zero) {
            MoveCharacter();
            _animator.SetFloat("moveX", _change.x); 
            _animator.SetFloat("moveY", _change.y);
            _animator.SetBool("moving", true);
        }
        else {
            _animator.SetBool("moving", false);
        }
    }

    private void MoveCharacter() {
        _rigidbody.MovePosition(
            transform.position + _change * speed * Time.deltaTime
        );
    }
}