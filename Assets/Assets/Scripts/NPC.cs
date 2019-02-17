using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Behavoir;
using Util;
using Assets.Assets.Scripts;

namespace CharSys
{

    public class NPC : MonoBehaviour
    {

        #region consts
        private float BASE_SPEED = 0.8f;
        #endregion
        private string _name = NameGenerator.GetFullName();
        private float _age;
        private Action _doingAction = new MoveTo(new Vector2(00F, -1F));
        private Body _body;
        private Mind _mind;
        private List<Skill> _skills = Skill.GenerateDefaultSkills();

        // m/s
        public float Speed { get { return _body.Movability * BASE_SPEED; } }
        

        public NPC()
        {
            _body = new Body(this);
            _mind = new Mind(this);
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)){
                Debug.Log($"Speed " + Speed);
            }
            if (_doingAction == null) return;
            switch (_doingAction.Run(this))
            {
                case ActionResult.Success:
                    Debug.Log("Dave completed action successfuly");
                    _doingAction = null;
                    break;
                case ActionResult.Running:
                    break;
                case ActionResult.Failed:
                    Debug.Log("Dave failed action");
                    _doingAction = null;
                    break;
            }
        }
    }

    public class Body
    {
        private NPC _npc;

        #region Abilities (these are functions)
        public float Movability { get { return Mathf.Max(Health, 0.1f); }}
        public float Handability { get; set; } = 1f;
        public float Sight { get; set; } = 1f;
        public float Hearing { get; set; } = 1f;
        public float Taste { get; set; } = 1f;
        public float Smell { get; set; } = 1f;
        public float Touch { get; set; } = 1f;
        #endregion

        #region Bodyparts (these are values influensing abilities)
        public float Health { get; private set; } = 1f;
        #endregion

        public Body(NPC myNPC)
        {
            _npc = myNPC;
        }
    }

    public class Mind
    {
        private NPC _npc;


        public Mind(NPC myNPC)
        {
            _npc = myNPC;
        }


    }

}
