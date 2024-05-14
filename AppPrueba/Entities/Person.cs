namespace AppPrueba.Entities
{
    public class Person 
    {
        public int Id { set; get; }
        public int Dni { set; get; }
        public string Name { set; get; }
        public string NormalizedName { get; set; }
        public string Surname { set; get; }

        public string NormalizedSurname { get; set; }

    }
}
