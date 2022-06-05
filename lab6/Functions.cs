using System;

namespace lab6
{
    public static class Functions
    {
        public static Node GenerateTree(string expression)
        {
            (string expLeft, char opr, string expRight) = Parse(expression);
            Node root = new Node(opr);

            if (expLeft.Length > 1)
            {
                root.Left = GenerateTree(expLeft);
            }
            else { root.Left = new Node(expLeft[0]); }

            if (expRight.Length > 1)
            {
                root.Right = GenerateTree(expRight);
            }
            else { root.Right = new Node(expRight[0]); }

            return root;
        }

        public static string String(Node root, int level)
        {
            string result = "";
            if (root.Left != null) 
            { 
                result += root.Left + ", ";
            }
            if (root.Right != null)
            {
                result += root.Right + "\n";
                result = result.Insert(0, $"Level #{level}: ");
            }
            level++;

            if (root.Left != null) { result += String(root.Left, level); }
            if (root.Right != null) { result += String(root.Right, level); }

            return result;
        }
        private static bool IsOperator(char ch) 
        {
           if(ch == '*' || ch == '/' || ch == '+' || ch == '-')
            {
                return true;
            }
            return false;
        
        }

        private static (string, char, string) Parse(string expression)
        {
            int inExp = 0, oprInd = 0;
            char opr = ' ';
            string expLeft = "", expRight = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ')') { inExp--; }

                if (inExp > 0 && oprInd == 0) { expLeft += expression[i]; }
                else if (inExp > 0 && i > oprInd) { expRight += expression[i]; }

                if (expression[i] == '(') { inExp++; }
                if (inExp != 0 || !IsOperator(expression[i])) { continue; }

                opr = expression[i];
                oprInd = i;

                if (oprInd > 0 && Char.IsLetter(expression[oprInd - 1])) { expLeft += expression[oprInd - 1]; }
                if (oprInd > 0 && Char.IsLetter(expression[oprInd + 1])) { expRight += expression[oprInd + 1]; }
            }

            return (expLeft, opr, expRight);
        }
    }
}
