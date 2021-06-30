using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMarker
{
    public MapLocation location;
    public float G;
    public float H;
    public float F;
    public GameObject Marker;
    public PathMarker parent;

    public PathMarker(MapLocation l, float g,float h,float f,GameObject marker,PathMarker p)
    {
        location = l;
        G = g;
        H = h;
        F = f;
        this.Marker = marker;
        parent = p;
    }

    public override bool Equals(object obj)
    {
        if ((obj == null) || !this.GetType().Equals(obj.GetType()))
        {
            return false;
        }
        else
        {
            return location.Equals(((PathMarker)obj).location);
        }
    }
    public override int GetHashCode()
    {
        return 0;
    }
}

public class FindPathX : MonoBehaviour
{
    public Maze maze;
    public Material closedMaterial;
    public Material openedMaterial;

    List<PathMarker> open = new List<PathMarker>();
    List<PathMarker> close = new List<PathMarker>();

    public GameObject start;
    public GameObject end;
    public GameObject pathP;

    PathMarker goalNode;
    PathMarker startNode;

    PathMarker lastPos;
    bool done;

    void RemoveAllMarkers()
    {
        GameObject[] markers = GameObject.FindGameObjectsWithTag("marker");
        foreach(GameObject m in markers)
        {
            Destroy(m);
        }
    }
    void BeginSearch()
    {
        done = false;
        RemoveAllMarkers();

        List<MapLocation> locations = new List<MapLocation>();

        for (int z = 1; z < maze.depth - 1; z++)
        {
            for (int x = 1; z < maze.width - 1; x++)
            {
                if (maze.map[x, z] != 1)
                    locations.Add(new MapLocation(x, z));
            }
            locations.Shuffle();

            Vector3 startLocation = new Vector3(locations[0].x, 0, locations[0].z);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
