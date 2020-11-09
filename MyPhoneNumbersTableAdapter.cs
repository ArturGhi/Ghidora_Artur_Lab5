using System;
using System.Collections.Generic;
using System.Text;

namespace Ghidora_Artur_Lab5.PhoneNumbersDataSetTableAdapters
{
    public partial class PhoneNumbersTableAdapter
    {
        public PhoneNumbersTableAdapter(String connectionString)
        {
            this.ClearBeforeFill = true;
            this.Connection = new System.Data.SqlClient.SqlConnection(connectionString);
        }
    }
}