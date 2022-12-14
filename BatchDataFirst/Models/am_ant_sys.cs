using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchDataFirst.Models
{
    [Table("am_ant_sys")]
    public class am_ant_sys
    {
        public int id { get; set; }
        public string am_dom_status { get; set; }
        public string ant_dir_ind { get; set; }
        public string ant_mode { get; set; }
        public string ant_sys_id { get; set; }
        public string application_id { get; set; }
        public string aug_count { get; set; }
        public string augmented_ind { get; set; }
        public string bad_data_switch { get; set; }
        public string biased_lat { get; set; }
        public string domestic_pattern { get; set; }
        public string dummy_data_switch { get; set; }
        public string efficiency_restricted { get; set; }
        public string efficiency_theoretical { get; set; }
        public string eng_record_type { get; set; }
        public string feed_circ_other { get; set; }
        public string feed_circ_type { get; set; }
        public string grandfathered_ind { get; set; }
        public string hours_operation { get; set; }
        public string lat_deg { get; set; }
        public string lat_dir { get; set; }
        public string lat_min { get; set; }
        public string lat_sec { get; set; }
        public string lat_whole_secs { get; set; }
        public string lon_deg { get; set; }
        public string lon_dir { get; set; }
        public string lon_min { get; set; }
        public string lon_sec { get; set; }
        public string lon_whole_secs { get; set; }
        public string mainkey { get; set; }
        public string power { get; set; }
        public string q_factor { get; set; }
        public string q_factor_custom_ind { get; set; }
        public string rms_augmented { get; set; }
        public string rms_standard { get; set; }
        public string rms_theoretical { get; set; }
        public string specified_hrs_range { get; set; }
        public string tower_count { get; set; }
        public string last_update_date { get; set; }
    }
}
