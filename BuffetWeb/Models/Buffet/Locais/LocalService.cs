using BuffetWeb.Dados;

namespace BuffetWeb.Models.Buffet.Locais
{
    public class LocalService
    {
        private readonly DatabaseContext _databaseContext;

        public LocalService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
    }
}