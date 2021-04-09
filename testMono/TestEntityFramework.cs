using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace testMono
{

    [Table("simple2column")]
    class SimpleData
    {
        public int Id { get; set; }

        public string data { get; set; }
    }

    class MainManageModel : DbContext
    {
        static MainManageModel()
        {
            Database.SetInitializer<MainManageModel>(null); 
        }

        public MainManageModel() : base(Config.pgSqlConnectionString)
        {
        }

        public DbSet<SimpleData> Data { get; set; }
    }




    class TestEntityFramework
    {
        public static void start()
        {
            MainClass.WriteLine(nameof(TestEntityFramework) + ": ", "start");

            try{
                GetFromModel();
                MainClass.WriteLine("GetFromModel:", "Ok");
            }
            catch (Exception e){
                MainClass.WriteErrorLine("Entityfrmaework: ", "failed", e.StackTrace);
            }

            MainClass.WriteLine(nameof(TestEntityFramework) + ": ", "finish");
        }

        static void GetFromModel()
        {

            var context = new MainManageModel();
            var list = context.Data.ToList();

        }
    }
}
