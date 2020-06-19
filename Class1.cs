// A C# program for Dijkstra's single 
// source shortest path algorithm. 
// The program is for adjacency matrix 
// representation of the graph 
using System;
using System.Windows.Forms;

class GFG
{
    // A utility function to find the 
    // vertex with minimum distance 
    // value, from the set of vertices 
    // not yet included in shortest 
    // path tree 
    static int V;
    public static int nilai;

    int minDistance(int[] dist,
                    bool[] sptSet)
    {
        // Initialize min value 
        int min = int.MaxValue, min_index = -1;

        for (int v = 0; v < V; v++)
            if (sptSet[v] == false && dist[v] <= min)
            {
                min = dist[v];
                min_index = v;
            }

        return min_index;
    }
    
    
    // A utility function to print 
    // the constructed distance array 
    public void printSolution(int[] dist)
    {
        Console.Write("Vertex \t\t Distance "
                      + "from Source\n");
        for (int i = 0; i < V; i++)
            Console.Write(i + " \t\t " + dist[i] + "\n");

        nilai = dist[V - 1];
        MessageBox.Show(Convert.ToString(nilai));

    }

    

    // Funtion that implements Dijkstra's 
    // single source shortest path algorithm 
    // for a graph represented using adjacency 
    // matrix representation 
    void dijkstra(int[,] graph, int src)
    {
        int[] dist = new int[V]; // The output array. dist[i] 
                                 // will hold the shortest 
                                 // distance from src to i 

        // sptSet[i] will true if vertex 
        // i is included in shortest path 
        // tree or shortest distance from 
        // src to i is finalized 
        bool[] sptSet = new bool[V];

        // Initialize all distances as 
        // INFINITE and stpSet[] as false 
        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        // Distance of source vertex 
        // from itself is always 0 
        dist[src] = 0;

        // Find shortest path for all vertices 
        for (int count = 0; count < V - 1; count++)
        {
            // Pick the minimum distance vertex 
            // from the set of vertices not yet 
            // processed. u is always equal to 
            // src in first iteration. 
            int u = minDistance(dist, sptSet);

            // Mark the picked vertex as processed 
            sptSet[u] = true;

            // Update dist value of the adjacent 
            // vertices of the picked vertex. 
            for (int v = 0; v < V; v++)

                // Update dist[v] only if is not in 
                // sptSet, there is an edge from u 
                // to v, and total weight of path 
                // from src to v through u is smaller 
                // than current value of dist[v] 
                if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    dist[v] = dist[u] + graph[u, v];
        }

        // print the constructed distance array 
        // printSolution(dist);
        nilai = dist[V - 1];

    }













    // Driver Code 
    public void utama (string kota1,string kota2)
    {
        /* Let us create the example  
graph discussed above */
        
        
      
        int[,] graph = new int[,] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} };
        GFG t = new GFG();
        if (kota1 == "Purworejo")
        {
            if (kota2 == "Berebes")
            {
                V = 10;

                int ab = 42;
                int bc = 56;
                int be = 77;
                int cd = 106;
                int df = 35;
                int fh = 32;
                int hj = 41;
                int eg = 42;
                int gi = 42;
                int ij = 111;
                int gh = 99;
                int de = 114;

                graph[0, 1] = ab;
                graph[1, 0] = ab;
                graph[1, 2] = bc;
                graph[1, 4] = be;
                graph[2, 1] = bc;
                graph[3, 2] = cd;
                graph[3, 4] = de;
                graph[3, 5] = df;
                graph[4, 1] = be;
                graph[4, 3] = de;
                graph[4, 6] = eg;
                graph[5, 3] = df;
                graph[5, 7] = fh;
                graph[6, 4] = eg;
                graph[6, 7] = gh;
                graph[6, 8] = gi;
                graph[7, 5] = fh;
                graph[7, 6] = gh;
                graph[7, 9] = hj;
                graph[8, 6] = gi;
                graph[8, 9] = ij;
                graph[9, 7] = hj;
                graph[9, 8] = ij;

            }
            else if (kota2 == "Tegal")
            {
                V = 10;

                int ab = 57;
                int bc = 64;
                int ce = 36;
                int ef = 32;
                int fg = 39;
                int gh = 47;
                int hi = 30;
                int ij = 50;
                int cj = 69;
                int bd = 46;
                int dj = 71;

                graph[0, 1] = ab;
                graph[1, 0] = ab;
                graph[1, 2] = bc;
                graph[1, 3] = bd;
                graph[2, 1] = bc;
                graph[2, 4] = ce;
                graph[2, 9] = cj;
                graph[3, 1] = bd;
                graph[3, 9] = dj;
                graph[4, 2] = ce;
                graph[4, 5] = ef;
                graph[5, 4] = ef;
                graph[5, 6] = fg;
                graph[6, 5] = fg;
                graph[6, 7] = gh;
                graph[7, 6] = gh;
                graph[7, 8] = hi;
                graph[8, 7] = hi;
                graph[8, 9] = ij;
                graph[9, 2] = cj;
                graph[9, 3] = dj;
                graph[9, 8] = ij;


            }
            else if (kota2 == "Jepara")
            {
                V = 8;

                int ab = 57;
                int bc = 64;
                int be = 81;
                int cd = 69;
                int ef = 32;
                int fh = 46;
                int dg = 88;
                int gh = 36;
                int ed = 71;
                int fg = 20;

                graph[0, 1] = ab;
                graph[1, 0] = ab;
                graph[1, 2] = bc;
                graph[1, 4] = be;
                graph[2, 1] = bc;
                graph[2, 3] = cd;
                graph[3, 2] = cd;
                graph[3, 4] = ed;
                graph[3, 7] = dg;
                graph[4, 1] = be;
                graph[4, 3] = ed;
                graph[4, 5] = ef;
                graph[5, 4] = ef;
                graph[5, 6] = fg;
                graph[5, 7] = fh;
                graph[6, 3] = dg;
                graph[6, 5] = fg;
                graph[6, 7] = gh;
                graph[7, 5] = fh;
                graph[7, 6] = gh;
            }
        }
        else if (kota1 == "Pekalongan")
        {
            if (kota2 == "Cilacap")
            {

            }
            else if (kota2 == "Klaten")
            {

            }
            else if (kota2=="Karang Anyar")
            {

            }
        }
        else if (kota1 == "Berebes")
        {
            if (kota2 == "Purworejo")
            {

            }
            else if (kota2 == "Grobogan")
            {

            }
            else if (kota2 == "Rembang")
            {

            }
        }
        else if (kota1 == "Semarang")
        {
            if (kota2 == "Banyumas")
            {

            }
            else if (kota2 == "Rembang")
            {

            }
            else if (kota2 == "Pemalang")
            {

            }
        }

        t.dijkstra(graph, 0);
        
    }
}

// This code is contributed by ChitraNayal 