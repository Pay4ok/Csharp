namespace LW_7
{
    interface IExecuteble<T,G>
    {
        delegate T metod(params G[] _params);

        void LookUpNumeric(params G[] _params);
        void AddNumeric(params G[] _params);
        void RemoveNumeric(params G[] _params);

        static long GetExecTime(metod metod, params G[] _params)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            metod(_params);

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
