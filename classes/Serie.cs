namespace DIO.Series
{
    public class Serie : BaseEntity
    {
        private Gender Gender { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

    }
}