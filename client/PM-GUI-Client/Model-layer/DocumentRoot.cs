using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_GUI_Client.Model_layer
{
    internal class DocumentRoot //DATA API returns a json file with document as its roots, this class is needed as a wrapper for deserializing the json
    {
        public List<MatchWrapper> documents { get; set; }
    }
}
