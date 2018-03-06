using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HHMES.ORM
{
    public class ParamsBridge
    {
        protected string _ConcretelyName;
        protected string[] _UsingNamespace;
        protected string _Bridge_Namespace;

        public string ConcretelyName { get { return _ConcretelyName; } set { _ConcretelyName = value; } }
        public string[] UsingNamespace { get { return _UsingNamespace; } set { _UsingNamespace = value; } }
        public string DAL_Namespace { get { return _Bridge_Namespace; } set { _Bridge_Namespace = value; } }
    }
    /// <summary>
    /// 生成数据
    /// </summary>
    public class GenerateBridge
    {

        /// <summary>
        /// 生成数据字典的数据层
        /// </summary>
        public string GenerateBaseBridge(ParamsBridge param)
        {
            StringBuilder builder = new StringBuilder();

            //.Net Framework的名字空间
            builder.AppendLine("using System;");
            builder.AppendLine("using System.Collections.Generic;");
            builder.AppendLine("using System.Text;");
            builder.AppendLine("using System.Data;");

            //引用的自定义名字空间
            foreach (string space in param.UsingNamespace)
                builder.AppendLine("using " + space + ";");

            //生成单元注释部分
            CreateComment(builder, param.ConcretelyName);


            builder.AppendLine("namespace " + param.DAL_Namespace); //当前数据层所在的名字空间
            builder.AppendLine("{");
            builder.Append("     /// <summary>");
            builder.Append("    /// DAL层桥接功能");
            builder.Append("    /// </summary>");
            builder.Append("    public class ADODirect_"+param.ConcretelyName);
            builder.Append("    {");
            builder.Append("         private IBridge_IN _DAL_Instance = null;//数据层实例");
            builder.Append("");
            builder.Append("         public ADODirect_"+param.ConcretelyName+"()");
            builder.Append("        {");
            builder.Append("             _DAL_Instance = new dal"+param.ConcretelyName+"(Loginer.CurrentUser)");
            builder.Append("        }");
            builder.Append("");
            builder.Append("        public IBridge_"+param.ConcretelyName +"  GetInstance()");
            builder.Append("        {");
            builder.Append("            retrun _DAL_Instance;");
            builder.Append("         }");
            builder.Append("    }");

            


            return builder.ToString();
        }
        /// <summary>
        /// 生成注释部分
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="concretelyName"></param>
        private void CreateComment(StringBuilder builder, string concretelyName)
        {
            builder.AppendLine("");
            builder.AppendLine("/*==========================================");
            builder.AppendLine(" *   程序说明: " + concretelyName + "的数据访问层");
            builder.AppendLine(" *   作者姓名: HHMES.com");
            builder.AppendLine(" *   创建日期: " + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            builder.AppendLine(" *   最后修改: " + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            builder.AppendLine(" *   ");
            builder.AppendLine(" *   注: 本代码由ClassGenerator自动生成");
            builder.AppendLine(" *   版权所有：HHMES.com");
            builder.AppendLine(" *==========================================*/");
            builder.AppendLine("");
        }
    }
}
