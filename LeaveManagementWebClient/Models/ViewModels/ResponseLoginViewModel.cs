﻿namespace LeaveManagementWebClient.Models.ViewModels
{
    public class ResponseLoginViewModel
    {
        public int id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public int departmentTypeId { get; set; }

        public string role { get; set; }
    }
}
