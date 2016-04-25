using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Gent_WordCloudExercies.Properties;

namespace Gent_WordCloudExercies.Utilities
{
    public static class Properties
    {
        public static string[] FilterStrings => Resources.filterStrings.Split(',');
    }
}
