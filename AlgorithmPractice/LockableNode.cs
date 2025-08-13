using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    public class LockableNode
    {
        public int Val;
        public LockableNode Left;
        public LockableNode Right;
        public LockableNode Parent;

        private bool _isLocked = false;
        private int _lockedDescendants = 0;

        public LockableNode(int val, LockableNode left = null, LockableNode right = null, LockableNode parent = null)
        {
            Val = val;
            Left = left;
            Right = right;
            Parent = parent;
            if (Left != null) Left.Parent = this;
            if (Right != null) Right.Parent = this;
        }

        // O(1)
        public bool IsLocked() => _isLocked;

        // O(h)
        public bool Lock()
        {
            if (_isLocked) return true;                
            if (_lockedDescendants > 0) return false;  
            for (var cur = Parent; cur != null; cur = cur.Parent)
                if (cur._isLocked) return false;

            _isLocked = true;
            for (var cur = Parent; cur != null; cur = cur.Parent)
                cur._lockedDescendants++;

            return true;
        }

        // O(h)
        public bool Unlock()
        {
            if (!_isLocked) return true;             
            _isLocked = false;
            for (var cur = Parent; cur != null; cur = cur.Parent)
                cur._lockedDescendants--;

            return true;
        }
    }

}
