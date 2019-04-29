namespace TreehouseDefense
{
  class MapLocation : Point
  {
    public MapLocation(int x, int y, Map map) : base(x, y)
    {
      if (!map.OnMap(this))
      {
        throw new OutOfBoundsException(this + "is outside the bounds of the map.");
      }
    }

    public bool InRangOf(MapLocation location, int range)
    {
      return DistanceTo(location) <= range;
    }
  }
}
