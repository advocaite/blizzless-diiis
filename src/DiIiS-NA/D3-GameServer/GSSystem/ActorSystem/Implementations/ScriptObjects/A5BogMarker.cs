﻿//Blizzless Project 2022 
using DiIiS_NA.D3_GameServer.Core.Types.SNO;
using DiIiS_NA.GameServer.Core.Types.TagMap;
//Blizzless Project 2022 
using DiIiS_NA.GameServer.GSSystem.MapSystem;
//Blizzless Project 2022 
using DiIiS_NA.GameServer.GSSystem.PlayerSystem;
//Blizzless Project 2022 
using DiIiS_NA.GameServer.MessageSystem;
//Blizzless Project 2022 
using DiIiS_NA.GameServer.MessageSystem.Message.Definitions.Animation;
//Blizzless Project 2022 
using DiIiS_NA.GameServer.MessageSystem.Message.Definitions.World;
//Blizzless Project 2022 
using System.Drawing;

namespace DiIiS_NA.GameServer.GSSystem.ActorSystem.Implementations.ScriptObjects
{
	[HandledSNO(ActorSno._x1_bog_catacombsportal_floormarker)]
	public class A5BogMarker : Gizmo
	{
		public A5BogMarker(World world, ActorSno sno, TagMap tags)
			: base(world, sno, tags)
		{
		}

		public override void OnEnter(World world)
		{
			var proximity = new RectangleF(this.Position.X - 1f, this.Position.Y - 1f, 2f, 2f);
			var scenes = this.World.QuadTree.Query<Scene>(proximity);

			var scene = scenes[0]; // Parent scene
			Gizmo marker = null;

			switch (scene.SceneSNO.Id)
			{
				case 265624:
					marker = new Gizmo(this.World, ActorSno._x1_bog_beacon_door_rune_a, this.Tags); //x1_Bog_Beacon_Door_Rune_A
					marker.EnterWorld(this.Position);
					break;
				case 265655:
					marker = new Gizmo(this.World, ActorSno._x1_bog_beacon_door_rune_b, this.Tags); //x1_Bog_Beacon_Door_Rune_B
					marker.EnterWorld(this.Position);
					break;
				case 265678:
					marker = new Gizmo(this.World, ActorSno._x1_bog_beacon_door_rune_c, this.Tags); //x1_Bog_Beacon_Door_Rune_C
					marker.EnterWorld(this.Position);
					break;
				case 265693:
					marker = new Gizmo(this.World, ActorSno._x1_bog_beacon_door_rune_d, this.Tags); //x1_Bog_Beacon_Door_Rune_D
					marker.EnterWorld(this.Position);
					break;
			}
		}
	}
}
