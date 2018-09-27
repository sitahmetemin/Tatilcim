﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Common.General;

namespace Tatilcim.Common.Dtos
{
    public class RezerveDto: BaseDto
    {
        public int PersonCount { get; set; }
        public bool status { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Nullable<int> UserId { get; set; }

        public Nullable<int> OtelId { get; set; }

        public Nullable<int> RoomId { get; set; }
    }
}
