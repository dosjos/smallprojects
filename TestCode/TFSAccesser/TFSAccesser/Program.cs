using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client; 
namespace TFSAccesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //osl-utv-tfs2
            //http://vsin-sc-osl-072:8080/tfs
            Uri tfsUri = new Uri("http://osl-utv-tfs2:8080/tfs");
            TfsConfigurationServer configurationServer = TfsConfigurationServerFactory.GetConfigurationServer(tfsUri);

            ReadOnlyCollection<CatalogNode> collectionNodes = configurationServer.CatalogNode.QueryChildren(new[] { CatalogResourceTypes.ProjectCollection }, false, CatalogQueryOptions.None);

            foreach (var collectionNode in collectionNodes)
            {
                Guid  collectionId = new Guid(collectionNode.Resource.Properties["InstanceId"]);
                TfsTeamProjectCollection teamProjectCollection =
                    configurationServer.GetTeamProjectCollection((collectionId));

                Console.WriteLine("Collection: " + teamProjectCollection.Name);

                ReadOnlyCollection<CatalogNode> projectNodes =
                    collectionNode.QueryChildren(new[] {CatalogResourceTypes.TeamProject}, false,
                                                 CatalogQueryOptions.None);
                foreach (var projectNode in projectNodes)
                {
                    Console.WriteLine(" Team project: " + projectNode.Resource.DisplayName);

                    
                }

                TfsTeamProjectCollection tpc = new TfsTeamProjectCollection( new Uri("http://osl-utv-tfs2:8080/tfs"));
                WorkItemStore workItemStore = (WorkItemStore)tpc.GetService(typeof(WorkItemStore)); 
                WorkItemCollection queryResults = workItemStore.Query("Select [State], [Title] From WorkItem Where [Work Item Type] = 'User Story' Order By [State] Asc, [Changed Date] Desc");

                foreach (WorkItem queryResult in queryResults)
                {
                    Console.WriteLine( "  User story: " + queryResult.Title);
                }

                WorkItemCollection queryResults2 = workItemStore.Query("Select [State], [Title] From WorkItem Where [Work Item Type] = 'Task' Order By [State] Asc, [Changed Date] Desc");

                foreach (WorkItem queryResult in queryResults2)
                {
                    Console.WriteLine("  Work Item: " + queryResult.Title);
                }

                WorkItemCollection queryResults3 = workItemStore.Query("Select * From WorkItem Where [Work Item Type] = 'Bug' Order By [State] Asc, [Changed Date] Desc");

                foreach (WorkItem queryResult in queryResults3)
                {

                    Console.WriteLine("  Bug: " + queryResult.Title + "  " + queryResult.State + " " + queryResult.Fields["Assigned To"].Value);
                }
                

                //TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(new Uri("http://osl-utv-tfs2:8080/tfs"));
                //WorkItemStore workItemStore = (WorkItemStore)tpc.GetService(typeof(WorkItemStore));
                //WorkItemCollection queryResults = workItemStore.Query("Select * From WorkItem  Order By [State] Asc "); //Group by [Work Item Type]
                //List<WorkItem> itemList = new List<WorkItem>();
                //foreach (WorkItem queryResult in queryResults)
                //{
                //    itemList.Add(queryResult);
                //}
                
                //var res2 = from r in itemList
                //           group r by r.Fields["Work Item Type"] into p
                //                          select p;

                //foreach (var queryResult in res2)
                //{
                //    Console.WriteLine(queryResult.Fields["Work Item Type"].Value);
                //}

                Console.ReadKey();
            }
        }
    }
}
