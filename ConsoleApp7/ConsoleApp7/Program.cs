// See https://aka.ms/new-console-template for more information
namespace Hello
{
    interface Stack<Item>
    {
        bool IsEmpty();
        void Push(char item);
        Item Pop();
        void Delete();
        Item Peek();
    }


    public class StackNode<Item>
    {
        public char data;
        public StackNode<Item> link;
    }
    public class LinkedStack<Item>
    {
        private StackNode<Item> top;
        public bool IsEmpty()
        {
            return (top == null);
        }
        public void Push(char item)
        {
            StackNode<Item> newNode = new StackNode<Item>();
            newNode.data = item;
            newNode.link = top;
            top = newNode;
            // System.out.println("Inserted Item : " + item);
        }

        public char Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
                return (char)0;
            }
            else
            {
                char item = top.data;
                top = top.link;
                return item;
            }
        }

        public void Delete()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Deleting fail! Linked Stack is empty!!");
            }
            else
            {
                top = top.link;
            }
        }
        public char Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Peeking fail! Linked Stack is empty!!");
                return (char)0;
            }
            else
                return top.data;
        }
        public void PrintStack()
        {
            if (IsEmpty())
                Console.Write("Linked Stack is empty!! %n %n");
            else
            {
                StackNode<Item> temp = top;
                Console.WriteLine("Linked Stack>> ");
                while (temp != null)
                {
                    Console.Write("\t %c \n", temp.data);
                    temp = temp.link;
                }
                Console.WriteLine();
            }
        }
    }
    public class OptExp
    {
        private String exp;
        private int expSize;
        private char testCh, openPair;

        public bool TestPair(String exp)
        {
            this.exp = exp;
            LinkedStack<IThreadPoolWorkItem> S = new LinkedStack<IThreadPoolWorkItem>();
            expSize = this.exp.Length;
            for (int i = 0; i < expSize; i++)
            {
                testCh = this.exp.ElementAt(i);
                switch (testCh)
                {
                    case '(':
                    case '{':
                    case '[':
                        S.Push(testCh);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (S.IsEmpty())
                            return false;
                        else
                        {
                            openPair = S.Pop();
                            if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}')
                                    || (openPair == '[' && testCh != ']'))
                                return false;
                            else
                                break;
                        }
                }
            }
            if (S.IsEmpty())
                return true;
            else
                return false;
        }
    }
    class BracketTest
    {
        static void Main(String[] args)
        {
            OptExp opt = new OptExp();
            String exp = "(3*5)-6/2)";
            Console.WriteLine(exp);
            if (opt.TestPair(exp))
                Console.WriteLine("괄호 맞음!!");
            else
                Console.WriteLine("괄호 틀림!!");
        }
    }
}
