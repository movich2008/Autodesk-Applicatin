using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using ComponentFactory.Krypton.Toolkit;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using MySql.Data.MySqlClient;
using System.Windows.Media;

namespace AutodeskApplication
{
    public partial class AdminWelcomeControl : UserControl
    {
        private DataTable activityData = new DataTable();

        public AdminWelcomeControl(string adminEmail)
        {
            InitializeComponent();
        }

        private void AdminWelcomeControl_Load(object sender, EventArgs e)
        {
            UpdateCardStats();
            LoadAssetPieChart();
            LoadLineChart();
            LoadUserRoleBarChart();
            LoadAssetsPerEditorChart();
            LoadUserStatusPieChart();
            LoadApprovalTimeChart();
            LoadTop5BarChart();
        }

        public void UpdateCardStats()
        {
            int total = 0, approved = 0, pending = 0, rejected = 0;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT status, COUNT(*) as count FROM Assets GROUP BY status";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader["status"].ToString();
                        int count = Convert.ToInt32(reader["count"]);

                        total += count;

                        if (status == "Approved") approved = count;
                        else if (status == "Pending") pending = count;
                        else if (status == "Rejected") rejected = count;
                    }
                }
            }

            lblTotalAssets.Text = total.ToString();
            lblApprovedCount.Text = approved.ToString();
            lblPendingCount.Text = pending.ToString();
            lblRejectedCount.Text = rejected.ToString();

            LoadBarChart(approved, pending, rejected, total);
        }

        private void LoadAssetPieChart()
        {
            int approved = 0, pending = 0, rejected = 0;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT status, COUNT(*) AS count FROM Assets GROUP BY status";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader["status"].ToString();
                        int count = Convert.ToInt32(reader["count"]);

                        if (status == "Approved") approved = count;
                        else if (status == "Pending") pending = count;
                        else if (status == "Rejected") rejected = count;
                    }
                }
            }

            pieChartAssets.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Approved",
                    Values = new ChartValues<int> { approved },
                    DataLabels = true,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 139, 34))
                },
                new PieSeries
                {
                    Title = "Pending",
                    Values = new ChartValues<int> { pending },
                    DataLabels = true,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 140, 0))
                },
                new PieSeries
                {
                    Title = "Rejected",
                    Values = new ChartValues<int> { rejected },
                    DataLabels = true,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(205, 92, 92))
                }
            };
        }

        private void LoadBarChart(int approvedCount, int pendingCount, int rejectedCount, int totalAssets)
        {
            barChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Approved",
                    Values = new ChartValues<int> { approvedCount },
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 139, 34))
                },
                new ColumnSeries
                {
                    Title = "Pending",
                    Values = new ChartValues<int> { pendingCount },
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 140, 0))
                },
                new ColumnSeries
                {
                    Title = "Rejected",
                    Values = new ChartValues<int> { rejectedCount },
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(205, 92, 92))
                },
                new ColumnSeries
                {
                    Title = "Total",
                    Values = new ChartValues<int> { totalAssets },
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(70, 130, 180)) // SteelBlue
                }
            };

            barChart.AxisX.Clear();
            barChart.AxisX.Add(new Axis
            {
                Title = "Asset Status",
                Labels = new[] { "Approved", "Pending", "Rejected", "Total" }
            });

            barChart.AxisY.Clear();
            barChart.AxisY.Add(new Axis { Title = "Count" });

            barChart.LegendLocation = LegendLocation.Right;
        }

        private void LoadLineChart()
        {
            var dates = new List<string>();
            var views = new ChartValues<int>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT DATE(ViewedAt) AS ViewDate, COUNT(*) AS ViewCount FROM ViewerActivity GROUP BY ViewDate ORDER BY ViewDate";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dates.Add(Convert.ToDateTime(reader["ViewDate"]).ToString("MMM dd"));
                        views.Add(Convert.ToInt32(reader["ViewCount"]));
                    }
                }
            }

            lineChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Viewer Activity",
                    Values = views,
                    StrokeThickness = 3,
                    Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(230, 240, 255)),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(30, 144, 255)),
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 8,
                    DataLabels = true,
                    LabelPoint = point => point.Y.ToString()
                }
            };

            lineChart.AxisX.Clear();
            lineChart.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = dates
            });

            lineChart.AxisY.Clear();
            lineChart.AxisY.Add(new Axis { Title = "Views" });

            lineChart.LegendLocation = LegendLocation.Top;
        }




        private void LoadTop5BarChart()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT a.AssetName, COUNT(*) AS ViewCount
            FROM ViewerActivity v
            JOIN Assets a ON v.AssetID = a.AssetID
            GROUP BY a.AssetName
            ORDER BY ViewCount DESC
            LIMIT 5";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var labels = new List<string>();
                    var viewCounts = new List<int>();

                    while (reader.Read())
                    {
                        labels.Add(reader["AssetName"].ToString());
                        viewCounts.Add(Convert.ToInt32(reader["ViewCount"]));
                    }

                    // Define color palette
                    var brushColors = new SolidColorBrush[]
                    {
                new SolidColorBrush(System.Windows.Media.Color.FromRgb(70, 130, 180)),  // SteelBlue
                new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 99, 71)),   // Tomato
                new SolidColorBrush(System.Windows.Media.Color.FromRgb(60, 179, 113)),  // MediumSeaGreen
                new SolidColorBrush(System.Windows.Media.Color.FromRgb(238, 130, 238)), // Violet
                new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 215, 0))    // Gold
                    };

                    var seriesCollection = new SeriesCollection();

                    for (int i = 0; i < labels.Count; i++)
                    {
                        seriesCollection.Add(new ColumnSeries
                        {
                            Title = labels[i],
                            Values = new ChartValues<int> { viewCounts[i] },
                            Fill = brushColors[i % brushColors.Length]
                        });
                    }

                    barChartTopAssets.Series = seriesCollection;

                    barChartTopAssets.AxisX.Clear();
                    barChartTopAssets.AxisX.Add(new Axis
                    {
                        Title = "Assets",
                        Labels = labels,
                        LabelsRotation = 15
                    });

                    barChartTopAssets.AxisY.Clear();
                    barChartTopAssets.AxisY.Add(new Axis
                    {
                        Title = "Views"
                    });

                    barChartTopAssets.LegendLocation = LegendLocation.Right;
                }
            }
        }



        private void LoadUserRoleBarChart()
        {
            List<string> roleLabels = new List<string>();
            ChartValues<int> roleCounts = new ChartValues<int>();
            SeriesCollection seriesCollection = new SeriesCollection();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT role, COUNT(*) AS Total 
            FROM users 
            WHERE role IN ('Admin', 'Editor', 'Manager', 'Viewer')
            GROUP BY role";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string role = reader["role"].ToString();
                        int count = Convert.ToInt32(reader["Total"]);

                        // Assign distinct color per role
                        System.Windows.Media.Brush color = System.Windows.Media.Brushes.SlateGray;

                        if (role == "Admin")
                            color = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 182, 193)); // LightPink
                        else if (role == "Editor")
                            color = new SolidColorBrush(System.Windows.Media.Color.FromRgb(100, 149, 237)); // CornflowerBlue
                        else if (role == "Manager")
                            color = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 105, 180)); // HotPink
                        else if (role == "Viewer")
                            color = new SolidColorBrush(System.Windows.Media.Color.FromRgb(144, 238, 144)); // LightGreen

                        seriesCollection.Add(new ColumnSeries
                        {
                            Title = role,
                            Values = new ChartValues<int> { count },
                            Fill = color
                        });

                        roleLabels.Add(role); // Keep role names for the X-axis
                    }
                }
            }

            barChartUploadedByEditor.Series = seriesCollection;

            barChartUploadedByEditor.AxisX.Clear();
            barChartUploadedByEditor.AxisX.Add(new Axis
            {
                Title = "User Roles",
                Labels = roleLabels
            });

            barChartUploadedByEditor.AxisY.Clear();
            barChartUploadedByEditor.AxisY.Add(new Axis
            {
                Title = "Users Count"
            });

            barChartUploadedByEditor.LegendLocation = LegendLocation.Right;
        }

        private void LoadAssetsPerEditorChart()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT u.user_tag, COUNT(*) AS UploadCount
            FROM assets a
            JOIN users u ON a.EditorEmail = u.email
            WHERE u.role = 'Editor'
            GROUP BY u.user_tag
            ORDER BY UploadCount DESC
            LIMIT 5";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var labels = new List<string>();
                    var values = new ChartValues<int>();

                    while (reader.Read())
                    {
                        labels.Add(reader["user_tag"].ToString());
                        values.Add(Convert.ToInt32(reader["UploadCount"]));
                    }

                    barChartAssetsPerEditor.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Assets",
                    Values = values,
                    Fill = System.Windows.Media.Brushes.HotPink
                }
            };

                    barChartAssetsPerEditor.AxisX.Clear();
                    barChartAssetsPerEditor.AxisX.Add(new Axis
                    {
                        Title = "Editor Tag",
                        Labels = labels
                    });

                    barChartAssetsPerEditor.AxisY.Clear();
                    barChartAssetsPerEditor.AxisY.Add(new Axis
                    {
                        Title = "Uploads"
                    });

                    barChartAssetsPerEditor.LegendLocation = LegendLocation.Top;
                }
            }
        }

        private void LoadUserStatusPieChart()
        {
            int activeCount = 0;
            int deactivatedCount = 0;

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT status, COUNT(*) AS count FROM users GROUP BY status";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader["status"].ToString();
                        int count = Convert.ToInt32(reader["count"]);

                        if (status == "Active")
                            activeCount = count;
                        else if (status == "Deactivated")
                            deactivatedCount = count;
                    }
                }
            }

            pieChartUserStatus.Series = new SeriesCollection
    {
        new PieSeries
        {
            Title = "Active",
            Values = new ChartValues<int> { activeCount },
            Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(60, 179, 113)), // MediumSeaGreen
            DataLabels = true
        },
        new PieSeries
        {
            Title = "Deactivated",
            Values = new ChartValues<int> { deactivatedCount },
            Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 99, 71)), // Tomato
            DataLabels = true
        }
    };
        }


        private void LoadApprovalTimeChart()
        {
            var labels = new List<string>();
            var approvalDays = new ChartValues<double>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT AssetName, DATEDIFF(status_updated_at, DateAdded) AS DaysToApprove
            FROM assets
            WHERE status = 'Approved' AND status_updated_at IS NOT NULL";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string assetName = reader["AssetName"].ToString();
                        int days = Convert.ToInt32(reader["DaysToApprove"]);

                        labels.Add(assetName);
                        approvalDays.Add(days);
                    }
                }
            }

            barChartApprovalTime.Series = new SeriesCollection
    {
        new ColumnSeries
        {
            Title = "Days to Approve",
            Values = approvalDays,
            Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 165, 0)) // Orange
        }
    };

            barChartApprovalTime.AxisX.Clear();
            barChartApprovalTime.AxisX.Add(new Axis
            {
                Title = "Assets",
                Labels = labels,
                LabelsRotation = 15
            });

            barChartApprovalTime.AxisY.Clear();
            barChartApprovalTime.AxisY.Add(new Axis
            {
                Title = "Days"
            });

            barChartApprovalTime.LegendLocation = LegendLocation.Top;
        }


    }
}
