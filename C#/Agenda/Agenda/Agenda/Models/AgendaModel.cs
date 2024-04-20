namespace Agenda.Models
{
    public class AgendaModel
    {
        private readonly List<ContatoModel> _contatos;

        private static AgendaModel _instance;
        private AgendaModel()
        {
            _contatos = new List<ContatoModel>();
        }

        public static AgendaModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AgendaModel();
            }

            return _instance;
        }

        public List<ContatoModel> FindAll()
        {
            return _contatos;
        }

        public ContatoModel Save(ContatoModel contato)
        {
            foreach (var i in _contatos)
            {
                if (contato.Id == i.Id)
                {
                    return null;
                }
            }

            _contatos.Add(contato);
            return contato;
        }
    }
}
