using System;

namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context() { }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public object DoLogic(int arg)
        {
            var result = _strategy.DoAlgoritm(arg);

            return result;
        }
    }
}
