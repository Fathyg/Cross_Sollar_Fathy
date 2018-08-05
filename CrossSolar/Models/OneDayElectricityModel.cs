using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrossSolar.Domain
{
    public class OneDayElectricityModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double Sum { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double Average { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double Maximum { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double Minimum { get; set; }

        public DateTime DateTime { get; set; }
    }
}