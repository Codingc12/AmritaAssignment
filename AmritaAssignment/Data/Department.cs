using System;
using System.ComponentModel.DataAnnotations;

namespace AmritaAssignment.Data


    /*
     
     Created By Ramanan S

     *To Store Data returned from database
     *Each fields have getter and setter methods;


     */
{
	public class Department
	{
        [MaxLength(10000)]
        public int detp_id_ { get; set; }

        [MaxLength(216)]
        public string? dept_name { get; set; }

        public DateTime date_ { get; set; }

    }
}

