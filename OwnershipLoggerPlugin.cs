﻿using NLog;
using Torch;
using Torch.API;

namespace ALE_Ownership_Logger
{
    public class OwnershipLoggerPlugin : TorchPluginBase {

        public static readonly Logger Log = LogManager.GetCurrentClassLogger();
        public static OwnershipLoggerPlugin Instance { get; private set; }

        public override void Init(ITorchBase torch) {

            base.Init(torch);

            var pgmr = new OwnershipLoggerManager(torch);
            torch.Managers.AddManager(pgmr);

            Instance = this;
        }
    }
}
