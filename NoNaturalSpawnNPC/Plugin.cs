using Terraria;
using TerrariaApi.Server;

namespace NoNaturalSpawnNPC;

[ApiVersion(2, 1)]
public class Plugin : TerrariaPlugin
{
    public override string Name => "NoNaturalSpawnNPC";
    public override string Author => "Cai";
    public override string Description => "禁止城镇NPC生成";
    public override Version Version => new Version(2025, 6,18,0);

    public Plugin(Main game) : base(game)
    {
    }

    public override void Initialize()
    {
        On.Terraria.Main.UpdateTime_SpawnTownNPCs+= MainOnUpdateTime_SpawnTownNPCs;
    }

    private static void MainOnUpdateTime_SpawnTownNPCs(On.Terraria.Main.orig_UpdateTime_SpawnTownNPCs orig)
    {
        
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            On.Terraria.Main.UpdateTime_SpawnTownNPCs -= MainOnUpdateTime_SpawnTownNPCs;
        }
    }
}