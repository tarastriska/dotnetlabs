namespace ObjectsAndTypes
{
    static class AnimalExtensions
    {
        public static string FullDescription(this Animal animal)
        {
            return $"Animal is {animal.AnimalType.ToString()} and it's name is {animal.Name}";
        }
    }
}
