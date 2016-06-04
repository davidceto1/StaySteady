using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace StaySteady.Mobile.Models
{
    [Table("StaySteady")]
    
    public class StaySteadyTableModel
    {

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [MaxLength(8)]
        public string Name { get; set; }
        public string StabilityRate { get; set; }
        public string LastUpdate { get; set; }
        public string Age { get; set; }
        public string Temperature { get; set; }
        public string HeartRate { get; set; }
        public string HeartRateMin { get; set; }
        public string HeartRateMax { get; set; }
        public string Observations { get; set; }
    }
}
