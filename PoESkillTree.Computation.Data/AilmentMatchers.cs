using System.Collections.Generic;
using PoESkillTree.Computation.Common.Builders.Effects;
using PoESkillTree.Computation.Common.Data;
using PoESkillTree.Computation.Data.Base;
using PoESkillTree.Computation.Data.Collections;

namespace PoESkillTree.Computation.Data
{
    /// <summary>
    /// <see cref="IReferencedMatchers"/> implementation for <see cref="IAilmentBuilder"/>s.
    /// </summary>
    public class AilmentMatchers : ReferencedMatchersBase<IAilmentBuilder>
    {
        private IAilmentBuilders Ailment { get; }

        public AilmentMatchers(IAilmentBuilders ailmentBuilders)
        {
            Ailment = ailmentBuilders;
        }

        protected override IEnumerable<ReferencedMatcherData> CreateCollection() =>
            new ReferencedMatcherCollection<IAilmentBuilder>
            {
                // chance to x/x duration
                { "ignite", Ailment.Ignite },
                { "shock", Ailment.Shock },
                { "chill", Ailment.Chill },
                { "freeze", Ailment.Freeze },
                { "bleed", Ailment.Bleed },
                { "cause bleeding", Ailment.Bleed },
                { "poison", Ailment.Poison },
                // being/while/against x
                { "ignited", Ailment.Ignite },
                { "shocked", Ailment.Shock },
                { "chilled", Ailment.Chill },
                { "frozen", Ailment.Freeze },
                { "bleeding", Ailment.Bleed },
                { "poisoned", Ailment.Poison },
            };
    }
}