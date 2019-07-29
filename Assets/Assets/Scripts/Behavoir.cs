using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharSys;

namespace Behavior
{
    public class TreeNode
    {
        

    }

    public enum ActionResult
    {
        Running,
        Success,
        Failed
    }

    public abstract class Action
    {
        public abstract ActionResult Run(NPC me);
    }

    /// <summary>
    /// Only cares about 2d plane
    /// </summary>
    public class MoveTo : Action
    {
        private Vector2 _position;
        public MoveTo(Vector2 position)
        {
            _position = position;
        }

        public override ActionResult Run(NPC me)
        {
            Vector3 deltaPos = new Vector3(_position.x - me.transform.position.x, 0, _position.y - me.transform.position.z);
            float distaceMoved = Time.deltaTime * me.Speed;
            if(deltaPos.magnitude < distaceMoved)
            {
                Quaternion da = new Quaternion();
                da.SetLookRotation(new Vector3(deltaPos.x, 0, deltaPos.y), Vector3.up);
                me.transform.rotation = da;
                me.transform.position = new Vector3(_position.x, 0, _position.y);
                return ActionResult.Success;
            }
            else
            {
                Quaternion da = new Quaternion();
                da.SetLookRotation(new Vector3(deltaPos.x, 0, deltaPos.y), Vector3.up);
                me.transform.rotation = da;
                me.transform.position = me.transform.position + deltaPos.normalized*distaceMoved;
                return ActionResult.Running;
            }
        }
    }
}

