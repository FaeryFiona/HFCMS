using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using Autofac;
using Autofac.Integration.Mvc;

namespace HFCMS.Web
{
    public class AutoFacConfig
    {

        public static void Register()
        {
            XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(ConfigurationManager.AppSettings["AutoFacConfigPath"]);
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释

            XmlReader reader = XmlReader.Create(HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["AutoFacConfigPath"]), settings);
            xmlDoc.Load(reader);
            var builder = new ContainerBuilder();
            var controller = (XmlElement)xmlDoc.SelectSingleNode("autofac/controller");
            var controllerAss = Assembly.Load(controller.GetAttribute("service"));
            builder.RegisterControllers(controllerAss);
            XmlNode xn = xmlDoc.SelectSingleNode("autofac/components");
            var child = xn.ChildNodes;
            foreach (var n in child)
            {
                XmlElement xe = (XmlElement)n;
                var a = xe.GetAttribute("service");
                var assembly = Assembly.Load(a);
                Type[] rtypes = assembly.GetTypes();
                builder.RegisterTypes(rtypes)
                    .AsImplementedInterfaces();
            }
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            reader.Close();
        
        }
    }
}