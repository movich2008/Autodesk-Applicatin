using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutodeskApplication
{
    public class AssetDetails
    {
        public int AssetId { get; set; } 
        public string AssetName { get; set; }
        public string AssetDescription { get; set; }
        public string AssetFilePath { get; set; }
        public string AssetImagePath { get; set; }
        public DateTime DateAdded { get; set; }
    }
}

