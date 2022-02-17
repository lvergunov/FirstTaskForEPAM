namespace FirstTaskForEPAM
{
    public abstract class SearcherBase
    {
        public abstract List<Painting> FindPaintingByAuthor(string author);
        public abstract List<Painting> FindPaintingByName(string name);
        public abstract List<Painting> FindPaintingsByDirection(string direction);
        public abstract List<Painting> FindPaintingsByGenre(string genre);
        public abstract List<Painting> FindPaintingsByYear(ushort year);
        public abstract List<Painting> FindSimilar(Painting painting);
    }
}