using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour {

    [SerializeField]
    private float _jumpVelocity = 5f;
    [SerializeField]
    private float _fallMultiplier = 2.5f;
    [SerializeField]
    private float _jumpMultiplier = 2f;

    private Rigidbody2D _rigidbody;

	private void Awake()
	{
        _rigidbody = GetComponent<Rigidbody2D>();
        if (_rigidbody == null)
            gameObject.AddComponent<Rigidbody2D>();
	}

	private void Update()
	{
        if (Input.GetButtonDown("Jump"))
        {
                _rigidbody.velocity = Vector2.up * _jumpVelocity;
        }

        if (_rigidbody.velocity.y < 0)
        {
            _rigidbody.velocity += Vector2.up * Physics2D.gravity *
                _fallMultiplier * Time.deltaTime;
        }
        else if (_rigidbody.velocity.y > 0)
        {
            _rigidbody.velocity += Vector2.up * Physics.gravity *
                _jumpMultiplier * Time.deltaTime;
        }
	}
}
