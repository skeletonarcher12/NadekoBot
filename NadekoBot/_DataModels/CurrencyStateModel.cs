﻿namespace NadekoBot._DataModels {
    internal class CurrencyState : IDataModel {
        public long Value { get; set; }
        [SQLite.Unique]
        public long UserId { get; set; }
    }
}