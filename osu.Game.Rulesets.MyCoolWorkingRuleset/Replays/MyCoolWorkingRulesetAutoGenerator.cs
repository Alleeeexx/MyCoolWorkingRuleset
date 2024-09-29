// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Beatmaps;
using osu.Game.Rulesets.MyCoolWorkingRuleset.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.MyCoolWorkingRuleset.Replays
{
    public class MyCoolWorkingRulesetAutoGenerator : AutoGenerator<MyCoolWorkingRulesetReplayFrame>
    {
        public new Beatmap<MyCoolWorkingRulesetHitObject> Beatmap => (Beatmap<MyCoolWorkingRulesetHitObject>)base.Beatmap;

        public MyCoolWorkingRulesetAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
        }

        protected override void GenerateFrames()
        {
            Frames.Add(new MyCoolWorkingRulesetReplayFrame());

            foreach (MyCoolWorkingRulesetHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new MyCoolWorkingRulesetReplayFrame
                {
                    Time = hitObject.StartTime,
                    Position = hitObject.Position,
                });
            }
        }
    }
}
