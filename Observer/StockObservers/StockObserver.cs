﻿using Observer.Notifies;
using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.StockObservers
{
    internal class StockObserver : AbstractObserver
    {
        public StockObserver(string name, ISubject sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 關閉股票行情，繼續工作", this._sub.Subjectstate, this._name);
        }
    }
}