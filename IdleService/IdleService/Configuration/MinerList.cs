﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleService
{
    public class MinerList
    {

        public MinerList(string executable, string idleArguments, string activeArguments, bool mineWhileNotIdle)
        {
            this.executable = executable;
            this.idleArguments = idleArguments;
            this.activeArguments = activeArguments;
            this.mineWhileNotIdle = mineWhileNotIdle;
            shouldMinerBeRunning = false;
            isMiningIdleSpeed = false;
            minerDisabled = false;
            launchAttempts = 0;
        }

        public string executable { get; set; }
        public string idleArguments { get; set; }
        public string activeArguments { get; set; }
        public bool mineWhileNotIdle { get; set; }
        internal int launchAttempts { get; set; }
        public bool minerDisabled { get; set; }
        internal bool shouldMinerBeRunning { get; set; }
        internal bool isMiningIdleSpeed { get; set; }
    }
}
