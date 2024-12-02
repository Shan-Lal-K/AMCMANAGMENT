﻿namespace AMCMANAGMENT.Model.Base
{
    public class TimeDetails
    {
        public int Id { get; set; }
        public string CreatedId { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public string DeletedId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedTime { get; set; } = DateTime.UtcNow;
    }
}
