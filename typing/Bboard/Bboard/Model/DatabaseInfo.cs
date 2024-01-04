using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    내용 : 데이터베이스 정보를 관리하는 모델 설계
 */

namespace Bboard.Model
{
    internal class DatabaseInfo
    {
        public string IP { get; set; }
        public string Port { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string UserPassword { get; set; }
    }
}
