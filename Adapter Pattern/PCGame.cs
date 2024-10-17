using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public interface PCGame
    {
        string getTitle();
        int getPegiAllowedAge();
        bool isTripleAGame();
        Requirements getRequirements();
    }
    public class ComputerGameAdapter : PCGame
    {
        private ComputerGame computerGame;

        public ComputerGameAdapter(ComputerGame computerGame)
        {
            this.computerGame = computerGame;
        }

        public string getTitle()
        {
            return computerGame.getName();
        }

        public int getPegiAllowedAge()
        {
        
            if (computerGame.getPegiAgeRating() == PegiAgeRating.P3)
            {
                return 3;
            }
            else if (computerGame.getPegiAgeRating() == PegiAgeRating.P7)
            {
                return 7;
            }
            else if (computerGame.getPegiAgeRating() == PegiAgeRating.P12)
            {
                return 12;
            }
            else if (computerGame.getPegiAgeRating() == PegiAgeRating.P16)
            {
                return 16;
            }
            else if (computerGame.getPegiAgeRating() == PegiAgeRating.P18)
            {
                return 18;
            }
            return 0;
        }

        public bool isTripleAGame()
        {
            return computerGame.getBudgetInMillionsOfDollars() > 50.0;
        }

        public Requirements getRequirements()
        {
            int gpuMemoryInGB = (int)Math.Ceiling((double)computerGame.getMinimumGpuMemoryInMegabytes() / 1024 ;
            return new Requirements(
                gpuMemoryInGB,
                computerGame.getDiskSpaceNeededInGB() ,
                computerGame.getRamNeededInGb(),
                computerGame.getCoreSpeedInGhz(),
                computerGame.getCoresNeeded()
            );
        }
    }
}
