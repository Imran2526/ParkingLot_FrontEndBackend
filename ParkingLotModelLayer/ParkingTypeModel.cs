﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParkingLotModelLayer
{
    public class ParkingTypeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required]
        public int ParkTypeID { get; set; }

        [Required]
        public string ParkingType { get; set; }

        [Required]
        public int Charges { get; set; }
    }

}
