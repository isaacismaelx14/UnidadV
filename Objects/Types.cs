namespace UnidadV.Objects
{
    public struct Types
    {
        public const string Select = "Seleccionar";
        public const string Credit = "Crédito";
        public const string Debit = "Débito";

        public List<string> TypesList = new List<string> { Select, Credit, Debit };

        public Types()
        {
        }
    }
}
