using System;
using Verse;
using Verse.Sound;
using RimWorld;
using HLVR;

namespace HLVR
{
    class ApparelEquipSoundIV : ThingComp
    {
        public override void CompTick()
        {
            base.CompTick();
            if (!this.PlayedSoundOnce)
            {
                SoundDef sound = HLVRDefOf.HEV_EquipIV as SoundDef;
                sound.PlayOneShot(new TargetInfo(this.parent.Position, this.parent.Map, false));
                this.PlayedSoundOnce = true;
            }
        }

        private bool PlayedSoundOnce = false;
    }

    class CompProperties_ApparelEquipSoundIV : CompProperties
    {
        public CompProperties_ApparelEquipSoundIV()
        {
            this.compClass = typeof(ApparelEquipSoundIV);
        }
    }

    class ApparelEquipSoundV : ThingComp
    {
        public override void CompTick()
        {
            base.CompTick();
            if (!this.PlayedSoundOnce)
            {
                SoundDef sound = HLVRDefOf.HEV_EquipValve as SoundDef;
                sound.PlayOneShot(new TargetInfo(this.parent.Position, this.parent.Map, false));
                this.PlayedSoundOnce = true;
            }
        }

        private bool PlayedSoundOnce = false;
    }

    class CompProperties_ApparelEquipSoundV : CompProperties
    {
        public CompProperties_ApparelEquipSoundV()
        {
            this.compClass = typeof(ApparelEquipSoundV);
        }
    }
}
