using EarningsStatus.WPF.UI.DataAccess.EntityFramework;
using EarningsStatus.WPF.UI.Models;
using EarningsStatus.WPF.UI.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace EarningsStatus.WPF.UI.DataAccess.Utilities
{
    public class GoldTableDataCreatorUtility
    {
        public static void CreateGoldTableData()
        {
            //List<Gold> golds = new List<Gold>()
            //{
            //    new Gold(10000, 12000, 12, 20, 1350, new DateTime(2023, 3, 28)),
            //    new Gold(18000, 23000, 12, 67, 1400, new DateTime(2023, 5, 14))
            //};
            //var entity = new Gold(10000, 12000, 12, 20, 1350, new DateTime(2023, 3, 27));

            //using (var context = new GoldContext())
            //{
            //    var addedEntity = context.Entry(entity);
            //    addedEntity.State = EntityState.Added;
            //    context.SaveChanges();
            //}

            //using (GoldContext goldContext = new GoldContext())
            //{



            //Create database if does not exist
            //if (!goldContext.Database.GetService<IRelationalDatabaseCreator>().Exists())
            //{
            //    goldContext.Database.EnsureCreated();
            //    goldContext.Golds.AddRange(golds);
            //    goldContext.SaveChanges();
            //    MessageBox.Show("Database is created!");
            //}
            //else
            //{
            //    goldContext.Golds.AddRange(golds);
            //    goldContext.SaveChanges();
            //    MessageBox.Show("Database is already created!");
            //}
            //}
            //MessageBox.Show("Database could not be created!");
        }
    }
}
