﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind3210 : ConditionKind
    {
        private int val;

        public override bool CheckConditionKind(Faction faction)
        {
            foreach (Architecture a in faction.Architectures)
            {
                if (a.ID == this.val)
                {
                    return true;
                }
            }
            return false;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.val = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

