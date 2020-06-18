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
    static int V = 17;
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
    public void utama (string kota1)
    {
        /* Let us create the example  
graph discussed above */
        int ab, af, ag, ba, bc, cb, cd, ce, dc, di, ec, ef, ei, fa, fe, fh, ga, gh, hf, hg, id, ie, al, dg, fg, gd, gf, hi, ih, ij, ji, jk, kl, la, lk, mh, kj, jg, io, mn, nm, np, oi, oq, pn, pq, qp, qo;
        //int a, b, c, d, e, f, g, h, i, j, k, l, m;


        ab = 106;
        al = 39;
        ba = 106;
        bc = 56;
        cb = 56;
        cd = 42;
        ce = 70;
        dc = 42;
        dg = 57;
        ec = 70;
        ef = 40;
        fe = 40;
        fg = 15;
        gd = 57;
        gf = 15;
        gh = 64;
        hi = 69;
        hg = 64;
        ih = 69;
        ij = 71;
        ji = 71;
        jk = 37;
        jg = 81;
        kj = 37;
        kl = 44;
        la = 39;
        lk = 44;
        mh = 36;
        mn = 32;
        nm = 32;
        np = 39;
        pn = 39;
        pq = 47;
        qp = 47;
        qo = 30;
        oq = 30;
        oi = 50;
        io = 50;

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

        if (kota1 == "semarang")
        {
           
            graph[0, 1] = ab;
            graph[0, 11] = al;
            graph[1, 0] = ba;
            graph[1, 2] = bc;
            graph[2, 1] = cb;
            graph[2, 3] = cd;
            graph[2, 4] = ce;
            graph[3, 2] = dc;
            graph[3, 6] = dg;
            graph[4, 2] = ec;
            graph[4, 5] = ef;
            graph[5, 4] = fe;
            graph[5, 6] = fg;
            graph[6, 3] = gd;
            graph[6, 5] = gf;
            graph[6, 7] = gh;
            graph[7, 8] = hi;
            graph[7, 6] = hg;
            graph[8, 7] = ih;
            graph[8, 14] = io;
            graph[8, 9] = ij;
            graph[9, 8] = ji;
            graph[9, 10] = jk;
            graph[9, 6] = jg;
            graph[10, 9] = kj;
            graph[10, 11] = kl;
            graph[11, 0] = la;
            graph[11, 10] = lk;
            graph[12, 7] = mh;
            graph[12, 13] = mn;
            graph[13, 12] = nm;
            graph[13, 15] = np;
            graph[14, 8] = oi;
            graph[14, 16] = oq;
            graph[15, 13] = pn;
            graph[15, 16] = pq;
            graph[16, 15] = qp;
            graph[16, 14] = qo;
        }

        t.dijkstra(graph, 0);
        
    }
}

// This code is contributed by ChitraNayal 