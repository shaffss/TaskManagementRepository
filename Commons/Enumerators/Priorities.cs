using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Commons.Enumerators
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Priority
    {
        Critical,
        High,
        Urgent,
        Moderate,
        Normal,
        Low,
        Optional,
        Deferred,
        Backlog,
        Trivial
    }
}
