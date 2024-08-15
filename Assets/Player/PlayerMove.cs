using UnityEngine;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
        private int _direction = 8;
        [SerializeField] private int reqDirection = 8;
        private Rigidbody2D _rb2D;
        public float moveSpeed;
        public static string _dir;
        private void Start()
        {
            moveSpeed = 1;
            _rb2D = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            /*
            new Networking.Post<Void>("/set-direction", null).AddParam("direction", reqDirection + "").Build();
            new Networking.Get<DirectionResponses>("/get-direction").OnResponse(dr => _direction = dr.direction).OnError((_) => _direction = 8).Build();
            */
            _direction = reqDirection;
            Move();
        }

        private void Move()
        {
            Debug.Log(_direction);
            switch (_direction)
            {
                case 0:
                    // UP
                    _rb2D.velocity = new Vector2(0f, moveSpeed);
                    _dir = "up";
                    break;
                case 1:
                    // UP-RIGHT
                    break;
                case 2:
                    // RIGHT
                    _dir = "right";
                    _rb2D.velocity = new Vector2(moveSpeed, 0f);
                    break;
                case 3:
                    // DOWN-RIGHT
                    break;
                case 4:
                    _dir = "down";
                    _rb2D.velocity = new Vector2(0f, -1*moveSpeed);
                    // DOWN
                    break;
                case 5:
                    // DOWN-LEFT
                    break;
                case 6:
                    // LEFT
                    _dir = "left";
                    _rb2D.velocity = new Vector2(-1*moveSpeed, 0f);
                    break;
                case 7:
                    // UP_LEFT
                    break;
                case 8:
                    // STAY
                    _dir = "stay";
                    _rb2D.velocity = new Vector2(0f, 0f);
                    break;
            }
        }
    }
}
