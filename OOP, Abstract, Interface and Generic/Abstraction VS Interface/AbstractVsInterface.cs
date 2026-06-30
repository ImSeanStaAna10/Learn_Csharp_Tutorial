using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__Abstract__Interface_and_Generic.Abstraction_VS_Interface
{
    public abstract class Document
    {
        public string Name { get; set; }
        public void Process(){}
        public abstract void Print();
    }

    public class PDF: Document
    {
        public override void Print() { }
    }

    public class WORD: Document
    {
        public override void Print() { }
    }

    public interface IDokumento
    {
        string name { get; set;  }
        void Process();
        void Print();
    }

    public class Excel : IDokumento
    {
        public string name { get; set; }

        public void Print() { }
        public void Process() { }
    }

    public interface IDoc1 { }
    public interface IDoc2 { }


    public class newDocument : WORD, IDoc1, IDoc2 { }
}
