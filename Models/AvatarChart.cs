using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SetApi.Models
{
    public class AvatarChart
    {
        public long modelId;
        public string colorCode;
        public long dateTime;        //ex 20210101130000
        public string name;
        public string diagnose;

    }
}
