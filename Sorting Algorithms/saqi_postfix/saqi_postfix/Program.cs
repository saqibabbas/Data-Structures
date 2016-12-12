using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace saqi_postfix
{
    class Program
    {
        public static void Main(String[] args)
        {
            String input, output;
            
                input = Console.ReadLine();
                InToPost theTrans = new InToPost(input);
                output = theTrans.doTrans();
                Console.WriteLine("Postfix is " + output );
            
        }
    }

    class StackX
    {
        private int maxSize;
        private char[] stackArray;
        private int top;

        public StackX(int s)
        {
            maxSize = s;
            stackArray = new char[maxSize];
            top = -1;
        }
        public void push(char j)
        {
            stackArray[++top] = j;
        }
        public char pop()
        {
            return stackArray[top--];
        }        
        public bool isEmpty()
        {
            return (top == -1);
        }                
    }
    class InToPost
    {
        private StackX theStack;
        private String input;
        private String output = "";

        public InToPost(String inp)
        {
            input = inp;
            int stackSize = input.Length;
            theStack = new StackX(stackSize);
        }

        public String doTrans()
        {
            char[] arr = input.ToCharArray();
            for (int j = 0; j < input.Length; j++)
            {
                char ch = arr[j];
        
                switch (ch)
                {
                    case '+':
                    case '-':
                        gotOper(ch, 1);
                        break;
                    case '*':
                    case '/':
                        gotOper(ch, 2);
                        break;
                    case '(':
                        theStack.push(ch);
                        break;
                    case ')':
                        gotParen(ch);
                        break;
                    default:
                        output = output + ch;
                        break;
                }

            }
            while (!theStack.isEmpty())
            {        
                output = output + theStack.pop();
            }        
            return output;
        }

        public void gotOper(char opThis, int precedence_latest)
        {

            while (!theStack.isEmpty())
            {
                char opTop = theStack.pop();
                if (opTop == '(')
                {
                    theStack.push(opTop);
                    break;
                }
                else
                {
                    int precedence_previous;
                    if (opTop == '+' || opTop == '-')
                        precedence_previous = 1;
                    else
                        precedence_previous = 2;
                    if (precedence_previous < precedence_latest)
                    {
                        theStack.push(opTop);
                        break;
                    }
                    else
                        output = output + opTop;
                }
            }
            theStack.push(opThis);
        }

        public void gotParen(char ch)
        {

            while (!theStack.isEmpty())
            {
                char chx = theStack.pop();
                if (chx == '(')
                    break;

                else
                    output = output + chx;
            }
        }
    }
}
