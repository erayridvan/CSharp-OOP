using System.Collections;

namespace CustomStack
{
    public class StackStrings : Stack
    {
        public bool IsEmpty() => this.Count == 0;

        public Stack AddRange(string[] elements, StackStrings stack)
        {
            foreach (var item in elements)
            {
                stack.Push(item);
            }

            return stack;
        }

    }
}
