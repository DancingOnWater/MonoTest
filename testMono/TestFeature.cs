namespace testMono
{
    class TestFeature
    {
        public static void start()
        {
            MainClass.WriteLine(nameof(TestFeature) + ": ", "start");

            ValuTupleTest();


            MainClass.WriteLine(nameof(TestFeature) + ": ", "finish");

        }

        static void ValuTupleTest()
        {
            var t = ("kukus", 1.0);

            var (str, v) = t;
            
            if(str !="kukus" || v !=1.0)
                MainClass.WriteErrorLine("ValueTuple: ", "failed", "");

            MainClass.WriteLine("ValuTuple:",  "Ok");
        }

    }
}
