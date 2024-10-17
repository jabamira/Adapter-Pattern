using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class Requirements
    {
        private int gpuGb;
        private int HDDGb;
        private int RAMGb;
        private double cpuGhz;
        private int coresNum;

        public Requirements(int gpuGb,
                            int HDDGb,
                            int RAMGb,
                            double cpuGhz,
                            int coresNum)
        {
            this.gpuGb = gpuGb;
            this.HDDGb = HDDGb;
            this.RAMGb = RAMGb;
            this.cpuGhz = cpuGhz;
            this.coresNum = coresNum;
        }

        public int getGpuGb()
        {
            return gpuGb;
        }

        public int getHDDGb()
        {
            return HDDGb;
        }

        public int getRAMGb()
        {
            return RAMGb;
        }

        public double getCpuGhz()
        {
            return cpuGhz;
        }

        public int getCoresNum()
        {
            return coresNum;
        }
        public override string ToString()
        {
            return ($"GPU {gpuGb}Gb || HDD {HDDGb}Gb || RAM {RAMGb}Gb || CPU {cpuGhz}GHz || Cores {coresNum}");
        }
    }
}
