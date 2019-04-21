namespace TreehouseDefense
{
  class Path
  {
      private readonly MapLocation[] _path;

      public int Legnth => _path.Length;

      public Path(MapLocation[] path)
      {
        _path = path;
      }

      public MapLocation GetLocationAt(int pathStep)
      {
        return (pathStep < _path.Length) ? return _path[pathStep] : null;
      }
  }
}
