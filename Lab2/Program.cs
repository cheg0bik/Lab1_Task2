namespace Lab2
{
    interface IVisitor // Интерфейс визитора 
    {
        void visit(Paragraph paragraph);
        void visit(Image image);
        void visit(Table table);
    }

    abstract class DocumentElement //Абстрактный класс для различных документов
    {
        public abstract void Accept(IVisitor visitor);
    }

    class Paragraph : DocumentElement //Наследование от абстрактного класса
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
    class Image : DocumentElement //Наследование от абстрактного класса
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
    class Table : DocumentElement //Наследование от абстрактного класса
    {
        // Хз как реализовать хранение таблицы :(
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
    class HTMLVisitor : IVisitor // Реализация интерфейса
    {
        //Добавить реализацию превращения в HTML. хз как :(
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

    class MarkdownVisitor : IVisitor // Реализация интерфейса
    {
        //Добавить реализацию превращения в Markdown. хз как :(
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


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "вцйшщлзоавйцшщлва";
            Paragraph table = new Paragraph(str);

        }
    }
}
