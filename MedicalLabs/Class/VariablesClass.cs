
using System.Data;
using System.Drawing;


namespace MedicalLabs
{
    class VariablesClass
    {
        public static int userId, updateInvoiceId;
        public static string userName, userPassword, userJob, phoneNum;
        public static Point pos;
        public static bool backupProcess;
        public static bool sw;
        public static bool mainActive;
        public static int Save = -1;
        public static DataTable dtUserPermissions = new DataTable();
        public static int analysisId = 0;
        public static int invoId = 0;
        public static DataTable dtResults = new DataTable();

       
    }
}
