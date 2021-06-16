using ASpecCore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.Infrastructure
{
    public static class SqlUserRole
    {
        public static bool IsUserReadOnly
        {
            get
            {

                int res;
                using (NPConDataModel db = new NPConDataModel())
                {
                    res = db.Database.SqlQuery<int>("select dbo.isuserronly()").Single();
                }
                return res == 1;
            }
        }

        public static bool IsUserReadWrite
        {
            get
            {
                int res;
                using (NPConDataModel db = new NPConDataModel())
                {
                    res = db.Database.SqlQuery<int>("select dbo.isuserrw()").Single();
                }
                return res == 1;
            }
        }

        public static bool IsUserEndProdAdmin
        {
            get
            {
                int res;
                using (NPConDataModel db = new NPConDataModel())
                {
                    res = db.Database.SqlQuery<int>("select dbo.isuser_endprodadmin()").Single();
                }
                return res == 1;
            }
        }

        public static bool IsUserConfirmElement => IsUserWithRole("NPCon_confirm_element");

        public static bool IsUserDesignTeam => IsUserWithRole("NPCon_DesignTeam");

        public static bool IsUserAlbumAdmin => IsUserWithRole("NPCon_album_admin");

        private static bool IsUserWithRole(string RoleName)
        {
            int res;
            using (NPConDataModel db = new NPConDataModel())
            {
                res = db.Database.SqlQuery<int>("select dbo.isuser_roleequal(@rolename)",
                    new System.Data.SqlClient.SqlParameter("@rolename", RoleName))
                    .Single();
            }
            return res == 1;

        }
    }
}
