﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FfmpegClient.Representations
{
    [System.Runtime.Serialization.DataContract(Namespace = "")]  // required only if using XML
    public class FilesByNameQuery
    {
        [System.Runtime.Serialization.DataMember]
        public List<string> Names { get; set; }
    }
}
