using System;
using System.Xml.Serialization;

namespace tabuleiro
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg) 
        { 
        }
    }
}
