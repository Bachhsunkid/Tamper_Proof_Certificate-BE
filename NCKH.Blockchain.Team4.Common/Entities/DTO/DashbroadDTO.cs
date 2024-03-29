﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCKH.Blockchain.Team4.Common.Entities.DTO
{
    public class DashbroadDTO
    {
        public int Pending { get; set; }
        public int Connected { get; set; }
        public int Draft { get; set; }
        public int Signed { get; set; }
        public int Sent { get; set; }
        public int Received { get; set; }

        public DashbroadDTO(int pending, int connected, int draft, int signed, int sent, int received)
        {
            Pending = pending;
            Connected = connected;
            Draft = draft;
            Signed = signed;
            Sent = sent;
            Received = received;
        }
    }
}
