using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace isodata
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        // start values of points
        List<double> init_X = new List<double>();
        List<double> init_Y = new List<double>();

        // given point coordinates, lists for storing the coordinates of the cluster centers, standard deviations etc
        #region variables
        List<double> z_X = new List<double>();
        List<double> z_Y = new List<double>();
        List<double> avr_distance = new List<double>();
        List<double> sigma_X = new List<double>();
        List<double> sigma_Y = new List<double>();
        List<int> sigma_max_axis = new List<int>();
        List<double> sigma_max = new List<double>();
        List<int> clusters = new List<int>();
        PointPairList points = new PointPairList();
        PointPairList reserved1 = new PointPairList();
        PointPairList reserved2 = new PointPairList();
        PointPairList reserved3 = new PointPairList();
        PointPairList reserved4 = new PointPairList();
        PointPairList reserved5 = new PointPairList();
        PointPairList reserved6 = new PointPairList();
        LineItem generalCurve, curve1, curve2, curve3, curve4, curve5, curve6;
        GraphPane pane;
        static double[,] Dij = new double[14, 14];
        static double[,] Dij_c = new double[14, 14];
        Dictionary<string, double> merge_clusters = new Dictionary<string, double>();
        Dictionary<string, double> sorted_merge = new Dictionary<string, double>();
        static int K, Tn, Ts, Tc, Nc, L, I;
        double k;
        double min = 999;
        double sum_X = 0;
        double sum_Y = 0;
        double sum = 0;
        double general_distance = 0;
        int i = 1;
        bool splitted = false;
        bool afterfirst = false;
        int lastindex = 0;
    #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // point-numbering table 
        private void SetRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = row.Index.ToString();
            }
        }

        public void Clear()
        {
            statusTb.Text = string.Empty;
            z_X.Clear();
            z_Y.Clear();
            avr_distance.Clear();
            sigma_X.Clear();
            sigma_Y.Clear();
            sigma_max_axis.Clear();
            sigma_max.Clear();
            clusters.Clear();
            points.Clear();
            Array.Clear(Dij, 0, Dij.Length);
            Array.Clear(Dij_c, 0, Dij_c.Length);
            merge_clusters.Clear();
            sorted_merge.Clear();
            pointsDgv.Rows.Clear();
            pointsDgv.Refresh();
            min = 999;
            sum_X = 0;
            sum_Y = 0;
            sum = 0;
            general_distance = 0;
            i = 1;
            splitted = false;
            afterfirst = false;
            lastindex = 0;
        }

        // add a point
        private void addBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(addXTb.Text);
            int y = Convert.ToInt32(addYTb.Text);
            init_X.Add(x);
            init_Y.Add(y);
            points.Add(init_X[init_X.Count - 1], init_Y[init_Y.Count - 1], (init_X.Count).ToString());
            pointsDgv.Rows.Add(init_X[init_X.Count - 1], init_Y[init_Y.Count - 1]);
            SetRowNumber(pointsDgv);
            pointsDgv.Refresh();

            zgc.AxisChange();
            zgc.Invalidate();
            zgc.Refresh();
        }

        // count points in a cluster
        public int CountCluster(int index)
        {
            int i = 0;
            for (int j = 0; j < clusters.Count; j++)
            {
                if (clusters[j] == index)
                {
                    i++;
                }
            }
            return i;
        }

        // calculate distance between two coordinates
        public double MeasureDistance(double x, double y, double z_x, double z_y)
        {
            return Math.Sqrt(Math.Pow((x - z_x), 2) + Math.Pow((y - z_y), 2));
        }

        public bool isEven(int value)
        {
            return value % 2 == 0;
        }

        // goto method, transition between steps of the algorithm
        public void Goto(int step)
        {
            switch (step)
            {
                case 1:
                    statusTb.AppendText("Iteration " + i + "." + Environment.NewLine + Environment.NewLine, Color.Purple);
                    afterfirst = true;
                    SetParameters();
                    break;
                case 2:
                    if (!afterfirst)
                        statusTb.AppendText("Iteration " + i + "." + Environment.NewLine + Environment.NewLine, Color.Purple);
                    DistributePoints();
                    break;
                case 3:
                    CeaseClusters();
                    break;
                case 4:
                    AlignCentre();
                    break;
                case 5:
                    AvgDistance();
                    break;
                case 6:
                    GeneralDistance();
                    break;
                case 7:
                    Crossroad();
                    break;
                case 8:
                    AvgDeviation();
                    break;
                case 9:
                    MaxSigma();
                    break;
                case 10:
                    SplitCluster();
                    break;
                case 11:
                    DistanceClusters();
                    break;
                case 12:
                    SortClusters();
                    break;
                case 13:
                    MergeClusters();
                    break;
                case 14:
                    Crossroad2();
                    break;
            }
        }

        private void statusTb_TextChanged(object sender, EventArgs e)
        {
            statusTb.SelectionStart = statusTb.Text.Length;
            statusTb.ScrollToCaret();
        }

        // visual representation of result
        public void SuccessResult()
        {
            statusTb.AppendText("Algorithm execution has been terminated." + Environment.NewLine, Color.Red);
            generalCurve.Clear();
            try
            {
                reserved1.Clear();
                reserved2.Clear();
                reserved3.Clear();
                reserved4.Clear();
                reserved5.Clear();
                reserved6.Clear();
                curve1.Clear();
                curve2.Clear();
                curve3.Clear();
                curve4.Clear();
                curve5.Clear();
                curve6.Clear();
            }
            catch (NullReferenceException)
            {

            }
            for (int i = 0; i < z_X.Count; i++)
            {
                reserved6.Add(z_X[i], z_Y[i], "C-" + i);
                if (i == 0)
                {
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        if (clusters[j] == i)
                        {
                            reserved1.Add(init_X[j], init_Y[j], j.ToString());
                        }
                    }
                }
                else if (i == 1)
                {
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        if (clusters[j] == i)
                        {
                            reserved2.Add(init_X[j], init_Y[j], j.ToString());
                        }
                    }
                }
                else if (i == 2)
                {
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        if (clusters[j] == i)
                        {
                            reserved3.Add(init_X[j], init_Y[j], j.ToString());
                        }
                    }
                }
                else if (i == 3)
                {
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        if (clusters[j] == i)
                        {
                            reserved4.Add(init_X[j], init_Y[j], j.ToString());
                        }
                    }
                }
                else if (i == 4)
                {
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        if (clusters[j] == i)
                        {
                            reserved5.Add(init_X[j], init_Y[j], j.ToString());
                        }
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    if (reserved1.Count > 0)
                    {
                        curve1 = pane.AddCurve("0 cluster", reserved1, Color.Blue, SymbolType.Circle);
                        curve1.Symbol.Fill = new Fill(Color.Blue);
                        curve1.Line.IsVisible = false;
                    }
                }
                else if (i == 1)
                {
                    if (reserved2.Count > 0)
                    {
                        curve2 = pane.AddCurve("1 cluster", reserved2, Color.Red, SymbolType.Circle);
                        curve2.Symbol.Fill = new Fill(Color.Red);
                        curve2.Line.IsVisible = false;
                    }
                }
                else if (i == 2)
                {
                    if (reserved3.Count > 0)
                    {
                        curve3 = pane.AddCurve("2 cluster", reserved3, Color.Green, SymbolType.Circle);
                        curve3.Symbol.Fill = new Fill(Color.Green);
                        curve3.Line.IsVisible = false;
                    }
                }
                else if (i == 3)
                {
                    if (reserved4.Count > 0)
                    {
                        curve4 = pane.AddCurve("3 cluster", reserved4, Color.Purple, SymbolType.Circle);
                        curve4.Symbol.Fill = new Fill(Color.Purple);
                        curve4.Line.IsVisible = false;
                    }
                }
                else if (i == 4)
                {
                    if (reserved5.Count > 0)
                    {
                        curve5 = pane.AddCurve("4 cluster", reserved5, Color.Orange, SymbolType.Circle);
                        curve5.Symbol.Fill = new Fill(Color.Orange);
                        curve5.Line.IsVisible = false;
                    }
                }
                zgc.AxisChange();
                zgc.Invalidate();
            }
            curve6 = pane.AddCurve("Cluster centers", reserved6, Color.Black, SymbolType.Circle);
            curve6.Symbol.Fill = new Fill(Color.Black);
            curve6.Line.IsVisible = false;
            return;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if(init_X.Count < 5)
            {
                MessageBox.Show("There must be at least 5 points");
                return;
            }

            if (startBtn.Text == "Execute")
            {
                Clear();
                BuildGraph();
                Goto(1);
            }
            else if (startBtn.Text == "Continue")
            {
                startBtn.Text = "Execute";
                parCb.Checked = false;
                Goto(1);
            }
        }

        public void BuildGraph()
        {
            statusTb.Text += "Graph building." + Environment.NewLine + Environment.NewLine;
            pane = zgc.GraphPane;
            pane.CurveList.Clear();
            pane.XAxis.Cross = 0.0;
            pane.YAxis.Cross = 0.0;
            pane.XAxis.Scale.Min = init_X.Min() - 2;
            pane.XAxis.Scale.Max = init_X.Max() + 2;
            pane.YAxis.Scale.Min = init_Y.Min() - 2;
            pane.YAxis.Scale.Max = init_Y.Max() + 2;
            pane.Legend.IsVisible = false;
            pane.Title.IsVisible = false;
            pane.Border.IsVisible = false;
            pane.XAxis.Title.IsVisible = false;
            pane.YAxis.Title.IsVisible = false;
            for (int i = 0; i < init_X.Count(); i++)
            {
                points.Add(init_X[i], init_Y[i], (i+1).ToString());
                pointsDgv.Rows.Add(init_X[i], init_Y[i]);
            }
            SetRowNumber(pointsDgv);
            generalCurve = pane.AddCurve("", points, Color.Blue, SymbolType.Circle);
            generalCurve.Symbol.Fill = new Fill(Color.Blue);
            generalCurve.Line.IsVisible = false;
            zgc.AxisChange();
            zgc.Invalidate();
        }

        public void SetParameters()
        {
            K = Int32.Parse(KTb.Text);
            Tn = Int32.Parse(tetanTb.Text);
            Ts = Int32.Parse(tetasTb.Text);
            Tc = Int32.Parse(tetacTb.Text);
            Nc = Int32.Parse(NcTb.Text);
            L = Int32.Parse(LTb.Text);
            k = Convert.ToDouble(lowerkTb.Text);
            I = Int32.Parse(ITb.Text);
            statusTb.Text += "Setting parameters: K: " + K + ", Θn: " + Tn + ", Θs: " + Ts + ", Θc: " + Tc + ", Nc: " + Nc + ", L: "
                             + L + ", k: " + k + ", I: " + I + "." + Environment.NewLine + Environment.NewLine;
            Goto(2);
        }

        // distribute points between clusters
        public void DistributePoints()
        {
            statusTb.Text += "Distribution of points by clusters:" + Environment.NewLine;
            if (z_X.Count() < 2)
            {
                for (int i = 0; i < init_X.Count(); i++)
                    clusters.Add(0);
                statusTb.Text += "0 cluster: ";
                for(int i = 0; i < clusters.Count; i++)
                {
                    if(i == clusters.Count - 1)
                    {
                        statusTb.Text += i + "." + Environment.NewLine;
                        break;
                    }
                    if (clusters[i] == 0)
                        statusTb.Text += i + ", ";
                }
            }
            else
            {
                for(int i = 0; i < init_X.Count(); i++)
                {
                    for(int j = 0; j < z_X.Count(); j++)
                    {
                        Dij[i,j] = MeasureDistance(init_X[i], init_Y[i], z_X[j], z_Y[j]);
                    }
                    for(int j = 0; j < z_X.Count(); j++)
                    {
                        if(min > Dij[i, j])
                        {
                            min = Dij[i, j];
                            clusters[i] = j;
                        }
                    }
                    min = 999;
                }
                for(int i = 0; i < z_X.Count(); i++)
                {
                    statusTb.Text += i + " cluster: ";
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        if (clusters[j] == i)
                        {
                            lastindex = j;
                        }
                    }
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        if (clusters[j] == i)
                        {
                            if (j == lastindex)
                            {
                                statusTb.Text += j + ";" + Environment.NewLine;
                                break;
                            }
                            statusTb.Text += j + ", ";
                        }
                    }
                    lastindex = 0;
                }
            }
            statusTb.Text += Environment.NewLine;
            Goto(3);
        }

        // checking the condition of eliminating subsets
        public void CeaseClusters()
        {
            if(z_X.Count == 0)
            {
                if(init_X.Count < Nc)
                {
                    statusTb.Text += "The number of points is less than the value of parameter Nc, " +
                        "so further work of the algorithm is impossible." + Environment.NewLine + Environment.NewLine;
                    return;
                }
                else
                {
                    statusTb.Text += "0 cluster: number of points is greater than the value of parameter Nc, " +
                        "so the subset is not eliminated." + Environment.NewLine + Environment.NewLine;
                }
            }
            for(int i = 0; i < z_X.Count; i++)
            {
                if(CountCluster(i) > Nc)
                {
                    statusTb.Text += i + " cluster: number of points is greater than the value of parameter Nc, " +
                        "so the subset is not eliminated." + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    statusTb.Text += i + " cluster: The number of points is less than the value of the parameter Nc." +
                        " Subset elimination." + Environment.NewLine + Environment.NewLine;
                }
            }
            Goto(4);
        }

        // get points from a .txt
        private void fileBtn_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] data = File.ReadAllLines(ofd.FileName);
                string[] x = data[0].Split(' ');
                string[] y = data[1].Split(' ');

                foreach (string val in x) 
                {
                    init_X.Add(Convert.ToInt32(val));
                }

                foreach (string val in y)
                {
                    init_Y.Add(Convert.ToInt32(val));
                }

                BuildGraph();
            }
            
        }

        // localization and correction of cluster centers
        public void AlignCentre()
        {
            if(z_X.Count == 0)
            {
                z_X.Add(init_X.Sum(i => Convert.ToDouble(i)) / init_X.Count);
                z_Y.Add(init_Y.Sum(i => Convert.ToDouble(i)) / init_Y.Count);
                statusTb.Text += "0 cluster: localization and correction of the center. The center: " +
                    "(" + z_X[0] + ", " + z_Y[0] + ")." + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                for(int i = 0; i < z_X.Count; i++)
                {
                    for(int j = 0; j < init_X.Count; j++)
                    {
                        if(clusters[j] == i)
                        {
                            sum_X += init_X[j];
                            sum_Y += init_Y[j];
                        }
                    }
                    z_X[i] = sum_X / CountCluster(i);
                    z_Y[i] = sum_Y / CountCluster(i);
                    statusTb.Text += i + " cluster: localization and correction of the center. The center: " +
                    "(" + z_X[0] + ", " + z_Y[0] + ")." + Environment.NewLine;
                    sum_X = 0;
                    sum_Y = 0;
                }
                statusTb.Text += Environment.NewLine;
            }
            Goto(5);
        }

        // avg distance in clusters
        public void AvgDistance()
        {
            for(int i = 0; i < z_X.Count; i++)
            {
                for (int j = 0; j < init_X.Count; j++)
                {
                    if (clusters[j] == i)
                    {
                        sum += MeasureDistance(init_X[j], init_Y[j], z_X[i], z_Y[i]);
                    }
                }
                if (avr_distance.Count < i + 1)
                    avr_distance.Add(sum / CountCluster(i));
                else
                    avr_distance[i] = sum / CountCluster(i);
                statusTb.Text += i + " cluster: calculating average distance D: " + avr_distance[i] + "." + Environment.NewLine;
                sum = 0;
            }
            statusTb.Text += Environment.NewLine;
            Goto(6);
        }

        // generalized distance between clusters
        public void GeneralDistance()
        {
            if (avr_distance.Count == 1)
            {
                general_distance = 0;
                statusTb.Text += "Generalized distance calculations are impossible because there is only one cluster." + Environment.NewLine;
            }
            else
            {
                for(int i = 0; i < avr_distance.Count; i++)
                {
                    sum += avr_distance[i] * CountCluster(i);
                }
                general_distance = sum / init_X.Count;
                statusTb.Text += "Calculating generalized distance D: " + general_distance + "." + Environment.NewLine;
            }
            statusTb.Text += Environment.NewLine;
            Goto(7);
        }

        // forwarding (7 step)
        public void Crossroad()
        {
            if (i == I)
            {
                statusTb.Text += "The current iteration cycle is the last one, so Θc = 0. " +
                    "Going to step 11." + Environment.NewLine + Environment.NewLine;
                Tc = 0;
                Goto(11);
            }
            else if (Nc <= K / 2)
            {
                statusTb.Text += "The value of parameter Nc is less than or equal to K / 2. " +
                    "Going to step 8." + Environment.NewLine + Environment.NewLine;
                Goto(8);
            }
            else if (isEven(i) || Nc >= K / 2)
            {
                statusTb.Text += "The value of the current cycle is an even number, " +
                    "or the value of parameter Nc is greater than or equal to K / 2. " +
                    "Going to step 11." + Environment.NewLine + Environment.NewLine;
                Goto(11);
            }
            else
            {
                statusTb.Text += "Going to step 8" + Environment.NewLine + Environment.NewLine;
                Goto(8);
            }
        }
        
        // standard deviation
        public void AvgDeviation()
        {
            for(int i = 0; i < z_X.Count; i++)
            {
                for (int j = 0; j < init_X.Count; j++)
                {
                    if (clusters[j] == i)
                    {
                        sum_X += Math.Pow(init_X[j] - z_X[i], 2);
                        sum_Y += Math.Pow(init_Y[j] - z_Y[i], 2);
                    }
                }
                if (sigma_X.Count < i + 1)
                {
                    sigma_X.Add(Math.Sqrt(sum_X / init_X.Count));
                    sigma_Y.Add(Math.Sqrt(sum_Y / init_X.Count));
                }
                else
                {
                    sigma_X[i] = (Math.Sqrt(sum_X / init_X.Count));
                    sigma_Y[i] = (Math.Sqrt(sum_Y / init_X.Count));
                }
                statusTb.Text += i + " cluster: calculating standard deviation vector " +
                    "σ: (" + sigma_X[i] + ", " + sigma_Y[i] + ")." + Environment.NewLine;
                sum_X = 0;
                sum_Y = 0;
            }
            statusTb.Text += Environment.NewLine;
            Goto(9);
        }

        // find the biggest component of standard deviation vector
        public void MaxSigma()
        {
            for (int i = 0; i < sigma_X.Count; i++)
            {
                if(sigma_X[i] > sigma_Y[i])
                {
                    statusTb.Text += i + " cluster: finding biggest component of standard deviation vector σ max: "
                        + sigma_X[i] + "." + Environment.NewLine;
                    if (sigma_max_axis.Count < i + 1)
                    {
                        sigma_max_axis.Add(0);
                        sigma_max.Add(sigma_X[i]);
                    }
                    else
                    {
                        sigma_max_axis[i] = 0;
                        sigma_max[i] = sigma_X[i];
                    }
                }
                else
                {
                    statusTb.Text += i + " cluster: finding biggest component of standard deviation vector σ max: "
                        + sigma_Y[i] + "." + Environment.NewLine;
                    if (sigma_max_axis.Count < i + 1)
                    {
                        sigma_max_axis.Add(1);
                        sigma_max.Add(sigma_Y[i]);
                    }
                    else
                    {
                        sigma_max_axis[i] = 1;
                        sigma_max[i] = sigma_Y[i];
                    }
                }
            }
            statusTb.Text += Environment.NewLine;
            Goto(10);
        }

        public void SplitCluster()
        {
            for (int i = 0; i < sigma_max.Count; i++)
            {
                if(sigma_max[i] > Ts && ((avr_distance[i] > general_distance 
                    && CountCluster(i) > 2*(Tn + 1)) || CountCluster(i) < K / 2))
                {
                    splitted = true;
                    if(sigma_max_axis[i] == 0)
                    {
                        z_X.Insert(i + 1, z_X[i] - k * sigma_max[i]);
                        z_X[i] = z_X[i] + k * sigma_max[i];
                        z_Y.Insert(i + 1, z_Y[i]);
                        statusTb.Text += i + " cluster: splitting by Z+: (" + z_X[i] + ", " + z_Y[i] + ")" +
                            ", Z-: (" + z_X[i+1] + ", " + z_Y[i+1] + ")." + Environment.NewLine;
                    }
                    else
                    {
                        z_Y.Insert(i + 1, z_Y[i] - k * sigma_max[i]);
                        z_Y[i] = z_Y[i] + k * sigma_max[i];
                        z_X.Insert(i + 1, z_X[i]);
                        statusTb.Text += i + " cluster: splitting by Z+: (" + z_X[i] + ", " + z_Y[i] + ")" +
                            ", Z-: (" + z_X[i + 1] + ", " + z_Y[i + 1] + ")." + Environment.NewLine;
                    }
                    statusTb.Text += "Incrementing Nc parameter value: " + Nc + "." + Environment.NewLine;
                    Nc++;
                }
            }
            if (splitted)
            {
                i++;
                splitted = false;
                statusTb.Text += "Goint to " + i + " iteraion cycle. 2 step." + Environment.NewLine + Environment.NewLine;
                afterfirst = false;
                Goto(2);
            }
            else
            {
                statusTb.Text += "Splitting is impossible. Going to step 11" + Environment.NewLine + Environment.NewLine;
                Goto(11);
            }   
        }

        // distance between clusters
        public void DistanceClusters()
        {
            if (z_X.Count > 1)
            {
                for (int i = 0; i < z_X.Count - 1; i++)
                {
                    for (int j = i+1; j < z_X.Count; j++)
                    {
                        Dij_c[i, j] = MeasureDistance(z_X[i], z_Y[i], z_X[j], z_Y[j]);
                        statusTb.Text += "D(" + i + ", " + j + "): " + Dij_c[i, j];
                        if (Dij_c[i, j] < Tc)
                        {
                            if(merge_clusters.Count != L)
                            {
                                merge_clusters.Add(i.ToString() + j.ToString(), Dij_c[i, j]);
                                statusTb.Text += " < Θc. Merging of pairs of cluster centers is possible." + Environment.NewLine;
                            }
                            else
                            {
                                statusTb.Text += " < Θc. Merging of pairs of cluster centers is possible, " +
                                    "but the number of possible pairs has reached the maximum, " +
                                    "so these centers will not be merged." + Environment.NewLine;
                            }

                        }
                        else
                            statusTb.Text += " > Θc. Merging of pairs of cluster centers is impossible." + Environment.NewLine;
                    }
                }
            }
            else
            {
                statusTb.Text += "Because there is only one cluster, " +
                    "it is not possible to measure the distance between cluster centers" + Environment.NewLine;
            }
            statusTb.Text += Environment.NewLine;
            Goto(12);
        }

        // ranking and sorting the distances between pairs of clusters to be merged
        public void SortClusters()
        {
            if (merge_clusters.Count > 0)
            {
                foreach (KeyValuePair<string, double> item in merge_clusters.OrderBy(key => key.Value))
                {
                   sorted_merge.Add(item.Key, item.Value);
                }
                statusTb.Text += "Ranking of distances between pairs of clusters in ascending order:" + Environment.NewLine;
                int k = 1;
                foreach(var item in sorted_merge)
                {
                    statusTb.Text += k + ". D" + item.Key + ": " + item.Value + ";" + Environment.NewLine;
                }
                statusTb.Text += Environment.NewLine;
                Goto(13);
            }
            else
            {
                statusTb.Text += "No pair of cluster centers is merged. Go to step 14." + Environment.NewLine + Environment.NewLine;
                Goto(14);
            }
        }

        public void MergeClusters()
        {
            if(sorted_merge.Count > 0)
            {
                statusTb.Text += "Merging centers of clusters:" + Environment.NewLine + Environment.NewLine;
                merge_clusters.Clear();
                sorted_merge.Clear();
                Goto(14);
            }
            else
            {
                statusTb.Text += "No pair of cluster centers is merged. Go to step 14." + Environment.NewLine + Environment.NewLine;
                Goto(14);
            }
        }

        // forwading (14 step)
        public void Crossroad2()
        {
            if (i == I)
            {
                statusTb.Text += "The current iteration cycle is the last one, " +
                    "so the execution of the algorithm is terminated. Result:" + Environment.NewLine;
                for (int i = 0; i < z_X.Count(); i++)
                {
                    statusTb.Text += i + " cluster: ";
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        if (clusters[j] == i)
                        {
                            lastindex = j;
                        }
                    }
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        if (clusters[j] == i)
                        {
                            if (j == lastindex)
                            {
                                statusTb.Text += j + ". ";
                                break;
                            }
                            statusTb.Text += j + ", ";
                        }
                    }
                    statusTb.AppendText("The center of cluster: (" + z_X[i] + ", " + z_Y[i] + ");" + Environment.NewLine);
                }
                SuccessResult();
                GetParameters();
            }
            else if (parCb.Checked)
            {
                statusTb.AppendText("Changing the settings at the user's request. Click the \"Continue\" button to continue." 
                    + Environment.NewLine + Environment.NewLine, Color.Blue);
                startBtn.Text = "Continue";
                i++;
                GetParameters();
                return;
            }
            else
            {
                statusTb.Text += "The parameters remain unchanged. Go to step 2." + Environment.NewLine + Environment.NewLine;
                i++;
                GetParameters();
                Goto(2);
            }
        }

        public void GetParameters()
        {
            KaTb.Text = K.ToString() + ";";
            tetanaTb.Text = Tn.ToString() + ";";
            tetasaTb.Text = Ts.ToString() + ";";
            tetacaTb.Text = Tc.ToString() + ";";
            NcaTb.Text = Nc.ToString() + ";";
            LaTb.Text = L.ToString() + ";";
            lowerkaTb.Text = k.ToString() + ";";
            IaTb.Text = i.ToString() + ";";
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
