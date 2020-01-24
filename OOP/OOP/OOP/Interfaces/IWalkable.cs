namespace OOP.Interfaces
{
    public interface IWalkable
    {
        double DistanceWalked { get; }

        void Walk(int steps);
    }
}
