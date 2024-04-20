namespace Agenda.Models
{
    public class ContatoModel
    {
        private Guid _id;
        public Guid Id { get { return _id; } }

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private string _telefone;
        public string Telefone { get { return _telefone; } set { _telefone = value; } }

        public ContatoModel(string name, string telefone)
        {
            _name = name;
            _telefone = telefone;
        }

        public override string ToString()
        {
            return "{ " + _id + " - " + _name + " - " + _telefone + "}";
        }
    }
}