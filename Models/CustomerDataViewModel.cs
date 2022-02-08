using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intergration.Models
{
    public class CustomerDataViewModel
    {
        public string docid { get; set; }
        public int custage { get; set; }
        public string comment { get; set; }
        public string custname { get; set; }
        public string doctorname { get; set; }
        public string sex { get; set; }
        public string custmob { get; set; }
        public string custtel { get; set; }
        public string agemeza { get; set; }
        public string ename { get; set; }
        public string custadd { get; set; }
        public string CallComment { get; set; }
        
        


        public int dayserial { get; set; }
        public string custcode { get; set; }
        public Nullable<bool> checksokr { get; set; }
        public Nullable<bool> checkghoda { get; set; }
        public Nullable<bool> checkprothh { get; set; }
        public string prothcomment { get; set; }
        public Nullable<double> testcount { get; set; }
        public string deels { get; set; }
        public Nullable<bool> printed { get; set; }
        public Nullable<bool> Deliverd { get; set; }
        public Nullable<bool> reviewed { get; set; }
        public string Reason { get; set; }
        public string u_Create { get; set; }
        public string u_pull1 { get; set; }
        public string u_pull2 { get; set; }
        public string u_pullunder { get; set; }
        public string u_Computer_by { get; set; }
        public string u_computer_in { get; set; }
        public string u_tzrf { get; set; }
        public string u_delv { get; set; }
        public string u_whatsapp { get; set; }
        public string u_printedBy { get; set; }
        public int u_Createid { get; set; }
        public Nullable<int> u_pull1id { get; set; }
        public Nullable<int> u_pull2id { get; set; }
        public Nullable<int> u_pullunderid { get; set; }
        public Nullable<int> u_Computer_byid { get; set; }
        public Nullable<int> u_computer_inid { get; set; }
        public Nullable<int> u_tzrfid { get; set; }
        public Nullable<int> u_delvid { get; set; }
        public Nullable<int> u_whatsappid { get; set; }
        public Nullable<int> u_printedid { get; set; }
        public string DT_createCLINT { get; set; }
        public string DT_Pull1 { get; set; }
        public string DT_Pull2 { get; set; }
        public string DT_PullUnder { get; set; }
        public string DT_TZrf { get; set; }
        public string DT_Delv { get; set; }
        public string DT_createSERVER { get; set; }
        public Nullable<double> THETOTAL { get; set; }
        public Nullable<double> PAIED { get; set; }
        public Nullable<double> DISCVALUE { get; set; }
        public Nullable<double> DISCRATE { get; set; }
        public Nullable<double> OTHERS { get; set; }
        public Nullable<double> LATER { get; set; }
        public string DT_ResultDone { get; set; }
        public string DT_Printed { get; set; }
    }


}
