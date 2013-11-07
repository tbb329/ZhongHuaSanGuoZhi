﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind890 : ConditionKind
    {
        private int number = 0;

        public override bool CheckConditionKind(Person person)
        {
            return person.BelongedFaction != null && person.BelongedFaction.LeaderID == this.number;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.number = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

