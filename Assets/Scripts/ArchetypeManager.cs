using System.Collections.Generic;
using UnityEngine;

public static class ArchetypeManager
{
    private static List<Archetype> archetypes = new List<Archetype>
    {
        // Bárbaro
        new Archetype("Path of the Berserker", UniqueAbilities.BattleInstinct),
        new Archetype("Path of the Totem Warrior", UniqueAbilities.BeastTamer),
        new Archetype("Path of the Ancestral Guardian", UniqueAbilities.AuraReader),
        new Archetype("Path of the Storm Herald", UniqueAbilities.ElementalConnection),
        new Archetype("Path of the Zealot", UniqueAbilities.DivineSmite),
        new Archetype("Path of Wild Magic", UniqueAbilities.WildMagicSurge),
        new Archetype("Path of the Beast", UniqueAbilities.FormOfTheBeast),
        
        // Bardo
        new Archetype("College of Lore", UniqueAbilities.Appraisal),
        new Archetype("College of Valor", UniqueAbilities.CombatInspiration),
        new Archetype("College of Glamour", UniqueAbilities.EternalCharm),
        new Archetype("College of Swords", UniqueAbilities.WeaponBond),
        new Archetype("College of Whispers", UniqueAbilities.PsychicBlades),
        new Archetype("College of Creation", UniqueAbilities.MoteOfPotential),
        new Archetype("College of Eloquence", UniqueAbilities.SilverTongue),
        
        // Clérigo
        new Archetype("Knowledge Domain", UniqueAbilities.Appraisal),
        new Archetype("Life Domain", UniqueAbilities.MedicTouch),
        new Archetype("Light Domain", UniqueAbilities.WardingFlare),
        new Archetype("Nature Domain", UniqueAbilities.NaturesGift),
        new Archetype("Tempest Domain", UniqueAbilities.ElementalConnection),
        new Archetype("Trickery Domain", UniqueAbilities.ShadowMeld),
        new Archetype("War Domain", UniqueAbilities.DivineSmite),
        new Archetype("Forge Domain", UniqueAbilities.WeaponBond),
        new Archetype("Grave Domain", UniqueAbilities.CircleOfMortality),
        new Archetype("Order Domain", UniqueAbilities.VoiceOfAuthority),
        new Archetype("Peace Domain", UniqueAbilities.EmboldeningBond),
        new Archetype("Twilight Domain", UniqueAbilities.EyesOfNight),
        
        // Druida
        new Archetype("Circle of the Land", UniqueAbilities.NaturesGift),
        new Archetype("Circle of the Moon", UniqueAbilities.CombatWildShape),
        new Archetype("Circle of Dreams", UniqueAbilities.BalmOfTheSummerCourt),
        new Archetype("Circle of the Shepherd", UniqueAbilities.SpiritTotem),
        new Archetype("Circle of Spores", UniqueAbilities.HaloOfSpores),
        new Archetype("Circle of Stars", UniqueAbilities.StarryForm),
        new Archetype("Circle of Wildfire", UniqueAbilities.SummonWildfireSpirit),
        
        // Guerreiro
        new Archetype("Champion", UniqueAbilities.ImprovedCritical),
        new Archetype("Battle Master", UniqueAbilities.CombatSuperiority),
        new Archetype("Eldritch Knight", UniqueAbilities.WeaponBond),
        new Archetype("Arcane Archer", UniqueAbilities.ArcaneArcherLore),
        new Archetype("Cavalier", UniqueAbilities.BornToTheSaddle),
        new Archetype("Samurai", UniqueAbilities.FightingSpirit),
        new Archetype("Psi Warrior", UniqueAbilities.PsionicPower),
        new Archetype("Rune Knight", UniqueAbilities.RuneCarver),
        new Archetype("Echo Knight", UniqueAbilities.ManifestEcho),
        
        // Ladino
        new Archetype("Thief", UniqueAbilities.FastHands),
        new Archetype("Assassin", UniqueAbilities.Assassinate),
        new Archetype("Arcane Trickster", UniqueAbilities.MageHandLegerdemain),
        new Archetype("Mastermind", UniqueAbilities.MasterOfIntrigue),
        new Archetype("Swashbuckler", UniqueAbilities.FancyFootwork),
        new Archetype("Inquisitive", UniqueAbilities.EarForDeceit),
        new Archetype("Phantom", UniqueAbilities.WhispersOfTheDead),
        new Archetype("Soulknife", UniqueAbilities.PsionicPower),
        
        // Monge
        new Archetype("Way of the Open Hand", UniqueAbilities.OpenHandTechnique),
        new Archetype("Way of Shadow", UniqueAbilities.ShadowArts),
        new Archetype("Way of the Four Elements", UniqueAbilities.DiscipleOfTheElements),
        new Archetype("Way of the Drunken Master", UniqueAbilities.DrunkenTechnique),
        new Archetype("Way of the Kensei", UniqueAbilities.PathOfTheKensei),
        new Archetype("Way of the Sun Soul", UniqueAbilities.RadiantSunBolt),
        new Archetype("Way of Mercy", UniqueAbilities.ImplementsOfMercy),
        new Archetype("Way of the Astral Self", UniqueAbilities.ArmsOfTheAstralSelf),
        
        // Paladino
        new Archetype("Oath of Devotion", UniqueAbilities.SacredWeapon),
        new Archetype("Oath of the Ancients", UniqueAbilities.NaturesWrath),
        new Archetype("Oath of Vengeance", UniqueAbilities.AbjureEnemy),
        new Archetype("Oath of Conquest", UniqueAbilities.ConqueringPresence),
        new Archetype("Oath of Redemption", UniqueAbilities.EmissaryOfPeace),
        new Archetype("Oath of Glory", UniqueAbilities.PeerlessAthlete),
        new Archetype("Oath of the Watchers", UniqueAbilities.WatchersWill),
        
        // Feiticeiro
        new Archetype("Draconic Bloodline", UniqueAbilities.DraconicResilience),
        new Archetype("Wild Magic", UniqueAbilities.WildMagicSurge),
        new Archetype("Divine Soul", UniqueAbilities.DivineMagic),
        new Archetype("Shadow Magic", UniqueAbilities.EyesOfTheDark),
        new Archetype("Storm Sorcery", UniqueAbilities.TempestuousMagic),
        new Archetype("Aberrant Mind", UniqueAbilities.TelepathicSpeech),
        new Archetype("Clockwork Soul", UniqueAbilities.RestoreBalance),
        
        // Bruxo
        new Archetype("The Archfey", UniqueAbilities.FeyPresence),
        new Archetype("The Fiend", UniqueAbilities.DarkOnesBlessing),
        new Archetype("The Great Old One", UniqueAbilities.AwakenedMind),
        new Archetype("The Celestial", UniqueAbilities.HealingLight),
        new Archetype("The Hexblade", UniqueAbilities.HexbladesCurse),
        new Archetype("The Fathomless", UniqueAbilities.TentacleOfTheDeeps),
        new Archetype("The Genie", UniqueAbilities.GenieVessel),
        
        // Mago
        new Archetype("School of Abjuration", UniqueAbilities.ArcaneWard),
        new Archetype("School of Conjuration", UniqueAbilities.MinorConjuration),
        new Archetype("School of Divination", UniqueAbilities.Portent),
        new Archetype("School of Enchantment", UniqueAbilities.HypnoticGaze),
        new Archetype("School of Evocation", UniqueAbilities.SculptSpells),
        new Archetype("School of Illusion", UniqueAbilities.ImprovedMinorIllusion),
        new Archetype("School of Necromancy", UniqueAbilities.GrimHarvest),
        new Archetype("School of Transmutation", UniqueAbilities.MinorAlchemy),
        new Archetype("Bladesinging", UniqueAbilities.Bladesong),
        new Archetype("Order of Scribes", UniqueAbilities.WizardlyQuill)
    };

    public static Archetype GetRandomArchetype()
    {
        int index = Random.Range(0, archetypes.Count);
        return archetypes[index];
    }
}
