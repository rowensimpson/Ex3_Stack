using System;
using System.Collections;

namespace Stack
{
    class Stack
    {
        ArrayList stack = null;

        public Stack()
        {
            stack = new ArrayList();
        }

        public void Push(object obj)
        {
            if (obj != null)
            {
                stack.Add(obj);
            }
            else
                throw new InvalidOperationException("obj");
        }

        public object Pop()
        {
            object result;
            int lastElement = stack.Count;

            if (lastElement != 0)
            {
                result = stack[lastElement - 1];
                stack.RemoveAt(lastElement - 1);
            }
                
            else
                throw new InvalidOperationException("lastElement");
            return result;
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}
