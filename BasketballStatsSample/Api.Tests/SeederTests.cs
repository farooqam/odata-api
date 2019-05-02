using Api.Models;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace Api.Tests
{
	public class SeederTests
	{
		[Fact]
		public void CanGetModelsFromJson()
		{
			// Arrange
			const string json = @"{
				  ""meta"": {
				    ""Season"": 2019,
				    ""Team"": ""Golden State Warriors"",
				    ""Type"": ""player.totals""
				  },
				  ""stats"": [
				    {
				      ""Rk"": 1,
				      ""Name"": ""Kevin Durant"",
				      ""Age"": 30,
				      ""G"": 78,
				      ""GS"": 78,
				      ""MP"": 2702,
				      ""FG"": 721,
				      ""FGA"": 1383,
				      ""FG%"": 0.521,
				      ""3P"": 137,
				      ""3PA"": 388,
				      ""3P%"": 0.353,
				      ""2P"": 584,
				      ""2PA"": 995,
				      ""2P%"": 0.587,
				      ""eFG%"": 0.571,
				      ""FT"": 448,
				      ""FTA"": 506,
				      ""FT%"": 0.885,
				      ""ORB"": 33,
				      ""DRB"": 464,
				      ""TRB"": 497,
				      ""AST"": 457,
				      ""STL"": 58,
				      ""BLK"": 84,
				      ""TOV"": 225,
				      ""PF"": 155,
				      ""PTS"": 2027
				    }
					]
				}";

			// Act
			var statsCollection = JsonConvert.DeserializeObject<PlayerTotalStatsCollection>(json);

			// Assert
			var metadata = statsCollection.Metadata;
			metadata.Year.Should().Be(2019);
			metadata.Team.Should().Be("Golden State Warriors");

			statsCollection.Stats.Length.Should().Be(1);

			var stats = statsCollection.Stats[0];
			stats.PlayerName.Should().Be("Kevin Durant");
			stats.Age.Should().Be(30);

			stats.GamesPlayed.Should().Be(78);
			stats.GamesStarted.Should().Be(78);

			stats.MinutesPlayed.Should().Be(2702);

			stats.FieldGoalsMade.Should().Be(721);
			stats.FieldGoalAttempted.Should().Be(1383);
			stats.FieldGoalPct.Should().Be((decimal) 0.521);

			stats.ThreePointersMade.Should().Be(137);
			stats.ThreePointersAttempted.Should().Be(388);
			stats.ThreePointerPct.Should().Be((decimal) 0.353);

			stats.TwoPointersMade.Should().Be(584);
			stats.TwoPointersAttempted.Should().Be(995);
			stats.TwoPointerPct.Should().Be((decimal)0.587);

			stats.EffectiveFieldGoalPct.Should().Be((decimal) 0.571);

			stats.FreeThrowsMade.Should().Be(448);
			stats.FreeThrowsAttempted.Should().Be(506);
			stats.FreeThrowPct.Should().Be((decimal)0.885);

			stats.OffensiveRebounds.Should().Be(33);
			stats.DefensiveRebounds.Should().Be(464);
			stats.TotalRebounds.Should().Be(497);

			stats.Assists.Should().Be(457);
			stats.Steals.Should().Be(58);
			stats.Blocks.Should().Be(84);
			stats.Turnovers.Should().Be(225);
			stats.PersonalFouls.Should().Be(155);
			stats.Points.Should().Be(2027);
		}
	}
}
