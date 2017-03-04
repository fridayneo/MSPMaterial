using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSPMaterial.Model;
using MSPMaterial.View;
using System.Data.Objects;

namespace MSPMaterial.Controller
{
    public class Data
    { 
        public bbdrytw1_msp_materialsEntities context = new bbdrytw1_msp_materialsEntities();

        public void saveChange()
        {
            context.SaveChanges();
        }

        public void closeConnection()
        {
            context.Dispose();
        }

        public Boolean checkLogin(int id, string password)
        {
            using (var context = new bbdrytw1_msp_materialsEntities())
            {
                var query = (from user in context.user
                             where user.ID == id
                             && user.Password == password
                             select user).FirstOrDefault();
                if (query == null)
                {
                    return false;
                }
                else
                {
                    Account.SetUserInfo(query.ID, query.Name, query.Type);
                    return true;
                }
            }
        }

        public IEnumerable<typelist> getType(string key)
        {
            using (var context = new bbdrytw1_msp_materialsEntities())
            {
                var result = from t in context.typelist
                             select t;
                result = result.Where(t => t.list.Equals(key));
                return result.ToList();
            }
        }

        public IEnumerable<materials> getMaterials(string key, string value)
        {
            var result = from m in context.materials
                         select m;
            switch (key)
            {
                case "物料編號":
                    result = result.Where(m => m.ID.Contains(value));
                    break;
                case "物料名稱":
                    result = result.Where(m => m.Name.Contains(value));
                    break;
                case "位置-架":
                    result = result.Where(m => m.Stand.Equals(value));
                    break;
                case "位置-層":
                    result = result.Where(m => m.Level.Equals(value));
                    break;
                case "位置-區":
                    result = result.Where(m => m.Section.Equals(value));
                    break;
                case "位置-格":
                    result = result.Where(m => m.Cell.Equals(value));
                    break;
                default:
                    break;
            }
            return result.ToList();
        }

        public IEnumerable<outputlist> getOutputlist(string key, string value)
        {
            var result = from o in context.outputlist
                         select o;
            if (Account.CurrentUser.Type != "Admin")
            {
                result = result.Where(o => o.User_Name == Account.CurrentUser.User);
            }
            switch (key)
            {
                case "領料編號":
                    result = result.Where(o => o.ID.Contains(value));
                    break;
                case "物料名稱":
                    result = result.Where(o => o.Material_Name.Contains(value));
                    break;
                case "物料編號":
                    result = result.Where(o => o.Material_ID.Contains(value));
                    break;
                case "領料備註":
                    result = result.Where(o => o.Comment.Contains(value));
                    break;
                case "領料類型":
                    result = result.Where(o => o.Type.Contains(value));
                    break;
                case "領料人":
                    result = result.Where(o => o.User_Name.Contains(value));
                    break;
                default:
                    break;
            }
            result = result.OrderByDescending(o => o.Time);
            return result.ToList();
        }

        public IEnumerable<inputlist> getInputlist(string key, string value)
        {
            var result = from i in context.inputlist
                         select i;
            if (Account.CurrentUser.Type != "Admin")
            {
                result = result.Where(i => i.User_Name == Account.CurrentUser.User);
            }
            switch (key)
            {
                case "進料編號":
                    result = result.Where(i => i.ID.Contains(value));
                    break;
                case "物料名稱":
                    result = result.Where(i => i.Material_Name.Contains(value));
                    break;
                case "物料編號":
                    result = result.Where(i => i.Material_ID.Contains(value));
                    break;
                case "進料備註":
                    result = result.Where(i => i.Comment.Contains(value));
                    break;
                case "進料類型":
                    result = result.Where(i => i.Type.Contains(value));
                    break;
                case "進料人":
                    result = result.Where(i => i.User_Name.Contains(value));
                    break;
                default:
                    break;
            }
            result = result.OrderByDescending(i => i.Time);
            return result.ToList();
        }

        public IEnumerable<scrapped> getScrappedlist(string key, string value)
        {
            var result = from s in context.scrapped
                         select s;
            if (Account.CurrentUser.Type != "Admin")
            {
                result = result.Where(s => s.User_Name == Account.CurrentUser.User);
            }
            switch (key)
            {
                case "報廢編號":
                    result = result.Where(s => s.ID.Contains(value));
                    break;
                case "物料名稱":
                    result = result.Where(s => s.Material_Name.Contains(value));
                    break;
                case "物料編號":
                    result = result.Where(s => s.Material_ID.Contains(value));
                    break;
                case "報廢原因":
                    result = result.Where(s => s.Reason.Contains(value));
                    break;
                case "報廢類型":
                    result = result.Where(s => s.Type.Contains(value));
                    break;
                case "登記者":
                    result = result.Where(s => s.User_Name.Contains(value));
                    break;
                default:
                    break;
            }
            result = result.OrderByDescending(s => s.Time);
            return result.ToList();
        }

        public IEnumerable<wiplist> getWIPlist(string key, string value)
        {
            var result = from w in context.wiplist
                         select w;
            if (Account.CurrentUser.Type != "Admin")
            {
                result = result.Where(w => w.User_Name == Account.CurrentUser.User);
            }
            switch (key)
            {
                case "加工編號":
                    result = result.Where(w => w.ID.Contains(value));
                    break;
                case "物料名稱":
                    result = result.Where(w => w.Material_Name.Contains(value));
                    break;
                case "物料編號":
                    result = result.Where(w => w.Material_ID.Contains(value));
                    break;
                case "加工原因":
                    result = result.Where(w => w.Reason.Contains(value));
                    break;
                case "加工類型":
                    result = result.Where(w => w.Type.Contains(value));
                    break;
                case "登記者":
                    result = result.Where(w => w.User_Name.Contains(value));
                    break;
                default:
                    break;
            }
            result = result.OrderByDescending(w => w.Time);
            return result.ToList();
        }

        public int getListCount(string type)
        {
            DateTime today = DateTime.Now.Date;
            DateTime tomorrow = DateTime.Now.Date.AddDays(1);
            int listCount = 0;
           
            switch (type)
            {
                case "Input":
                    listCount = (from i in context.inputlist
                                 where (i.Time >= today && i.Time <= tomorrow)
                                 select i).Count();
                    break;
                case "Output":
                    listCount = (from o in context.outputlist
                                 where (o.Time >= today && o.Time <= tomorrow)
                                 select o).Count();
                    break;
                case "WIP":
                    listCount = (from w in context.wiplist
                                 where (w.Time >= today && w.Time <= tomorrow)
                                 select w).Count();
                    break;
                case "Scrapped":
                    listCount = (from s in context.scrapped
                                 where (s.Time >= today && s.Time <= tomorrow)
                                 select s).Count();
                    break;
                default:
                    break;
            }
            return listCount + 1; // 訂單由 1 開始
        }
        public void AddOutput(outputlist list, string ID, int numAmount)
        {
            context.outputlist.Add(list);
            var result = (from m in context.materials
                          where m.ID == ID
                          select m).First();
            result.CurrentAmount = numAmount;
            context.SaveChanges();
        }

        public void AddInput(inputlist list, string ID, int numAmount)
        {
            context.inputlist.Add(list);
            var result = (from m in context.materials
                          where m.ID == ID
                          select m).First();
            result.CurrentAmount = numAmount;
            context.SaveChanges();
        }

        public void AddScrapped(scrapped list, string ID, int numAmount)
        {
            context.scrapped.Add(list);
            var result = (from m in context.materials
                          where m.ID == ID
                          select m).First();
            result.CurrentAmount = numAmount;
            context.SaveChanges();
        }

        public void AddWIP(wiplist list, string ID, int numAmount)
        {
            context.wiplist.Add(list);
            var result = (from m in context.materials
                          where m.ID == ID
                          select m).First();
            result.WIPAmount = result.WIPAmount + numAmount;
            context.SaveChanges();
        }
        public void updateWIP()
        {
            context.SaveChanges();
        }

        // 繼續研究
        //public object getList<T>(T t) where T : bbdrytw1_msp_materialsEntities
        //{

        //    var type = typeof(T);

        //    object result;

        //    switch (type.Name)
        //    {
        //        case "inputlist":
        //            result = from i in context.inputlist select i;
        //            break;
        //        case "outputlist":
        //            result = from i in context.inputlist select i;
        //            break;
        //        case "wiplist":
        //            var resultd = from i in context.inputlist
        //                         select i;
        //            return resultd.ToList();
        //        case "scrapped":
        //            var resultt = from i in context.inputlist
        //                         select i;
        //            return resultt.ToList();
        //        default:
        //            return null;
        //    }
        //}
    }
}
