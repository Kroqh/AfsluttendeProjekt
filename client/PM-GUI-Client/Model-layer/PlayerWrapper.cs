using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_GUI_Client.Model_layer
{
    internal class PlayerWrapper //Wrapper class til at deserialse json
    {
        public string id { get; set; }
        public string kills { get; set; }
        public string hero { get; set; }
    }
}
