namespace Lab2
{
    interface IVisitor
    {
        void visit(Paragraph paragraph);
        void visit(Image image);
        void visit(Table table);
    }

    abstract class DocumentElement
    {
        public abstract void Accept(IVisitor visitor);
    }

    class Paragraph : DocumentElement 
    {
        public string text
        {
            get; set;
        }
        
        public Paragraph(string text)
        {
            this.text = text;
        }

        public override void Accept(IVisitor v)
        {
            v.visit(this);
        }
    }
    class Image : DocumentElement
    {
        public string image
        {
            get; set;
        }
        public Image(string image)
        {
            this.image = image;
        }
        public override void Accept(IVisitor v)
        {
            v.visit(this);
        }
    }
    class Table : DocumentElement 
    {
        public string table
        {
            get; set;
        }

        public Table(string table)
        {
            this.table = table;
        }

        public override void Accept(IVisitor v)
        {
            v.visit(this);
        }
    }
    class HTMLVisitor : IVisitor
    {
        public void visit(Paragraph paragraph)
        {
            
        }
        public void visit(Image image)
        {

        }
        public void visit(Table table)
        {

        }
    }

    class MarkdownVisitor : IVisitor
    {
        public void visit(Paragraph paragraph)
        {

        }
        public void visit(Image image)
        {

        }
        public void visit(Table table)
        {

        }
    }

    class Documents
    {
        private List<DocumentElement> elements = new List<DocumentElement>();

        public add(DocumentElement el)
        {
            elements.add(el);
        }
        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
