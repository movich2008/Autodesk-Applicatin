Autodesk Asset Management System

A WinForms application powered by TiDB Cloud (MySQL-compatible) and HelixToolkit to manage 2D/3D Autodesk asset mode



Features

# View and interact with .obj 3D models via HelixToolkit

# Upload and preview 2D/3D assets

# Role-based access control:

# Admin: User + asset management

# Editor: Upload/edit assets

# Manager: Approve/reject assets

# Viewer: View-only access

# LiveCharts visual analytics (pie and line charts)

# In-app notification system

# Modern UI with Krypton Toolkit styling

Setup Instructions

1. Clone the Repository

git clone https://github.com/movich2008/Autodesk-Applicatin.git

2. Add DLL References (Libs Folder)

DLLs in /Libs folder:

1. ComponentFactory.Krypton.Design.dll (v4.6.0.0)

2. ComponentFactory.Krypton.Docking.dll (v4.6.0.0)

3. ComponentFactory.Krypton.Navigator.dll (v4.6.0.0)

4. ComponentFactory.Krypton.Ribbon.dll (v4.6.0.0)

5. ComponentFactory.Krypton.Toolkit.dll (v4.6.0.0)

6. ComponentFactory.Krypton.Workspace.dll (v4.6.0.0)

7. HelixToolkit.Wpf.dll (v2.25.00)

8. LiveCharts.dll (v0.9.7.0)

8. LiveCharts.WinForms.dll (v0.9.7.0)

10. LiveCharts.Wpf.dll (v0.9.7.0)

	 
How to Add DLLs as Reference in Visual Studio

1.Right-click on your project in Solution Explorer

2.Click Add > Reference...

3.Click Browse tab and navigate to Libs folder

4.Select all DLLs listed above and click OK

NOTE: These DLLs are used as references, do not install them via NuGet.

NuGet Packages Used

Package/Version

BCrypt.Net-Next/4.0.2

Google.Protobuf/3.26.1

K4os.Compression.LZ4/1.3.8

K4os.Compression.LZ4.Streams/1.3.8

K4os.Hash.xxHash/1.0.8

LiveCharts/0.9.7

LiveCharts.WinForms/0.9.7

LiveCharts.Wpf/0.9.7

MySql.Data/8.0.33

System.Configuration.ConfigurationManager/9.0.4

System.Buffers/4.6.1

System.Memory/4.6.3

System.IO.Pipelines/6.0.2

System.Diagnostics.DiagnosticSource/9.0.4

System.Numerics.Vectors/4.6.1

System.Runtime.CompilerServices.Unsafe/6.1.2

System.Threading.Tasks.Extensions/4.6.3


Krypton Toolkit - Add to Toolbox

1. Right-click Toolbox > Choose Items...

2. Browse to Libs\ComponentFactory.Krypton.Toolkit.dll

3. Select all Krypton controls and click OK


LiveCharts - Add to Toolbox

1. Right-click Toolbox > Choose Items...

2. Browse to Libs\LiveCharts.WinForms.dll

3. Add controls like PieChart, CartesianChart


TiDB Cloud Setup

Step 1: Create a Free TiDB Cloud Account

a. Go to https://tidbcloud.com/ and sign up / log in

Step 2: Create a TiDB Cluster

a. Click "Create Cluster" > Serverless Tier

b. Choose region and cluster name

c. Wait for the cluster to finish provisioning

For more on how to create your own cluster watch this video: https://youtu.be/3jfxsGZExRw?si=aCZkStgTztNmWOQj

Step 3: Get Connection Credentials

a.In your TiDB cluster dashboard:

# Click Connect > Choose Standard connection (MySQL client)

# Copy the host, port, user, password, and database name

2. Click "Download CA Certificate" to verify server certificate

Step 4: Update App.config

a. Open App.config in Visual Studio

b. Replace <your-connection-string-here> with the format:
	<connectionStrings>
  <add name="MyConnection" connectionString="server=xxx.tidbcloud.com;user=your_user;password=your_pass;database=your_db;port=4000;SslMode=VerifyCA;SslCa=<CA_PATH>" providerName="MySql.Data.MySqlClient" />
</connectionStrings>

Replace <CA_PATH> with the full local path to your downloaded ca.pem file.

Troubleshooting

# Missing DLLs? Re-add from Libs folder via "Add Reference"

# Designer not loading? Ensure your Krypton and LiveCharts DLLs are correctly referenced

# DB not connecting? Make sure the port is open and ca.pem path is valid