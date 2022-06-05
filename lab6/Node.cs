
namespace lab6
{
    public class Node
    {
        public Node(char value)
        {
            Value = value;
        }

        private char Value { get; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public override string ToString() => $"{Value}";
    }
}
